namespace Principal_Internet_elvis.Paquetes
{
    partial class Servicios
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
            this.btn_borrar = new System.Windows.Forms.Button();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_pre_p_servicio = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_p_servicio = new System.Windows.Forms.TextBox();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.gb_codigo = new System.Windows.Forms.GroupBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.gb_codigo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(506, 145);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(113, 49);
            this.btn_borrar.TabIndex = 17;
            this.btn_borrar.Text = "BORRAR";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(506, 90);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(113, 49);
            this.bt_aceptar.TabIndex = 13;
            this.bt_aceptar.Text = "GUARDAR";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_pre_p_servicio);
            this.groupBox4.Location = new System.Drawing.Point(467, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 51);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRECIO DEL SERCICIO";
            // 
            // txt_pre_p_servicio
            // 
            this.txt_pre_p_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_pre_p_servicio.MaxLength = 20;
            this.txt_pre_p_servicio.Name = "txt_pre_p_servicio";
            this.txt_pre_p_servicio.Size = new System.Drawing.Size(185, 20);
            this.txt_pre_p_servicio.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_p_servicio);
            this.groupBox2.Location = new System.Drawing.Point(128, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOMBRE SERVICIO";
            // 
            // txt_p_servicio
            // 
            this.txt_p_servicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_p_servicio.Location = new System.Drawing.Point(6, 19);
            this.txt_p_servicio.MaxLength = 255;
            this.txt_p_servicio.Name = "txt_p_servicio";
            this.txt_p_servicio.Size = new System.Drawing.Size(321, 20);
            this.txt_p_servicio.TabIndex = 1;
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(9, 69);
            this.dgv_tabla.MultiSelect = false;
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_tabla.Size = new System.Drawing.Size(446, 285);
            this.dgv_tabla.TabIndex = 16;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // gb_codigo
            // 
            this.gb_codigo.Controls.Add(this.txt_codigo);
            this.gb_codigo.Location = new System.Drawing.Point(9, 12);
            this.gb_codigo.Name = "gb_codigo";
            this.gb_codigo.Size = new System.Drawing.Size(113, 51);
            this.gb_codigo.TabIndex = 8;
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
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.bt_aceptar);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_tabla);
            this.Controls.Add(this.gb_codigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.gb_codigo.ResumeLayout(false);
            this.gb_codigo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_borrar;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_pre_p_servicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_p_servicio;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.GroupBox gb_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}