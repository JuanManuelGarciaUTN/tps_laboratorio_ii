namespace ModificarPrecios
{
    partial class ModificadorDePrecios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTipos = new System.Windows.Forms.Label();
            this.lblActulizado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(11, 201);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(150, 34);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(11, 154);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(150, 23);
            this.txtPrecio.TabIndex = 14;
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
            this.lstTipos.Location = new System.Drawing.Point(12, 28);
            this.lstTipos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(150, 88);
            this.lstTipos.TabIndex = 13;
            this.lstTipos.SelectedIndexChanged += new System.EventHandler(this.lstTipos_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(12, 136);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(42, 15);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipos.Location = new System.Drawing.Point(12, 10);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(98, 15);
            this.lblTipos.TabIndex = 12;
            this.lblTipos.Text = "Tipo de Consulta";
            // 
            // lblActulizado
            // 
            this.lblActulizado.AutoSize = true;
            this.lblActulizado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActulizado.ForeColor = System.Drawing.Color.Green;
            this.lblActulizado.Location = new System.Drawing.Point(21, 180);
            this.lblActulizado.Name = "lblActulizado";
            this.lblActulizado.Size = new System.Drawing.Size(131, 15);
            this.lblActulizado.TabIndex = 11;
            this.lblActulizado.Text = "*Se Actualizo el Precio";
            this.lblActulizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblActulizado.Visible = false;
            // 
            // ModificadorDePrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 247);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.lblActulizado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificadorDePrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Precios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificadorDePrecios_FormClosing);
            this.Load += new System.EventHandler(this.ModificadorDePrecios_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModificadorDePrecios_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label lblActulizado;
    }
}
