namespace Principal_Internet_elvis.FormmGenerales
{
    partial class Opciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_modificar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_modificar);
            this.groupBox1.Controls.Add(this.bt_agregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 102);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obciones";
            // 
            // bt_modificar
            // 
            this.bt_modificar.BackColor = System.Drawing.Color.White;
            this.bt_modificar.ForeColor = System.Drawing.Color.Black;
            this.bt_modificar.Image = global::Principal_Internet_elvis.Properties.Resources.lapiz;
            this.bt_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_modificar.Location = new System.Drawing.Point(198, 18);
            this.bt_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_modificar.Name = "bt_modificar";
            this.bt_modificar.Size = new System.Drawing.Size(189, 71);
            this.bt_modificar.TabIndex = 19;
            this.bt_modificar.Text = "MODIFICAR";
            this.bt_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_modificar.UseVisualStyleBackColor = false;
            this.bt_modificar.Click += new System.EventHandler(this.bt_modificar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.Color.White;
            this.bt_agregar.ForeColor = System.Drawing.Color.Black;
            this.bt_agregar.Image = global::Principal_Internet_elvis.Properties.Resources.mas;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_agregar.Location = new System.Drawing.Point(5, 18);
            this.bt_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(189, 71);
            this.bt_agregar.TabIndex = 16;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.BackColor = System.Drawing.Color.White;
            this.bt_salir.ForeColor = System.Drawing.Color.Black;
            this.bt_salir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(11, 119);
            this.bt_salir.Margin = new System.Windows.Forms.Padding(2);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(133, 71);
            this.bt_salir.TabIndex = 20;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = false;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 203);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Opciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_modificar;
        private System.Windows.Forms.Button bt_salir;
    }
}