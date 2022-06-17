namespace Vista
{
    partial class Hub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hub));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnBGMCambiarEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location = new System.Drawing.Point(12, 33);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(287, 42);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenidos al Centro Odontologico\r\n¿Qué Desea Realizar?";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTurno
            // 
            this.btnTurno.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTurno.Location = new System.Drawing.Point(12, 111);
            this.btnTurno.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(287, 41);
            this.btnTurno.TabIndex = 1;
            this.btnTurno.Text = "Sacar un Turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdministracion.Location = new System.Drawing.Point(12, 165);
            this.btnAdministracion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(287, 41);
            this.btnAdministracion.TabIndex = 2;
            this.btnAdministracion.Text = "Administracion";
            this.btnAdministracion.UseVisualStyleBackColor = true;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnBGMCambiarEstado
            // 
            this.btnBGMCambiarEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBGMCambiarEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBGMCambiarEstado.Location = new System.Drawing.Point(12, 219);
            this.btnBGMCambiarEstado.Name = "btnBGMCambiarEstado";
            this.btnBGMCambiarEstado.Size = new System.Drawing.Size(287, 41);
            this.btnBGMCambiarEstado.TabIndex = 3;
            this.btnBGMCambiarEstado.Text = "♪ Apagar Musica ♪";
            this.btnBGMCambiarEstado.UseVisualStyleBackColor = true;
            this.btnBGMCambiarEstado.Click += new System.EventHandler(this.btnBGMCambiarEstado_Click);
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 432);
            this.Controls.Add(this.btnBGMCambiarEstado);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atencion Odontologia";
            this.Load += new System.EventHandler(this.Hub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnBGMCambiarEstado;
    }
}
