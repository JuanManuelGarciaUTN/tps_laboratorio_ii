using System;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Windows;
using System.Windows.Forms;
using WMPLib;


namespace Vista
{
    public partial class Hub : Form
    {
        public delegate bool CambiarEstadoBGM();
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
            Reservador reservadorDeTurnos = new Reservador(playerSFX, CambiarEstadoDeBGM);
            this.Hide();
            reservadorDeTurnos.ShowDialog();
            this.Show();
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            playerSFX.Play();
            Login login = new Login();
            if (true || login.ShowDialog() == DialogResult.Yes)
            {
                Administracion administracionOdontologia = new Administracion(playerSFX, CambiarEstadoDeBGM);
                this.Hide();
                administracionOdontologia.ShowDialog();
                this.Show();
            }
        }

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

        private void btnBGMCambiarEstado_Click(object sender, EventArgs e)
        {
            CambiarEstadoDeBGM();
        }
    }
}
