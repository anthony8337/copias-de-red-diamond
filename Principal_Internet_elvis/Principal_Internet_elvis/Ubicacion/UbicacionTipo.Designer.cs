namespace Principal_Internet_elvis.Ubicacion
{
    partial class UbicacionTipo
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
            this.bt_sector = new System.Windows.Forms.Button();
            this.bt_barrio = new System.Windows.Forms.Button();
            this.bt_lugar = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.bt_sector);
            this.groupBox1.Controls.Add(this.bt_barrio);
            this.groupBox1.Controls.Add(this.bt_lugar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO";
            // 
            // bt_sector
            // 
            this.bt_sector.Location = new System.Drawing.Point(296, 19);
            this.bt_sector.Name = "bt_sector";
            this.bt_sector.Size = new System.Drawing.Size(139, 51);
            this.bt_sector.TabIndex = 3;
            this.bt_sector.Text = "SECTOR";
            this.bt_sector.UseVisualStyleBackColor = true;
            this.bt_sector.Click += new System.EventHandler(this.bt_sector_Click);
            // 
            // bt_barrio
            // 
            this.bt_barrio.Location = new System.Drawing.Point(151, 19);
            this.bt_barrio.Name = "bt_barrio";
            this.bt_barrio.Size = new System.Drawing.Size(139, 51);
            this.bt_barrio.TabIndex = 2;
            this.bt_barrio.Text = "BARRIO";
            this.bt_barrio.UseVisualStyleBackColor = true;
            this.bt_barrio.Click += new System.EventHandler(this.bt_barrio_Click);
            // 
            // bt_lugar
            // 
            this.bt_lugar.Location = new System.Drawing.Point(6, 19);
            this.bt_lugar.Name = "bt_lugar";
            this.bt_lugar.Size = new System.Drawing.Size(139, 51);
            this.bt_lugar.TabIndex = 1;
            this.bt_lugar.Text = "LUGAR";
            this.bt_lugar.UseVisualStyleBackColor = true;
            this.bt_lugar.Click += new System.EventHandler(this.bt_lugar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR UBICACIONES";
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(6, 19);
            this.txt_buscar.MaxLength = 255;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(186, 20);
            this.txt_buscar.TabIndex = 2;
            this.txt_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyDown);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 150);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(435, 150);
            this.dgv_tabla.TabIndex = 2;
            // 
            // UbicacionTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 317);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UbicacionTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion Tipo";
            this.Load += new System.EventHandler(this.UbicacionTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_lugar;
        private System.Windows.Forms.Button bt_sector;
        private System.Windows.Forms.Button bt_barrio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dgv_tabla;
    }
}