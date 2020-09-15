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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ch_sectorb = new System.Windows.Forms.RadioButton();
            this.ch_nombreb = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ch_sector = new System.Windows.Forms.RadioButton();
            this.ch_barrio = new System.Windows.Forms.RadioButton();
            this.ch_colonia = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sector);
            this.groupBox1.Controls.Add(this.bt_barrio);
            this.groupBox1.Controls.Add(this.bt_lugar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECCIONAR";
            // 
            // bt_sector
            // 
            this.bt_sector.Location = new System.Drawing.Point(347, 19);
            this.bt_sector.Name = "bt_sector";
            this.bt_sector.Size = new System.Drawing.Size(139, 51);
            this.bt_sector.TabIndex = 3;
            this.bt_sector.Text = "SECTOR";
            this.bt_sector.UseVisualStyleBackColor = true;
            this.bt_sector.Click += new System.EventHandler(this.bt_sector_Click);
            // 
            // bt_barrio
            // 
            this.bt_barrio.Location = new System.Drawing.Point(176, 19);
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
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ch_sector);
            this.groupBox2.Controls.Add(this.ch_barrio);
            this.groupBox2.Controls.Add(this.ch_colonia);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSCAR UBICACIONES";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ch_sectorb);
            this.groupBox4.Controls.Add(this.ch_nombreb);
            this.groupBox4.Location = new System.Drawing.Point(237, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 69);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BUSCAR POR:";
            // 
            // ch_sectorb
            // 
            this.ch_sectorb.AutoSize = true;
            this.ch_sectorb.Location = new System.Drawing.Point(6, 42);
            this.ch_sectorb.Name = "ch_sectorb";
            this.ch_sectorb.Size = new System.Drawing.Size(69, 17);
            this.ch_sectorb.TabIndex = 9;
            this.ch_sectorb.TabStop = true;
            this.ch_sectorb.Text = "SECTOR";
            this.ch_sectorb.UseVisualStyleBackColor = true;
            // 
            // ch_nombreb
            // 
            this.ch_nombreb.AutoSize = true;
            this.ch_nombreb.Checked = true;
            this.ch_nombreb.Location = new System.Drawing.Point(6, 19);
            this.ch_nombreb.Name = "ch_nombreb";
            this.ch_nombreb.Size = new System.Drawing.Size(72, 17);
            this.ch_nombreb.TabIndex = 8;
            this.ch_nombreb.TabStop = true;
            this.ch_nombreb.Text = "NOMBRE";
            this.ch_nombreb.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ch_sector
            // 
            this.ch_sector.AutoSize = true;
            this.ch_sector.Location = new System.Drawing.Point(162, 18);
            this.ch_sector.Name = "ch_sector";
            this.ch_sector.Size = new System.Drawing.Size(69, 17);
            this.ch_sector.TabIndex = 5;
            this.ch_sector.TabStop = true;
            this.ch_sector.Text = "SECTOR";
            this.ch_sector.UseVisualStyleBackColor = true;
            this.ch_sector.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ch_barrio
            // 
            this.ch_barrio.AutoSize = true;
            this.ch_barrio.Location = new System.Drawing.Point(90, 18);
            this.ch_barrio.Name = "ch_barrio";
            this.ch_barrio.Size = new System.Drawing.Size(66, 17);
            this.ch_barrio.TabIndex = 4;
            this.ch_barrio.TabStop = true;
            this.ch_barrio.Text = "BARRIO";
            this.ch_barrio.UseVisualStyleBackColor = true;
            this.ch_barrio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ch_colonia
            // 
            this.ch_colonia.AutoSize = true;
            this.ch_colonia.Checked = true;
            this.ch_colonia.Location = new System.Drawing.Point(12, 18);
            this.ch_colonia.Name = "ch_colonia";
            this.ch_colonia.Size = new System.Drawing.Size(72, 17);
            this.ch_colonia.TabIndex = 3;
            this.ch_colonia.TabStop = true;
            this.ch_colonia.Text = "COLONIA";
            this.ch_colonia.UseVisualStyleBackColor = true;
            this.ch_colonia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Location = new System.Drawing.Point(237, 16);
            this.txt_buscar.MaxLength = 255;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(249, 20);
            this.txt_buscar.TabIndex = 2;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(5, 19);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(481, 162);
            this.dgv_tabla.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_tabla);
            this.groupBox3.Location = new System.Drawing.Point(12, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 191);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // UbicacionTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 413);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UbicacionTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubicacion Tipo";
            this.Load += new System.EventHandler(this.UbicacionTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.RadioButton ch_sector;
        private System.Windows.Forms.RadioButton ch_barrio;
        private System.Windows.Forms.RadioButton ch_colonia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton ch_nombreb;
        private System.Windows.Forms.RadioButton ch_sectorb;
    }
}