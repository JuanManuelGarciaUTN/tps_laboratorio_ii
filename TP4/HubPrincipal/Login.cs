using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace Vista
{

    public partial class Login : Form
    {
        private SoundPlayer playerSi;
        private SoundPlayer playerNo;
        private int intentos;
        public Login()
        {
            intentos = 3;
            this.DialogResult = DialogResult.No;
            playerSi = new SoundPlayer("./archivos/siSFX.wav");
            playerSi.Load();
            playerNo = new SoundPlayer("./archivos/noSFX.wav");
            playerNo.Load();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Autentificador.Autentificar(txtUser.Text, txtPassword.Text))
            {
                playerSi.Play();
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                playerNo.Play();
                intentos--;
                lblError.Text = $"*Valores Invalidos*{Environment.NewLine}{intentos} Intentos Restantes";
                lblError.Visible = true;
                if (intentos == 0)
                {
                    Close();
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
