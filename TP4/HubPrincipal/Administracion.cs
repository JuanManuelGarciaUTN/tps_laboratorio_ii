using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Vista
{
    public partial class Administracion : Form
    {
        private ManejadorDeTurnos manejadorDeTurnos;
        private Hub.CambiarEstadoBGM delegadoBGM;
        private SoundPlayer playerSFX;
        private RecordatorioEvent recordatorioCadaMediaHora;
        public Administracion(SoundPlayer playerSFX, Hub.CambiarEstadoBGM delegadoBGM)
        {
            InitializeComponent();
            this.playerSFX = playerSFX;
            this.delegadoBGM = delegadoBGM;
            recordatorioCadaMediaHora = new RecordatorioEvent();
            manejadorDeTurnos = new ManejadorDeTurnos("./archivos/precios");
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            ActualizarTurnos();
            ActualizarHistorial();
            DeterminarEstadoInicialBGM();
            selectorFechaTurnos.MinDate = DateTime.Now;
            selectorFechaHistorial.MaxDate = DateTime.Now;
            btnGenerarTurno.Focus();

            recordatorioCadaMediaHora.OnTiempoCumplido += InformarSiHayUnTurnoPendiente;
            recordatorioCadaMediaHora.IniciarCadaHora(30);
            recordatorioCadaMediaHora.IniciarCadaHora(0);
        }

        private void selectorFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTurnos();
            if(selectorFechaTurnos.Value.DayOfYear != DateTime.Now.DayOfYear)
            {
                btnAtender.Enabled = false;
            }
            else
            {
                btnAtender.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            try
            {
                Turno turnoAModificar = (Turno)lstTurnos.SelectedItem;
                if (turnoAModificar.Fecha > DateTime.Now.AddHours(2))
                {
                    Reservador reservardorTurnos = new Reservador(manejadorDeTurnos, turnoAModificar, playerSFX, delegadoBGM);
                    this.Hide();
                    reservardorTurnos.ShowDialog();
                    ActualizarTurnos();
                    ActualizarHistorial();
                    DeterminarEstadoInicialBGM();
                    this.Show();
                }
                else
                {
                    string mensajeError = $"No se puede modificar el turno seleccionado{Environment.NewLine}" +
                                          $"Para poder modificar un turno deben faltar mas de 2 horas para el horario acordado";

                    MessageBox.Show(mensajeError, "Seleccion Invalida", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un turno para modificar", "Faltan Datos", MessageBoxButtons.OK);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            //elimino de la vista del usuario el turno
            Turno? turnoAtendido = BorrarDeLaVistaTurnoSeleccionado();

            if (turnoAtendido is not null)
            {
                //actualizo la base de datos con el turno atendido
                manejadorDeTurnos.MarcarTurnoComoAtendido(turnoAtendido);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            //elimino de la vista del usuario el turno
            Turno? turno = BorrarDeLaVistaTurnoSeleccionado();

            if(turno is not null)
            {
                //actualizo la base de datos eliminando el turno
                manejadorDeTurnos.EliminarTurno(turno);
            }
        }

        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            Reservador reservardorTurnos = new Reservador(playerSFX, delegadoBGM);
            this.Hide();
            reservardorTurnos.ShowDialog();
            DeterminarEstadoInicialBGM();
            this.Show();
            ActualizarTurnos();
        }

        private void btnCambiarPrecios_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            ModificadorDePrecios modificadorDePrecios = new ModificadorDePrecios(manejadorDeTurnos);
            this.Hide();
            modificadorDePrecios.ShowDialog();
            this.Show();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Anyfile|*";
            openFile.ShowDialog();
            string path = openFile.FileName;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    manejadorDeTurnos.ObtenerTurnos(path);
                    ActualizarTurnos();
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo No Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Anyfile|*";
            saveFile.ShowDialog();
            string path = saveFile.FileName;

            manejadorDeTurnos.GuardarTurnos(path);
        }

        private void btnCambiarEstadoBGM_Click(object sender, EventArgs e)
        {
            AsignarEstadoActualBGM();
            tabControl.Focus();
        }

        /// <summary>
        /// Actualiza la lista de turnos del dia seleccionado
        /// </summary>
        private void ActualizarTurnos()
        {
            DateTime fechaSeleccionada = selectorFechaTurnos.Value;
            lstTurnos.DataSource = manejadorDeTurnos.ObtenerTurnosDelDia(fechaSeleccionada, false);
        }

        /// <summary>
        /// Actualiza la lista del historial del dia seleccionado
        /// </summary>
        private void ActualizarHistorial()
        {
            DateTime fechaSeleccionada = selectorFechaHistorial.Value;
            lstHistorial.DataSource = manejadorDeTurnos.ObtenerTurnosDelDia(fechaSeleccionada, true);
            if (lstHistorial.Items.Count == 0)
            {
                rtbDatosExtendidos.Text = "";
            }
        }

        /// <summary>
        /// Elimina el turno que se encuentra seleccionado de la lista que se le muestra al usuario
        /// </summary>
        /// <returns>Turno que estaba seleccionado - o null si no hay un turno seleccionado</returns>
        private Turno? BorrarDeLaVistaTurnoSeleccionado()
        {
            try
            {
                //obtengo el turno seleccionado a borrar 
                Turno turnoABorrar = (Turno)lstTurnos.SelectedItem;

                //creo una copia de la lista, porque no se puede modificar el DataSource directamente
                List<Turno> listaDeTurnosActualizada = (List<Turno>)lstTurnos.DataSource;

                //elimino el turno de la lista que se le muestra al usuario y actualizo la vista
                listaDeTurnosActualizada.Remove(turnoABorrar);
                lstTurnos.DataSource = null;
                lstTurnos.DataSource = listaDeTurnosActualizada;

                return turnoABorrar;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ningun turno seleccionado", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        private void AsignarEstadoActualBGM()
        {
            if (delegadoBGM.Invoke())
            {
                btnCambiarEstadoBGM.Text = "Apagar Musica";
            }
            else
            {
                btnCambiarEstadoBGM.Text = "Encender Musica";
            }
        }

        private void DeterminarEstadoInicialBGM()
        {
            delegadoBGM.Invoke();
            AsignarEstadoActualBGM();
        }

        private void InformarSiHayUnTurnoPendiente()
        {
            //Utilizo task para que en caso de no estar actualmente visible el form
            //Espere a que se vuelva visible para mostrar el recordatorio
            //Y que el bucle while(this.Visible == false) no congele la ejecucion actual
            Task.Run(() =>
            {
                long horaAVerificar = DateTime.Now.ObtenerFormatoFechaHoraLong();
                while (this.Visible == false)
                {
                }
                try
                {
                    Turno turno = manejadorDeTurnos.ObtenerTurnoPorHorario(horaAVerificar);

                    string mensaje = $"Hay Un Turno Pendiente:{Environment.NewLine}{Environment.NewLine}" +
                                     $"{turno.Mostrar()}";

                    playerSFX.Play();
                    MessageBox.Show(mensaje, "Recordatorio de Turno", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                }
            }
            );
        }

        private void selectorFechaHistorial_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHistorial();
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ActualizarHistorial();
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtbDatosExtendidos.Text = ((Turno)lstHistorial.SelectedItem).MostrarCompacto();
            }
            catch(Exception)
            {
                rtbDatosExtendidos.Text = "";
            }
        }
    }
}
