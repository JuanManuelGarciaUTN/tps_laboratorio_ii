namespace AdministracionOdontologia
{
    partial class Administracion
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
            this.lblTurnos = new System.Windows.Forms.Label();
            this.lstTurnos = new System.Windows.Forms.ListBox();
            this.btnAtender = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarTurno = new System.Windows.Forms.Button();
            this.btnCambiarPrecios = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.selectorFecha = new System.Windows.Forms.DateTimePicker();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurnos.Location = new System.Drawing.Point(12, 9);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(119, 21);
            this.lblTurnos.TabIndex = 0;
            this.lblTurnos.Text = "Turnos del Dia";
            // 
            // lstTurnos
            // 
            this.lstTurnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTurnos.FormattingEnabled = true;
            this.lstTurnos.ItemHeight = 21;
            this.lstTurnos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.lstTurnos.Location = new System.Drawing.Point(12, 31);
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(584, 382);
            this.lstTurnos.TabIndex = 1;
            // 
            // btnAtender
            // 
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.Location = new System.Drawing.Point(609, 69);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(140, 40);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Marcar Atendido";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(609, 120);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 40);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Turno";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(609, 171);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar Turno";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarTurno
            // 
            this.btnGenerarTurno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarTurno.Location = new System.Drawing.Point(609, 222);
            this.btnGenerarTurno.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnGenerarTurno.Name = "btnGenerarTurno";
            this.btnGenerarTurno.Size = new System.Drawing.Size(140, 40);
            this.btnGenerarTurno.TabIndex = 6;
            this.btnGenerarTurno.Text = "Generar Turno";
            this.btnGenerarTurno.UseVisualStyleBackColor = true;
            this.btnGenerarTurno.Click += new System.EventHandler(this.btnGenerarTurno_Click);
            // 
            // btnCambiarPrecios
            // 
            this.btnCambiarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarPrecios.Location = new System.Drawing.Point(609, 273);
            this.btnCambiarPrecios.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnCambiarPrecios.Name = "btnCambiarPrecios";
            this.btnCambiarPrecios.Size = new System.Drawing.Size(140, 40);
            this.btnCambiarPrecios.TabIndex = 7;
            this.btnCambiarPrecios.Text = "Cambiar Precios";
            this.btnCambiarPrecios.UseVisualStyleBackColor = true;
            this.btnCambiarPrecios.Click += new System.EventHandler(this.btnCambiarPrecios_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(609, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(143, 21);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Selector de Fecha";
            // 
            // selectorFecha
            // 
            this.selectorFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selectorFecha.Location = new System.Drawing.Point(609, 33);
            this.selectorFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.selectorFecha.Name = "selectorFecha";
            this.selectorFecha.Size = new System.Drawing.Size(140, 29);
            this.selectorFecha.TabIndex = 2;
            this.selectorFecha.ValueChanged += new System.EventHandler(this.selectorFecha_ValueChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.Location = new System.Drawing.Point(609, 324);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(140, 40);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Importar Turnos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.Location = new System.Drawing.Point(609, 375);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 11, 10, 0);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 40);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar Turnos";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.selectorFecha);
            this.Controls.Add(this.btnCambiarPrecios);
            this.Controls.Add(this.btnGenerarTurno);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAtender);
            this.Controls.Add(this.lstTurnos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.ListBox lstTurnos;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarTurno;
        private System.Windows.Forms.Button btnCambiarPrecios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker selectorFecha;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
    }
}
