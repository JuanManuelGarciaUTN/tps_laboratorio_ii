namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstTurnos = new System.Windows.Forms.ListBox();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnAtender = new System.Windows.Forms.Button();
            this.selectorFechaTurnos = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCambiarPrecios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarTurno = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbDatosExtendidos = new System.Windows.Forms.RichTextBox();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectorFechaHistorial = new System.Windows.Forms.Label();
            this.selectorFechaHistorial = new System.Windows.Forms.DateTimePicker();
            this.btnCambiarEstadoBGM = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(9, 14);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(762, 488);
            this.tabControl.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lstTurnos);
            this.tabPage1.Controls.Add(this.lblTurnos);
            this.tabPage1.Controls.Add(this.btnExportar);
            this.tabPage1.Controls.Add(this.lblFecha);
            this.tabPage1.Controls.Add(this.btnImportar);
            this.tabPage1.Controls.Add(this.btnAtender);
            this.tabPage1.Controls.Add(this.selectorFechaTurnos);
            this.tabPage1.Controls.Add(this.btnModificar);
            this.tabPage1.Controls.Add(this.btnCambiarPrecios);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnGenerarTurno);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(754, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Turnos Pendientes";
            // 
            // lstTurnos
            // 
            this.lstTurnos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstTurnos.FormattingEnabled = true;
            this.lstTurnos.ItemHeight = 23;
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
            this.lstTurnos.Location = new System.Drawing.Point(6, 37);
            this.lstTurnos.Name = "lstTurnos";
            this.lstTurnos.Size = new System.Drawing.Size(584, 418);
            this.lstTurnos.TabIndex = 1;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTurnos.Location = new System.Drawing.Point(6, 15);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(119, 21);
            this.lblTurnos.TabIndex = 0;
            this.lblTurnos.Text = "Turnos del Dia";
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.Location = new System.Drawing.Point(603, 415);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(140, 40);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "Exportar Datos";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(603, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(143, 21);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Selector de Fecha";
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.Location = new System.Drawing.Point(604, 361);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(140, 40);
            this.btnImportar.TabIndex = 8;
            this.btnImportar.Text = "Importar Datos";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnAtender
            // 
            this.btnAtender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtender.Location = new System.Drawing.Point(604, 91);
            this.btnAtender.Margin = new System.Windows.Forms.Padding(3, 9, 10, 9);
            this.btnAtender.Name = "btnAtender";
            this.btnAtender.Size = new System.Drawing.Size(140, 40);
            this.btnAtender.TabIndex = 3;
            this.btnAtender.Text = "Marcar Atendido";
            this.btnAtender.UseVisualStyleBackColor = true;
            this.btnAtender.Click += new System.EventHandler(this.btnAtender_Click);
            // 
            // selectorFechaTurnos
            // 
            this.selectorFechaTurnos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectorFechaTurnos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selectorFechaTurnos.Location = new System.Drawing.Point(603, 39);
            this.selectorFechaTurnos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.selectorFechaTurnos.Name = "selectorFechaTurnos";
            this.selectorFechaTurnos.Size = new System.Drawing.Size(140, 29);
            this.selectorFechaTurnos.TabIndex = 2;
            this.selectorFechaTurnos.ValueChanged += new System.EventHandler(this.selectorFecha_ValueChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(603, 145);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 40);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar Turno";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCambiarPrecios
            // 
            this.btnCambiarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarPrecios.Location = new System.Drawing.Point(604, 307);
            this.btnCambiarPrecios.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnCambiarPrecios.Name = "btnCambiarPrecios";
            this.btnCambiarPrecios.Size = new System.Drawing.Size(140, 40);
            this.btnCambiarPrecios.TabIndex = 7;
            this.btnCambiarPrecios.Text = "Cambiar Precios";
            this.btnCambiarPrecios.UseVisualStyleBackColor = true;
            this.btnCambiarPrecios.Click += new System.EventHandler(this.btnCambiarPrecios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(604, 199);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
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
            this.btnGenerarTurno.Location = new System.Drawing.Point(604, 253);
            this.btnGenerarTurno.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnGenerarTurno.Name = "btnGenerarTurno";
            this.btnGenerarTurno.Size = new System.Drawing.Size(140, 40);
            this.btnGenerarTurno.TabIndex = 6;
            this.btnGenerarTurno.Text = "Generar Turno";
            this.btnGenerarTurno.UseVisualStyleBackColor = true;
            this.btnGenerarTurno.Click += new System.EventHandler(this.btnGenerarTurno_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.rtbDatosExtendidos);
            this.tabPage2.Controls.Add(this.lstHistorial);
            this.tabPage2.Controls.Add(this.lblHistorial);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblSelectorFechaHistorial);
            this.tabPage2.Controls.Add(this.selectorFechaHistorial);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial de Atencion";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // rtbDatosExtendidos
            // 
            this.rtbDatosExtendidos.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbDatosExtendidos.Location = new System.Drawing.Point(603, 109);
            this.rtbDatosExtendidos.Name = "rtbDatosExtendidos";
            this.rtbDatosExtendidos.Size = new System.Drawing.Size(139, 344);
            this.rtbDatosExtendidos.TabIndex = 11;
            this.rtbDatosExtendidos.Text = "";
            // 
            // lstHistorial
            // 
            this.lstHistorial.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 23;
            this.lstHistorial.Items.AddRange(new object[] {
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
            this.lstHistorial.Location = new System.Drawing.Point(6, 37);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(584, 418);
            this.lstHistorial.TabIndex = 10;
            this.lstHistorial.SelectedIndexChanged += new System.EventHandler(this.lstHistorial_SelectedIndexChanged);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHistorial.Location = new System.Drawing.Point(6, 15);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(75, 21);
            this.lblHistorial.TabIndex = 4;
            this.lblHistorial.Text = "Historial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(600, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datos Extendidos";
            // 
            // lblSelectorFechaHistorial
            // 
            this.lblSelectorFechaHistorial.AutoSize = true;
            this.lblSelectorFechaHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelectorFechaHistorial.Location = new System.Drawing.Point(603, 15);
            this.lblSelectorFechaHistorial.Name = "lblSelectorFechaHistorial";
            this.lblSelectorFechaHistorial.Size = new System.Drawing.Size(143, 21);
            this.lblSelectorFechaHistorial.TabIndex = 5;
            this.lblSelectorFechaHistorial.Text = "Selector de Fecha";
            // 
            // selectorFechaHistorial
            // 
            this.selectorFechaHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectorFechaHistorial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selectorFechaHistorial.Location = new System.Drawing.Point(603, 39);
            this.selectorFechaHistorial.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.selectorFechaHistorial.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.selectorFechaHistorial.Name = "selectorFechaHistorial";
            this.selectorFechaHistorial.Size = new System.Drawing.Size(140, 29);
            this.selectorFechaHistorial.TabIndex = 7;
            this.selectorFechaHistorial.ValueChanged += new System.EventHandler(this.selectorFechaHistorial_ValueChanged);
            // 
            // btnCambiarEstadoBGM
            // 
            this.btnCambiarEstadoBGM.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarEstadoBGM.Location = new System.Drawing.Point(615, 14);
            this.btnCambiarEstadoBGM.Margin = new System.Windows.Forms.Padding(3, 5, 10, 9);
            this.btnCambiarEstadoBGM.Name = "btnCambiarEstadoBGM";
            this.btnCambiarEstadoBGM.Size = new System.Drawing.Size(140, 24);
            this.btnCambiarEstadoBGM.TabIndex = 10;
            this.btnCambiarEstadoBGM.Text = "Apagar Musica";
            this.btnCambiarEstadoBGM.UseVisualStyleBackColor = true;
            this.btnCambiarEstadoBGM.Click += new System.EventHandler(this.btnCambiarEstadoBGM_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 503);
            this.Controls.Add(this.btnCambiarEstadoBGM);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Administracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblSelectorFechaHistorial;
        private System.Windows.Forms.DateTimePicker selectorFechaHistorial;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstTurnos;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnAtender;
        private System.Windows.Forms.DateTimePicker selectorFechaTurnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCambiarPrecios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarTurno;
        private System.Windows.Forms.Button btnCambiarEstadoBGM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDatosExtendidos;
    }
}
