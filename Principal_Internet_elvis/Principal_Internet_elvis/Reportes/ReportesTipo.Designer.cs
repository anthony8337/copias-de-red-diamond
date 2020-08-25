namespace Principal_Internet_elvis.Reportes
{
    partial class ReportesTipo
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
            this.cb_rango = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_mora_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_mora_desde = new System.Windows.Forms.DateTimePicker();
            this.bt_mora_buscar = new System.Windows.Forms.Button();
            this.gb_estado = new System.Windows.Forms.GroupBox();
            this.txt_estado_nombre = new System.Windows.Forms.TextBox();
            this.txt_estado_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_estado_buscar = new System.Windows.Forms.Button();
            this.cb_estado_rango = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtp_estado_hasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtp_estado_desde = new System.Windows.Forms.DateTimePicker();
            this.bt_estado_imprimir = new System.Windows.Forms.Button();
            this.gb_estado_buscar = new System.Windows.Forms.GroupBox();
            this.dgv_estado_tabla = new System.Windows.Forms.DataGridView();
            this.bt_estado_atras = new System.Windows.Forms.Button();
            this.txt_estado_buscar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_estado.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gb_estado_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_rango);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.bt_mora_buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE MORA";
            // 
            // cb_rango
            // 
            this.cb_rango.AutoSize = true;
            this.cb_rango.Location = new System.Drawing.Point(132, 93);
            this.cb_rango.Name = "cb_rango";
            this.cb_rango.Size = new System.Drawing.Size(128, 17);
            this.cb_rango.TabIndex = 3;
            this.cb_rango.Text = "RANGO DE FECHAS";
            this.cb_rango.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_mora_hasta);
            this.groupBox3.Location = new System.Drawing.Point(229, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(214, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HASTA";
            // 
            // dtp_mora_hasta
            // 
            this.dtp_mora_hasta.Location = new System.Drawing.Point(6, 19);
            this.dtp_mora_hasta.Name = "dtp_mora_hasta";
            this.dtp_mora_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_mora_hasta.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_mora_desde);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DESDE";
            // 
            // dtp_mora_desde
            // 
            this.dtp_mora_desde.Location = new System.Drawing.Point(6, 19);
            this.dtp_mora_desde.Name = "dtp_mora_desde";
            this.dtp_mora_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_mora_desde.TabIndex = 0;
            // 
            // bt_mora_buscar
            // 
            this.bt_mora_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.bt_mora_buscar.Location = new System.Drawing.Point(12, 79);
            this.bt_mora_buscar.Name = "bt_mora_buscar";
            this.bt_mora_buscar.Size = new System.Drawing.Size(103, 42);
            this.bt_mora_buscar.TabIndex = 0;
            this.bt_mora_buscar.UseVisualStyleBackColor = true;
            this.bt_mora_buscar.Click += new System.EventHandler(this.bt_mora_buscar_Click);
            // 
            // gb_estado
            // 
            this.gb_estado.Controls.Add(this.txt_estado_nombre);
            this.gb_estado.Controls.Add(this.txt_estado_codigo);
            this.gb_estado.Controls.Add(this.label2);
            this.gb_estado.Controls.Add(this.label1);
            this.gb_estado.Controls.Add(this.bt_estado_buscar);
            this.gb_estado.Controls.Add(this.cb_estado_rango);
            this.gb_estado.Controls.Add(this.groupBox5);
            this.gb_estado.Controls.Add(this.groupBox6);
            this.gb_estado.Controls.Add(this.bt_estado_imprimir);
            this.gb_estado.Location = new System.Drawing.Point(12, 147);
            this.gb_estado.Name = "gb_estado";
            this.gb_estado.Size = new System.Drawing.Size(459, 187);
            this.gb_estado.TabIndex = 1;
            this.gb_estado.TabStop = false;
            this.gb_estado.Text = "ESTADO DE CUENTA";
            // 
            // txt_estado_nombre
            // 
            this.txt_estado_nombre.Location = new System.Drawing.Point(74, 153);
            this.txt_estado_nombre.Name = "txt_estado_nombre";
            this.txt_estado_nombre.ReadOnly = true;
            this.txt_estado_nombre.Size = new System.Drawing.Size(361, 20);
            this.txt_estado_nombre.TabIndex = 8;
            // 
            // txt_estado_codigo
            // 
            this.txt_estado_codigo.Location = new System.Drawing.Point(74, 127);
            this.txt_estado_codigo.Name = "txt_estado_codigo";
            this.txt_estado_codigo.ReadOnly = true;
            this.txt_estado_codigo.Size = new System.Drawing.Size(118, 20);
            this.txt_estado_codigo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CODIGO";
            // 
            // bt_estado_buscar
            // 
            this.bt_estado_buscar.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.bt_estado_buscar.Location = new System.Drawing.Point(117, 79);
            this.bt_estado_buscar.Name = "bt_estado_buscar";
            this.bt_estado_buscar.Size = new System.Drawing.Size(103, 42);
            this.bt_estado_buscar.TabIndex = 4;
            this.bt_estado_buscar.UseVisualStyleBackColor = true;
            this.bt_estado_buscar.Click += new System.EventHandler(this.bt_estado_buscar_Click);
            // 
            // cb_estado_rango
            // 
            this.cb_estado_rango.AutoSize = true;
            this.cb_estado_rango.Location = new System.Drawing.Point(260, 93);
            this.cb_estado_rango.Name = "cb_estado_rango";
            this.cb_estado_rango.Size = new System.Drawing.Size(128, 17);
            this.cb_estado_rango.TabIndex = 3;
            this.cb_estado_rango.Text = "RANGO DE FECHAS";
            this.cb_estado_rango.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtp_estado_hasta);
            this.groupBox5.Location = new System.Drawing.Point(229, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 54);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "HASTA";
            // 
            // dtp_estado_hasta
            // 
            this.dtp_estado_hasta.Location = new System.Drawing.Point(6, 19);
            this.dtp_estado_hasta.Name = "dtp_estado_hasta";
            this.dtp_estado_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_estado_hasta.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_estado_desde);
            this.groupBox6.Location = new System.Drawing.Point(6, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(214, 54);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "DESDE";
            // 
            // dtp_estado_desde
            // 
            this.dtp_estado_desde.Location = new System.Drawing.Point(6, 19);
            this.dtp_estado_desde.Name = "dtp_estado_desde";
            this.dtp_estado_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_estado_desde.TabIndex = 0;
            // 
            // bt_estado_imprimir
            // 
            this.bt_estado_imprimir.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.bt_estado_imprimir.Location = new System.Drawing.Point(6, 79);
            this.bt_estado_imprimir.Name = "bt_estado_imprimir";
            this.bt_estado_imprimir.Size = new System.Drawing.Size(103, 42);
            this.bt_estado_imprimir.TabIndex = 0;
            this.bt_estado_imprimir.UseVisualStyleBackColor = true;
            this.bt_estado_imprimir.Click += new System.EventHandler(this.bt_estado_imprimir_Click);
            // 
            // gb_estado_buscar
            // 
            this.gb_estado_buscar.Controls.Add(this.dgv_estado_tabla);
            this.gb_estado_buscar.Controls.Add(this.bt_estado_atras);
            this.gb_estado_buscar.Controls.Add(this.txt_estado_buscar);
            this.gb_estado_buscar.Location = new System.Drawing.Point(12, 340);
            this.gb_estado_buscar.Name = "gb_estado_buscar";
            this.gb_estado_buscar.Size = new System.Drawing.Size(458, 197);
            this.gb_estado_buscar.TabIndex = 2;
            this.gb_estado_buscar.TabStop = false;
            this.gb_estado_buscar.Text = "BUSCAR CLIENTE";
            // 
            // dgv_estado_tabla
            // 
            this.dgv_estado_tabla.AllowUserToAddRows = false;
            this.dgv_estado_tabla.AllowUserToDeleteRows = false;
            this.dgv_estado_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_estado_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_estado_tabla.Location = new System.Drawing.Point(6, 45);
            this.dgv_estado_tabla.Name = "dgv_estado_tabla";
            this.dgv_estado_tabla.ReadOnly = true;
            this.dgv_estado_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_estado_tabla.Size = new System.Drawing.Size(446, 143);
            this.dgv_estado_tabla.TabIndex = 2;
            this.dgv_estado_tabla.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_estado_tabla_CellDoubleClick);
            // 
            // bt_estado_atras
            // 
            this.bt_estado_atras.Location = new System.Drawing.Point(362, 19);
            this.bt_estado_atras.Name = "bt_estado_atras";
            this.bt_estado_atras.Size = new System.Drawing.Size(90, 23);
            this.bt_estado_atras.TabIndex = 1;
            this.bt_estado_atras.Text = "ATRAS";
            this.bt_estado_atras.UseVisualStyleBackColor = true;
            this.bt_estado_atras.Click += new System.EventHandler(this.bt_estado_atras_Click);
            // 
            // txt_estado_buscar
            // 
            this.txt_estado_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_estado_buscar.Location = new System.Drawing.Point(6, 19);
            this.txt_estado_buscar.Name = "txt_estado_buscar";
            this.txt_estado_buscar.Size = new System.Drawing.Size(350, 20);
            this.txt_estado_buscar.TabIndex = 0;
            this.txt_estado_buscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_estado_buscar_KeyDown);
            // 
            // ReportesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 541);
            this.Controls.Add(this.gb_estado_buscar);
            this.Controls.Add(this.gb_estado);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportesTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesTipo";
            this.Load += new System.EventHandler(this.ReportesTipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gb_estado.ResumeLayout(false);
            this.gb_estado.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.gb_estado_buscar.ResumeLayout(false);
            this.gb_estado_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_estado_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_mora_buscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_mora_hasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_mora_desde;
        private System.Windows.Forms.CheckBox cb_rango;
        private System.Windows.Forms.GroupBox gb_estado;
        private System.Windows.Forms.CheckBox cb_estado_rango;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtp_estado_hasta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtp_estado_desde;
        private System.Windows.Forms.Button bt_estado_imprimir;
        private System.Windows.Forms.Button bt_estado_buscar;
        private System.Windows.Forms.TextBox txt_estado_nombre;
        private System.Windows.Forms.TextBox txt_estado_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_estado_buscar;
        private System.Windows.Forms.TextBox txt_estado_buscar;
        private System.Windows.Forms.Button bt_estado_atras;
        private System.Windows.Forms.DataGridView dgv_estado_tabla;
    }
}