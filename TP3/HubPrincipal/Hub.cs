using AdministracionOdontologia;
using Logeando;
using ReservaDeTurno;
using System;
using System.Windows.Forms;

namespace HubPrincipal
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido al Centro Odontologico{Environment.NewLine}¿Qué desea realizar?";
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            Reservador reservadorDeTurnos = new Reservador();
            this.Hide();
            reservadorDeTurnos.ShowDialog();
            this.Show();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                Administracion administracionOdontologia = new Administracion();
                this.Hide();
                administracionOdontologia.ShowDialog();
                this.Show();
            }
        }
    }
}
