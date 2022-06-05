using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecios
{
    public partial class PreciosModificar : Form
    {
        private ListBox lstTipos;
        private Label lblTipos;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Button btnModificar;

        public PreciosModificar()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTipos
            // 
            this.lstTipos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTipos.FormattingEnabled = true;
            this.lstTipos.ItemHeight = 21;
            this.lstTipos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.lstTipos.Location = new System.Drawing.Point(12, 27);
            this.lstTipos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(150, 88);
            this.lstTipos.TabIndex = 8;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipos.Location = new System.Drawing.Point(12, 9);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(98, 15);
            this.lblTipos.TabIndex = 7;
            this.lblTipos.Text = "Tipo de Consulta";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(12, 135);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(11, 153);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(12, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 34);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // PreciosModificar
            // 
            this.ClientSize = new System.Drawing.Size(173, 226);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTipos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreciosModificar";
            this.Text = "Modificar Precios";
            this.Load += new System.EventHandler(this.PreciosModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PreciosModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
