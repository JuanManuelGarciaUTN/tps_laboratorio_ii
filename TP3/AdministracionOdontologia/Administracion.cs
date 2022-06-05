using LogicaDeNegocio;
using ReservaDeTurno;
using System;
using System.Windows.Forms;
using ModificarPrecios;
using System.IO;

namespace AdministracionOdontologia
{
    public partial class Administracion : Form
    {
        private ManejadorDeTurnos manejadorDeTurnos;
        public Administracion()
        {
            InitializeComponent();
            manejadorDeTurnos = new ManejadorDeTurnos("./archivos/turnos", "./archivos/precios");
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            ActualizarTurnos();
            selectorFecha.MinDate = DateTime.Now;
        }

        private void selectorFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTurnos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Turno turnoAModificar = (Turno)lstTurnos.SelectedItem;
                Reservador reservardorTurnos = new Reservador(manejadorDeTurnos, turnoAModificar);
                this.Hide();
                reservardorTurnos.ShowDialog();
                ActualizarTurnos();
                this.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un turno para modificar", "Faltan Datos");
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            BorrarTurnoSeleccionado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BorrarTurnoSeleccionado();
        }

        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            manejadorDeTurnos.GuardarTurnos();
            Reservador reservardorTurnos = new Reservador();
            this.Hide();
            reservardorTurnos.ShowDialog();
            this.Show();
            manejadorDeTurnos.ObtenerTurnos();
            ActualizarTurnos();
        }

        private void btnCambiarPrecios_Click(object sender, EventArgs e)
        {
            ModificadorDePrecios modificadorDePrecios = new ModificadorDePrecios(manejadorDeTurnos);
            this.Hide();
            modificadorDePrecios.ShowDialog();
            this.Show();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Anyfile|*";
            openFile.ShowDialog();
            string path = openFile.FileName;
            try
            {
                manejadorDeTurnos.ObtenerTurnos(path);
                manejadorDeTurnos.GuardarTurnos();
                ActualizarTurnos();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Archivo No Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception)
            {
                MessageBox.Show("Archivo Invalido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Anyfile|*";
            saveFile.ShowDialog();
            string path = saveFile.FileName;

            manejadorDeTurnos.GuardarTurnos(path);
        }

        /// <summary>
        /// Actualiza la lista de turnos del dia seleccionado
        /// </summary>
        private void ActualizarTurnos()
        {
            DateTime fechaSeleccionada = selectorFecha.Value;
            lstTurnos.DataSource = manejadorDeTurnos.ObtenerTurnosDelDia(fechaSeleccionada);
        }

        /// <summary>
        /// Elimina el turno que se encuentra seleccionado
        /// </summary>
        private void BorrarTurnoSeleccionado()
        {
            Turno turnoAtendido = (Turno)lstTurnos.SelectedItem;
            manejadorDeTurnos.EliminarTurno(turnoAtendido);
            ActualizarTurnos();
        }
    }
}
