namespace Vista
{
    partial class Reservador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservador));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.selectorFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstTipos = new System.Windows.Forms.ListBox();
            this.lblTipos = new System.Windows.Forms.Label();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lstHorarios = new System.Windows.Forms.ListBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBGMCambiarEstado = new System.Windows.Forms.Button();
            this.lblFaltanDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 27);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 3, 20, 20);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese su Nombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(12, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 15);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(12, 88);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese su Apellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(12, 131);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 149);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.txtDni.MaxLength = 9;
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese su DNI";
            this.txtDni.Size = new System.Drawing.Size(150, 23);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(12, 192);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(56, 15);
            this.lblTelefono.TabIndex = 0;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(12, 210);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Telefono de Contacto";
            this.txtTelefono.Size = new System.Drawing.Size(150, 23);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // selectorFecha
            // 
            this.selectorFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.selectorFecha.Location = new System.Drawing.Point(12, 271);
            this.selectorFecha.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.selectorFecha.MinDate = new System.DateTime(2021, 12, 12, 0, 0, 0, 0);
            this.selectorFecha.Name = "selectorFecha";
            this.selectorFecha.Size = new System.Drawing.Size(150, 23);
            this.selectorFecha.TabIndex = 5;
            this.selectorFecha.ValueChanged += new System.EventHandler(this.selectorFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(12, 253);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha del Turno";
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
            this.lstTipos.Location = new System.Drawing.Point(12, 332);
            this.lstTipos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.lstTipos.Name = "lstTipos";
            this.lstTipos.Size = new System.Drawing.Size(150, 88);
            this.lstTipos.TabIndex = 6;
            // 
            // lblTipos
            // 
            this.lblTipos.AutoSize = true;
            this.lblTipos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipos.Location = new System.Drawing.Point(12, 314);
            this.lblTipos.Name = "lblTipos";
            this.lblTipos.Size = new System.Drawing.Size(98, 15);
            this.lblTipos.TabIndex = 0;
            this.lblTipos.Text = "Tipo de Consulta";
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorarios.Location = new System.Drawing.Point(185, 9);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(110, 15);
            this.lblHorarios.TabIndex = 0;
            this.lblHorarios.Text = "Turnos Disponibles";
            // 
            // lstHorarios
            // 
            this.lstHorarios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHorarios.FormattingEnabled = true;
            this.lstHorarios.ItemHeight = 17;
            this.lstHorarios.Items.AddRange(new object[] {
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
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.lstHorarios.Location = new System.Drawing.Point(185, 27);
            this.lstHorarios.Name = "lstHorarios";
            this.lstHorarios.Size = new System.Drawing.Size(150, 395);
            this.lstHorarios.TabIndex = 7;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmar.Location = new System.Drawing.Point(12, 462);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 39);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar Turno";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBGMCambiarEstado
            // 
            this.btnBGMCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBGMCambiarEstado.Location = new System.Drawing.Point(185, 462);
            this.btnBGMCambiarEstado.Name = "btnBGMCambiarEstado";
            this.btnBGMCambiarEstado.Size = new System.Drawing.Size(150, 39);
            this.btnBGMCambiarEstado.TabIndex = 9;
            this.btnBGMCambiarEstado.Text = "Apagar Musica";
            this.btnBGMCambiarEstado.UseVisualStyleBackColor = true;
            this.btnBGMCambiarEstado.Click += new System.EventHandler(this.btnBGMCambiarEstado_Click);
            // 
            // lblFaltanDatos
            // 
            this.lblFaltanDatos.AutoSize = true;
            this.lblFaltanDatos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFaltanDatos.ForeColor = System.Drawing.Color.Crimson;
            this.lblFaltanDatos.Location = new System.Drawing.Point(12, 421);
            this.lblFaltanDatos.MinimumSize = new System.Drawing.Size(334, 38);
            this.lblFaltanDatos.Name = "lblFaltanDatos";
            this.lblFaltanDatos.Size = new System.Drawing.Size(334, 38);
            this.lblFaltanDatos.TabIndex = 0;
            this.lblFaltanDatos.Text = "Falta Ingresar Nombre, Apellido, Tipo de Consulta,\r\ny Horario";
            this.lblFaltanDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFaltanDatos.Visible = false;
            // 
            // Reservador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 515);
            this.Controls.Add(this.btnBGMCambiarEstado);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lstHorarios);
            this.Controls.Add(this.lstTipos);
            this.Controls.Add(this.selectorFecha);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.lblFaltanDatos);
            this.Controls.Add(this.lblTipos);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reservador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar un Turno - Odontología";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reservador_FormClosing);
            this.Load += new System.EventHandler(this.turnos_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.turnos_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker selectorFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ListBox lstTipos;
        private System.Windows.Forms.Label lblTipos;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.ListBox lstHorarios;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBGMCambiarEstado;
        private System.Windows.Forms.Label lblFaltanDatos;
    }
}
