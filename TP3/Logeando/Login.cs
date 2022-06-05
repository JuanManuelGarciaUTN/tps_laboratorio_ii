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

namespace Logeando
{

    public partial class Login : Form
    {
        private int intentos;
        public Login()
        {
            intentos = 3;
            this.DialogResult = DialogResult.No;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Autentificador.Autentificar(txtUser.Text, txtPassword.Text))
            {
                this.DialogResult = DialogResult.Yes;
                Close();
            }
            intentos--;
            lblError.Text = $"*Valores Invalidos*{Environment.NewLine}{intentos} Intentos Restantes";
            lblError.Visible = true;
            if (intentos == 0)
            {
                Close();
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
