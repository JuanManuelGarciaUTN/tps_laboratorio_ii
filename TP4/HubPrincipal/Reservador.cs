using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Reservador : Form
    {
        private ManejadorDeTurnos manejadorDeTurnos;
        private bool seModifico;
        private Turno? turnoAModificar;
        private SoundPlayer playerSFX;
        private Hub.CambiarEstadoBGM delegadoBGM;

        public Reservador(SoundPlayer playerSFX, Hub.CambiarEstadoBGM delegadoBGM)
            : this(new ManejadorDeTurnos("./archivos/precios"), null, playerSFX, delegadoBGM)
        {
        }

        public Reservador(ManejadorDeTurnos manejadorDeTurnos, Turno? turnoAModificar, SoundPlayer playerSFX, Hub.CambiarEstadoBGM delegadoBGM)
        {
            InitializeComponent();
            //asigno los controles de sonido y musica de fondo
            this.playerSFX = playerSFX;
            this.delegadoBGM = delegadoBGM;

            //asigno los controles de turno
            this.manejadorDeTurnos = manejadorDeTurnos;

            //si se esta modificando un turno, pre-asigno los datos del turno al form
            if (turnoAModificar is not null)
            {
                this.txtNombre.Text = turnoAModificar.Nombre;
                this.txtApellido.Text = turnoAModificar.Apellido;
                this.txtDni.Text = turnoAModificar.DniPaciente.ToString();
                this.txtTelefono.Text = turnoAModificar.Telefono;
                this.selectorFecha.Value = turnoAModificar.Fecha;
                manejadorDeTurnos.EliminarTurno(turnoAModificar);
                seModifico = false;
                this.turnoAModificar = turnoAModificar;
            }
        }

        private void turnos_Load(object sender, EventArgs e)
        {
            DeterminarEstadoInicialBGM();
            selectorFecha.MinDate = DateTime.Now;
            selectorFecha.MaxDate = DateTime.Now.AddYears(1);
            lstTipos.DataSource = Turno.ObtenerTipos();
            ActualizarTurnosDisponibles();

            if (turnoAModificar is not null)
            {
                this.lstTipos.SelectedItem = turnoAModificar.Tipo;
                this.lstHorarios.SelectedItem = turnoAModificar.Fecha;
                //elimina el turno a modificar, para asi liberar el horario del mismo
            }
        }

        private void btnBGMCambiarEstado_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            AsignarEstadoActualBGM();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            if (AsignarMensajeInputsVacios())
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string caracteresValidos = "1234567890";
            //solo permite ingresar numeros en el textBox
            EliminarCaracteresInvalidosDeTextBox(txtDni, caracteresValidos);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string caracteresValidos = "1234567890";
            //solo permite ingresar numeros en el textBox
            EliminarCaracteresInvalidosDeTextBox(txtTelefono, caracteresValidos);
        }
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            string caracteresValidos = "qwertyuiopasdfghjklñzxcvbnm áéíóúü";
            //solo permite ingresar letras y espacio. Acepta mayusculas y minusculas
            EliminarCaracteresInvalidosDeTextBox(txtApellido, caracteresValidos);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            string caracteresValidos = "qwertyuiopasdfghjklñzxcvbnm áéíóúü";
            //solo permite ingresar letras y espacio. Acepta mayusculas y minusculas
            EliminarCaracteresInvalidosDeTextBox(txtNombre, caracteresValidos);
        }
        private void Reservador_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (turnoAModificar is not null && seModifico == false)
            {
                //si cancelaron la modificacion del turno, lo vuelve a agregar sin modificaciones
                manejadorDeTurnos.AgregarTurno(turnoAModificar);
            }
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
        /// Asigna el mensaje de inputs invacios a lblFaltanDatos,
        /// para que indique que inputs se encuentran vacios
        /// </summary>
        /// <returns>True si al menos un input esta vacio - si no False</returns>
        private bool AsignarMensajeInputsVacios()
        {
            StringBuilder mensajeFaltanDatos = new StringBuilder();
            List<string> inputsVacios = ObtenerInputsVacios();

            mensajeFaltanDatos.Append("Falta Ingresar ");

            for (int i = 0; i < inputsVacios.Count;)
            {
                mensajeFaltanDatos.Append(inputsVacios[i]);
                i++;
                if (i < inputsVacios.Count)
                {
                    if (i == inputsVacios.Count - 1)
                    {
                        if (i == 3)
                        {
                            mensajeFaltanDatos.Append(Environment.NewLine);
                        }
                        mensajeFaltanDatos.Append(" y ");
                    }
                    else
                    {
                        mensajeFaltanDatos.Append(", ");
                        if (i == 3)
                        {
                            mensajeFaltanDatos.Append(Environment.NewLine);
                        }
                    }
                }
            }
            lblFaltanDatos.Text = mensajeFaltanDatos.ToString();

            return inputsVacios.Count > 0;
        }

        /// <summary>
        /// Recibe un textoBox y un string con caracteres validos
        /// Elimina todos los caracteres invalidos del textBox
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="caracteresValidos"></param>
        private void EliminarCaracteresInvalidosDeTextBox(TextBox textBox, string caracteresValidos)
        {
            StringBuilder stringCorrecto = new StringBuilder();
            string caracteresValidosMayuscula = caracteresValidos.ToUpper();
            foreach (char letra in textBox.Text)
            {
                if (caracteresValidos.Contains(letra) || caracteresValidosMayuscula.Contains(letra))
                {
                    stringCorrecto.Append(letra);
                }
            }

            textBox.Text = stringCorrecto.ToString();
            textBox.SelectionStart = textBox.Text.Length;
            textBox.SelectionLength = 0;
        }

        /// <summary>
        /// Obtiene una lista de strings con todos los inputs acltualmente vacios
        /// </summary>
        /// <returns></returns>
        private List<string> ObtenerInputsVacios()
        {
            List<string> inputsVacios = new List<string>();
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                inputsVacios.Add("Nombre");
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                inputsVacios.Add("Apellido");
            }
            if (string.IsNullOrEmpty(txtDni.Text))
            {
                inputsVacios.Add("DNI");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                inputsVacios.Add("Telefono");
            }
            if (lstHorarios.SelectedItem is null)
            {
                inputsVacios.Add("Horario");
            }
            if (lstTipos.SelectedItem is null)
            {
                inputsVacios.Add("Tipo de Consulta");
            }

            return inputsVacios;
        }

        /// <summary>
        /// Invoca al metodo asociado al delegado de BGM
        /// y modifica el texto del boton asociado al estado de la BGM segun corresponda
        /// </summary>
        private void AsignarEstadoActualBGM()
        {
            if (delegadoBGM.Invoke())
            {
                btnBGMCambiarEstado.Text = "Apagar Musica";
            }
            else
            {
                btnBGMCambiarEstado.Text = "Encender Musica";
            }
        }

        /// <summary>
        /// Determina si la musica esta sonando o no 
        /// y asigna el estado correspondiente al boton asociado a la musica de fondo
        /// </summary>
        private void DeterminarEstadoInicialBGM()
        {
            delegadoBGM.Invoke();
            AsignarEstadoActualBGM();
        }
    }
}
