namespace Principal_Internet_elvis
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_server = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.fd_fuente = new System.Windows.Forms.FontDialog();
            this.gb_servidor = new System.Windows.Forms.GroupBox();
            this.gb_opciones = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gb_servidor.SuspendLayout();
            this.gb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(6, 19);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(226, 31);
            this.txt_server.TabIndex = 0;
            this.txt_server.Text = ".";
            this.txt_server.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(6, 56);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 33);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(265, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(45, 45);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fd_fuente
            // 
            this.fd_fuente.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // gb_servidor
            // 
            this.gb_servidor.Controls.Add(this.txt_server);
            this.gb_servidor.Controls.Add(this.btnAceptar);
            this.gb_servidor.Location = new System.Drawing.Point(6, 81);
            this.gb_servidor.Name = "gb_servidor";
            this.gb_servidor.Size = new System.Drawing.Size(235, 95);
            this.gb_servidor.TabIndex = 5;
            this.gb_servidor.TabStop = false;
            this.gb_servidor.Text = "SERVIDOR";
            // 
            // gb_opciones
            // 
            this.gb_opciones.Controls.Add(this.button2);
            this.gb_opciones.Controls.Add(this.gb_servidor);
            this.gb_opciones.Location = new System.Drawing.Point(12, 12);
            this.gb_opciones.Name = "gb_opciones";
            this.gb_opciones.Size = new System.Drawing.Size(247, 185);
            this.gb_opciones.TabIndex = 6;
            this.gb_opciones.TabStop = false;
            this.gb_opciones.Text = "BASE DE DATOS Y CONEXION";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "BASE DE DATOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 197);
            this.ControlBox = false;
            this.Controls.Add(this.gb_opciones);
            this.Controls.Add(this.btnSalir);
            this.HelpButton = true;
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.gb_servidor.ResumeLayout(false);
            this.gb_servidor.PerformLayout();
            this.gb_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.FontDialog fd_fuente;
        private System.Windows.Forms.GroupBox gb_servidor;
        private System.Windows.Forms.GroupBox gb_opciones;
        private System.Windows.Forms.Button button2;
    }
}