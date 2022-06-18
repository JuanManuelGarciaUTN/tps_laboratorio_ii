using System;
using System.Media;
using System.Windows.Forms;
using WMPLib;


namespace Vista
{
    /// <summary>
    /// Parte del proyecto que contiene los temas:
    /// Tema 18 - Delegados y expresion Lambda
    /// </summary>
    public partial class Hub : Form
    {
        //delegado que puede ser asociado al metodo que detiene la musica de fondo (BGM)
        public delegate bool CambiarEstadoBGM();

        //atributos
        private SoundPlayer playerSFX;
        private WindowsMediaPlayer playerBGM;
        private bool estaSonandoBGM;

        public Hub()
        {
            playerSFX = new SoundPlayer("./archivos/PopSFX.wav");
            playerBGM = new WindowsMediaPlayer();
            InitializeComponent();
        }

        private void Hub_Load(object sender, EventArgs e)
        {
            playerBGM.URL = "./archivos/GateOfSteiner.wav";
            playerBGM.settings.setMode("loop", true);
            CambiarEstadoDeBGM();
            lblBienvenida.Text = $"Bienvenido al Centro Odontologico{Environment.NewLine}¿Qué desea realizar?";
            playerSFX.Load();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            //al generar una instancia de reservadorDeTurnos recibe una referencia al metodo CambiarEstadoBGM
            //para asi poder detener la musica de fondo desde otro form y a su vez modificar el mensaje del boton
            //Apagar Musica / Enceder Musica segun corresponda
            Reservador reservadorDeTurnos = new Reservador(playerSFX, CambiarEstadoDeBGM);
            this.Hide();
            reservadorDeTurnos.ShowDialog();
            this.Show();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.Yes)
            {
                //al generar una instancia de administracionOdontologia recibe una referencia al metodo CambiarEstadoBGM
                //para asi poder detener la musica de fondo desde otro form y a su vez modificar el mensaje del boton
                //Apagar Musica / Enceder Musica segun corresponda
                Administracion administracionOdontologia = new Administracion(playerSFX, CambiarEstadoDeBGM);
                this.Hide();
                administracionOdontologia.ShowDialog();
                this.Show();
            }
        }
        private void btnBGMCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeBGM();
        }

        /// <summary>
        /// Cambia el estado de la musica de fondo,
        /// si esta sonando la detiene
        /// si esta detenida continua desde donde se detuvo la ultima vez
        /// y modifica el Text del boton asociado al metodo
        /// </summary>
        /// <returns></returns>
        private bool CambiarEstadoDeBGM()
        {
            if (estaSonandoBGM)
            {
                estaSonandoBGM = false;
                btnBGMCambiarEstado.Text = "♪ Encender Musica ♪";
                playerBGM.controls.pause();
            }
            else
            {
                estaSonandoBGM = true;
                btnBGMCambiarEstado.Text = "♪ Apagar Musica ♪";
                playerBGM.controls.play();
            }

            return estaSonandoBGM;
        }
    }
}
