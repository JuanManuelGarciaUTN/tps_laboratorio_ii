using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace ReservaDeTurno
{
    public partial class Reservador : Form
    {
        private ManejadorDeTurnos manejadorDeTurnos;
        private bool seModifico;
        private Turno turnoAModificar;
        public Reservador()
        {
            InitializeComponent();
            manejadorDeTurnos = new ManejadorDeTurnos("./archivos/turnos", "./archivos/precios");
        }

        public Reservador(ManejadorDeTurnos manejadorDeTurnos, Turno turno)
        {
            InitializeComponent();
            this.manejadorDeTurnos = manejadorDeTurnos;
            this.txtNombre.Text = turno.Nombre;
            this.txtApellido.Text = turno.Apellido;
            this.txtDni.Text = turno.DniPaciente.ToString();
            this.txtTelefono.Text = turno.Telefono;
            this.selectorFecha.Value = turno.Fecha;

            seModifico = false;
            turnoAModificar = turno;
        }

        private void turnos_Load(object sender, EventArgs e)
        {
            if(turnoAModificar is not null)
            {
                //elimina el turno a modificar, para asi liberar el horario del mismo
                manejadorDeTurnos.EliminarTurno(turnoAModificar);
            }
            selectorFecha.MinDate = DateTime.Now;
            selectorFecha.MaxDate = DateTime.Now.AddYears(1);
            lstTipos.DataSource = Turno.ObtenerTipos();
            ActualizarTurnosDisponibles();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(VerificarInputsVacios())
            {
                lblFaltanDatos.Visible = true;
            }
            else
            {
                //obtengo los datos del turno
                int dni;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string telefono = txtTelefono.Text;
                Turno.TipoConsulta tipo = (Turno.TipoConsulta)lstTipos.SelectedItem;
                float precio = manejadorDeTurnos.Precios[(int)tipo];
                DateTime fecha = (DateTime)lstHorarios.SelectedItem;
                int.TryParse(txtDni.Text, out dni);
  
                try
                {
                    //genero un nuevo turno con los datos
                    Turno turno = new Turno(fecha, precio, tipo, dni, telefono, nombre, apellido);
                    
                    //pregunto al usuario que confirme el nuevo turno
                    if (MessageBox.Show($"Desea confimar el turno\n{turno.Mostrar()}", "Confirmar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        if (turnoAModificar is not null)
                        {
                            //si es una modificacion de turno
                            seModifico = true;
                            manejadorDeTurnos.ModificarTurno(turnoAModificar, turno);
                            MessageBox.Show("Se modifico el turno correctamente", "Modificacion", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        { 
                            //si es un nuevo turno
                            MessageBox.Show("Se reservo un nuevo turno correctamente", "Reserva Completa", MessageBoxButtons.OK);
                            manejadorDeTurnos.AgregarTurno(turno);
                            ActualizarTurnosDisponibles();
                        }
                    }
                }
                catch (DatosInvalidosException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void turnos_MouseMove(object sender, MouseEventArgs e)
        {
            lblFaltanDatos.Visible = false;
        }

        private void selectorFecha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarTurnosDisponibles();
        }

        private void Reservador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (turnoAModificar is not null && seModifico == false)
            {
                //si cancelaron la modificacion del turno, lo vuelve a agregar
                //sin modificaciones
                manejadorDeTurnos.AgregarTurno(turnoAModificar);
            }
            manejadorDeTurnos.GuardarTurnos();
        }

        /// <summary>
        /// Actualiza la lista de turnos disponibles
        /// Si la misma esta vacia, muestra el mensaje "Fecha Sin Turnos"
        /// </summary>
        private void ActualizarTurnosDisponibles()
        {
            DateTime fechaSeleccionada = selectorFecha.Value;
            lstHorarios.DataSource = manejadorDeTurnos.ObtenerHorariosDisponibles(fechaSeleccionada);

            if (lstHorarios.Items.Count == 0)
            {
                lstHorarios.Enabled = false;
                lstHorarios.DataSource = null;
                lstHorarios.Items.Add("Fecha Sin Turnos");
            }
            else
            {
                lstHorarios.Enabled = true;
            }
        }

        /// <summary>
        /// Verifica que si los inputs se encuentran vacios
        /// </summary>
        /// <returns>True si al menos un input esta vacio - si no False</returns>
        private bool VerificarInputsVacios()
        {
            bool inputVacios = string.IsNullOrEmpty(txtNombre.Text)
                                || string.IsNullOrEmpty(txtApellido.Text)
                                || string.IsNullOrEmpty(txtDni.Text)
                                || string.IsNullOrEmpty(txtTelefono.Text)
                                || lstHorarios.SelectedItem is null
                                || lstTipos.SelectedItem is null;

            return inputVacios;
        }
    }
}
