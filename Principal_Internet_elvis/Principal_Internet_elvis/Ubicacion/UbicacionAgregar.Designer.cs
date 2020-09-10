namespace Principal_Internet_elvis.Ubicacion
{
    partial class UbicacionAgregar
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
            this.gb_codigo = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_sec = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.gb_codigo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(12, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(113, 52);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.txt_nombre);
            this.groupBox3.Location = new System.Drawing.Point(131, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(349, 52);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NOMBRE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(253, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre.Location = new System.Drawing.Point(6, 19);
            this.txt_nombre.MaxLength = 255;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(241, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nombre_KeyDown);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 128);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(468, 172);
            this.dgv_tabla.TabIndex = 3;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // bt_agregar
            // 
            this.bt_agregar.Location = new System.Drawing.Point(12, 306);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(88, 34);
            this.bt_agregar.TabIndex = 4;
            this.bt_agregar.Text = "ACEPTAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // bt_salir
            // 
            this.bt_salir.Location = new System.Drawing.Point(200, 306);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(90, 34);
            this.bt_salir.TabIndex = 5;
            this.bt_salir.Text = "SALIR";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_sec);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELIGE EL SECTOR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "ELEGIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_sec
            // 
            this.txt_sec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_sec.Location = new System.Drawing.Point(8, 19);
            this.txt_sec.MaxLength = 255;
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.Size = new System.Drawing.Size(262, 20);
            this.txt_sec.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "BUSCAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UbicacionAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_agregar);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_codigo);
            this.Name = "UbicacionAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbicacionAgregar";
            this.Activated += new System.EventHandler(this.UbicacionAgregar_Activated);
            this.Load += new System.EventHandler(this.UbicacionAgregar_Load);
            this.gb_codigo.ResumeLayout(false);
            this.gb_codigo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_sec;
    }
}