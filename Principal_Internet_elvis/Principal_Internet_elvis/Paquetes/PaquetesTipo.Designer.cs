namespace Principal_Internet_elvis.Paquetes
{
    partial class PaquetesTipo
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
            this.bt_servicio = new System.Windows.Forms.Button();
            this.bt_paquete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_servicio);
            this.groupBox1.Controls.Add(this.bt_paquete);
            this.groupBox1.Location = new System.Drawing.Point(198, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // bt_servicio
            // 
            this.bt_servicio.Location = new System.Drawing.Point(120, 19);
            this.bt_servicio.Name = "bt_servicio";
            this.bt_servicio.Size = new System.Drawing.Size(105, 63);
            this.bt_servicio.TabIndex = 1;
            this.bt_servicio.Text = "SERVICIO";
            this.bt_servicio.UseVisualStyleBackColor = true;
            this.bt_servicio.Click += new System.EventHandler(this.bt_servicio_Click);
            // 
            // bt_paquete
            // 
            this.bt_paquete.Location = new System.Drawing.Point(6, 19);
            this.bt_paquete.Name = "bt_paquete";
            this.bt_paquete.Size = new System.Drawing.Size(105, 63);
            this.bt_paquete.TabIndex = 0;
            this.bt_paquete.Text = "PAQUETE";
            this.bt_paquete.UseVisualStyleBackColor = true;
            this.bt_paquete.Click += new System.EventHandler(this.bt_paquete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR PAQUETES";
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(6, 19);
            this.txt_buscar.MaxLength = 255;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(168, 20);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 112);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(417, 202);
            this.dgv_tabla.TabIndex = 4;
            // 
            // PaquetesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 326);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaquetesTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaquetesTipo";
            this.Load += new System.EventHandler(this.PaquetesTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_paquete;
        private System.Windows.Forms.Button bt_servicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}