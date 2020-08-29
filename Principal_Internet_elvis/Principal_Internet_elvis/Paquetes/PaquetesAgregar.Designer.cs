namespace Principal_Internet_elvis.Paquetes
{
    partial class PaquetesAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaquetesAgregar));
            this.gb_codigo = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_p_servicio = new System.Windows.Forms.TextBox();
            this.gb_c1 = new System.Windows.Forms.GroupBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_pre_s_servicio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_s_servicio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_pre_p_servicio = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_nuevo_presio = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gb_codigo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_c1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(510, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(113, 51);
            this.gb_codigo.TabIndex = 0;
            this.gb_codigo.TabStop = false;
            this.gb_codigo.Text = "CODIGO";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(6, 19);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(101, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txt_p_servicio);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRIMER SERVICIO";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(42, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "BUSCAR SERVICIO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_p_servicio
            // 
            this.txt_p_servicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_p_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_p_servicio.MaxLength = 255;
            this.txt_p_servicio.Name = "txt_p_servicio";
            this.txt_p_servicio.Size = new System.Drawing.Size(231, 20);
            this.txt_p_servicio.TabIndex = 1;
            // 
            // gb_c1
            // 
            this.gb_c1.Controls.Add(this.txt_descuento);
            this.gb_c1.Location = new System.Drawing.Point(510, 69);
            this.gb_c1.Name = "gb_c1";
            this.gb_c1.Size = new System.Drawing.Size(113, 51);
            this.gb_c1.TabIndex = 2;
            this.gb_c1.TabStop = false;
            this.gb_c1.Text = "DESCUENTO";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(6, 19);
            this.txt_descuento.MaxLength = 20;
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(101, 20);
            this.txt_descuento.TabIndex = 1;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(510, 181);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(113, 49);
            this.bt_aceptar.TabIndex = 4;
            this.bt_aceptar.Text = "GUARDAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(12, 181);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(492, 287);
            this.dgv_tabla.TabIndex = 6;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_pre_s_servicio);
            this.groupBox1.Location = new System.Drawing.Point(261, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRECIO DEL SEGUNDO SERVIO";
            // 
            // txt_pre_s_servicio
            // 
            this.txt_pre_s_servicio.Enabled = false;
            this.txt_pre_s_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_pre_s_servicio.MaxLength = 20;
            this.txt_pre_s_servicio.Name = "txt_pre_s_servicio";
            this.txt_pre_s_servicio.Size = new System.Drawing.Size(231, 20);
            this.txt_pre_s_servicio.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txt_s_servicio);
            this.groupBox3.Location = new System.Drawing.Point(261, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 106);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SEGUNDO SERVICIO";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(42, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "BUSCAR SERVICIO";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_s_servicio
            // 
            this.txt_s_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_s_servicio.MaxLength = 20;
            this.txt_s_servicio.Name = "txt_s_servicio";
            this.txt_s_servicio.Size = new System.Drawing.Size(231, 20);
            this.txt_s_servicio.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_pre_p_servicio);
            this.groupBox4.Location = new System.Drawing.Point(12, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 51);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRECIO DEL PRIMER SERVICIO";
            // 
            // txt_pre_p_servicio
            // 
            this.txt_pre_p_servicio.Enabled = false;
            this.txt_pre_p_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_pre_p_servicio.MaxLength = 20;
            this.txt_pre_p_servicio.Name = "txt_pre_p_servicio";
            this.txt_pre_p_servicio.Size = new System.Drawing.Size(231, 20);
            this.txt_pre_p_servicio.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_nuevo_presio);
            this.groupBox5.Location = new System.Drawing.Point(510, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(113, 51);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "P. PAQUETE";
            // 
            // txt_nuevo_presio
            // 
            this.txt_nuevo_presio.Enabled = false;
            this.txt_nuevo_presio.Location = new System.Drawing.Point(6, 19);
            this.txt_nuevo_presio.MaxLength = 20;
            this.txt_nuevo_presio.Name = "txt_nuevo_presio";
            this.txt_nuevo_presio.Size = new System.Drawing.Size(101, 20);
            this.txt_nuevo_presio.TabIndex = 1;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(510, 236);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(113, 49);
            this.btn_borrar.TabIndex = 7;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(517, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(517, 343);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // PaquetesAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 480);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.gb_c1);
            this.Controls.Add(this.gb_codigo);
            this.Name = "PaquetesAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaquetesAgregar";
            this.Activated += new System.EventHandler(this.PaquetesAgregar_Activated);
            this.Load += new System.EventHandler(this.PaquetesAgregar_Load);
            this.gb_codigo.ResumeLayout(false);
            this.gb_codigo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_c1.ResumeLayout(false);
            this.gb_c1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_p_servicio;
        private System.Windows.Forms.GroupBox gb_c1;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_pre_s_servicio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_s_servicio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_pre_p_servicio;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_nuevo_presio;
        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}