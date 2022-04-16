using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        //constructor
        public FormCalculadora()
        {
            InitializeComponent();
        }

        //load
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        //metodos privados

        /// <summary>
        /// Elimina todo texto en los TextBox de cada numero,
        /// el valor en lblResultado y cmbOperador vuelve a su valor por defecto
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
        }

        /// <summary>
        /// recibe dos numeros, un operando y realiza la operacion correspondiente
        /// </summary>
        /// <param name="numero1">primer numero</param>
        /// <param name="numero2">segundo numero</param>
        /// <param name="operador">operacion a realizar</param>
        /// <returns>el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            char operadorComoChar;
            char.TryParse(operador, out operadorComoChar);
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operadorComoChar);
        }

        //eventos Click

        /// <summary>
        /// Al hacer click en el boton limpia los TextBox de numeros, lblResultado y cmbOperador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Al hacer click en el boton realiza la operacion correspondiente
        /// entre txtNumero1 y txtNumero2, segun indica el operador seleccionado.
        /// Muestra el resultado en lblResultado y lo añade a la lista de resultados anteriores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            resultado = Math.Round(resultado,2);
            lblResultado.Text = resultado.ToString();
            if (cmbOperador.SelectedIndex == 0)
            {
                lstOperaciones.Items.Add($"{txtNumero1.Text} {'+'} {txtNumero2.Text} = {resultado}");
            }
            else
            {
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {resultado}");
            }
        }

        /// <summary>
        /// Intenta cerrar el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Convierte el valor de lblResultado de decimal a binario de ser posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando auxiliarDeConversion = new Operando();
            lblResultado.Text = auxiliarDeConversion.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Convierte el valor de lblResultado de binario a decimal de ser posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando auxiliarDeConversion = new Operando();
            lblResultado.Text = auxiliarDeConversion.BinarioDecimal(lblResultado.Text);
        }

        //evento Closing
        /// <summary>
        /// Al intentar cerrar el form, verifica que el usuario realmente desea cerrarlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
