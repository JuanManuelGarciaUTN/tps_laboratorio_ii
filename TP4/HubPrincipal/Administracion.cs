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
    /// <summary>
    /// Parte del proyecto que contiene los temas:
    /// Tema 19 - Programacion multi-hilo y concurrencia
    /// Tema 20 - Evento
    /// </summary>
    public partial class Administracion : Form
    {
        //atributos
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

            //asocio el metodo al respectivo evento
            recordatorioCadaMediaHora.OnTiempoCumplido += InformarSiHayUnTurnoPendiente;
            //inicia el recordatorio del evento cada 30 minutos (cuando la hora es XX:00 y XX:30)
            recordatorioCadaMediaHora.IniciarCadaHora(30);
            recordatorioCadaMediaHora.IniciarCadaHora(0);
        }

        private void selectorFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTurnos();
            //si la fecha seleccionado no es hoy, no se puede indicar que un turno fue atendido
            if(selectorFechaTurnos.Value.Date != DateTime.Now.Date)
            {
                btnAtender.Enabled = false;
            }
            else
            {
                btnAtender.Enabled = true;
            }
        }
        private void selectorFechaHistorial_ValueChanged(object sender, EventArgs e)
        {
            ActualizarHistorial();
            ActualizarRecaudacion();
        }
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            ActualizarHistorial();
            ActualizarRecaudacion();
        }

        private void lstHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtbDatosExtendidos.Text = ((Turno)lstHistorial.SelectedItem).MostrarCompacto();
            }
            catch (Exception)
            {
                rtbDatosExtendidos.Text = "";
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
                    //al finalizar el reservado de turnos actualiza la vista
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

        /// <summary>
        /// Invoca el metodo asociado al delegado
        /// y modifica el texto del boton cambiar estado BGM segun corresponda
        /// </summary>
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

        /// <summary>
        /// Determina si la musica esta sonando o no, 
        /// para asi asignar correctamente el estado inicial del boton cambiar estado BGM
        /// </summary>
        private void DeterminarEstadoInicialBGM()
        {
            delegadoBGM.Invoke();
            AsignarEstadoActualBGM();
        }

        /// <summary>
        /// Metodo asociado al evento de recordatorio cada 30 minutos
        /// Si hay un turno pendiente, al cumplise la hora muestra un recordatorio
        /// de que hay un turno pendiente, con los datos del mismo.
        /// 
        /// Si se esta actualmente en otro form secundario a este, espera a que se vuelva
        /// la vista a este form para mostrar el recordatorio
        /// </summary>
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
                    Turno turno = manejadorDeTurnos.ObtenerTurnoSegunFecha(horaAVerificar);

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

        /// <summary>
        /// Actualiza el valor de la recaudacion de los ultimos 365 dias
        /// </summary>
        private void ActualizarRecaudacion()
        {
            DateTime fechaDesde = selectorFechaHistorial.Value;
            float recaudacionDia = manejadorDeTurnos.ObtenerRecuadacion(fechaDesde, 1);
            float recaudacionUltimos7 = manejadorDeTurnos.ObtenerRecuadacion(fechaDesde, 7);
            float recaudacionUltimos31 = manejadorDeTurnos.ObtenerRecuadacion(fechaDesde, 31);
            float recaudacionUltimos365 = manejadorDeTurnos.ObtenerRecuadacion(fechaDesde, 365);

            StringBuilder informeDeRecaudacion = new StringBuilder();
            informeDeRecaudacion.AppendLine($"{fechaDesde.ToString("dd-MM-yyyy")}");
            informeDeRecaudacion.AppendLine($"   ${recaudacionDia.ToString("N0")}");
            informeDeRecaudacion.AppendLine($"Ultimos 7 Días");
            informeDeRecaudacion.AppendLine($"   ${recaudacionUltimos7.ToString("N0")}");
            informeDeRecaudacion.AppendLine($"Ultimos 31 Días");
            informeDeRecaudacion.AppendLine($"   ${recaudacionUltimos31.ToString("N0")}");
            informeDeRecaudacion.AppendLine($"Ultimos 365 Días");
            informeDeRecaudacion.Append($"   ${recaudacionUltimos365.ToString("N0")}");

            rtbRecaudacion.Text = informeDeRecaudacion.ToString();
        }
    }
}
