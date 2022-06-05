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

namespace ModificarPrecios
{
    public partial class ModificadorDePrecios : Form
    {
        private ManejadorDeTurnos manejadorDeTurnos;

        public ModificadorDePrecios()
        {
            InitializeComponent();
        }
        public ModificadorDePrecios(ManejadorDeTurnos manejadorDeTurnos)
        {
            InitializeComponent();
            this.manejadorDeTurnos = manejadorDeTurnos;
        }

        private void ModificadorDePrecios_Load(object sender, EventArgs e)
        {
            lstTipos.DataSource = Turno.ObtenerTipos();
            ActualizarPrecio();
        }

        private void lstTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int precioSeleccionado = (int)lstTipos.SelectedItem;
                manejadorDeTurnos.ModificarPrecio(precioSeleccionado, txtPrecio.Text);
                lblActulizado.Visible = true;
            }
            catch (DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
            }
            finally
            { 
                ActualizarPrecio();
            }
        }

        private void ModificadorDePrecios_FormClosing(object sender, FormClosingEventArgs e)
        {
            manejadorDeTurnos.GuardarPrecios();
        }

        private void ModificadorDePrecios_MouseMove(object sender, MouseEventArgs e)
        {
            lblActulizado.Visible = false;
        }

        /// <summary>
        /// Cambia el valor de txtPrecio para que sea el mismo que el del precio seleccionado
        /// </summary>
        private void ActualizarPrecio()
        {
            int precioSeleccionado = (int)lstTipos.SelectedItem;
            txtPrecio.Text = manejadorDeTurnos.Precios[precioSeleccionado].ToString();
        }
    }
}
