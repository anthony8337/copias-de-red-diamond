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
            this.btn_imp_c = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_cli_e = new System.Windows.Forms.RadioButton();
            this.r_cli_d = new System.Windows.Forms.RadioButton();
            this.r_cli_a = new System.Windows.Forms.RadioButton();
            this.btn_b_c = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_rango = new System.Windows.Forms.CheckBox();
            this.d_h = new System.Windows.Forms.GroupBox();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_bu_cli = new System.Windows.Forms.Button();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_f_c = new System.Windows.Forms.Button();
            this.btn_im_f = new System.Windows.Forms.Button();
            this.vgb_tabla = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_paquete = new System.Windows.Forms.RadioButton();
            this.rb_servicio = new System.Windows.Forms.RadioButton();
            this.btn_ver_paquete = new System.Windows.Forms.Button();
            this.btn_imprimir_paquete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_selecciona = new System.Windows.Forms.Button();
            this.txt_nombre_sector = new System.Windows.Forms.TextBox();
            this.rb_sectores = new System.Windows.Forms.RadioButton();
            this.rb_colonias = new System.Windows.Forms.RadioButton();
            this.rb_barrio = new System.Windows.Forms.RadioButton();
            this.btn_ver_lugares = new System.Windows.Forms.Button();
            this.btn_imprimir_sector = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_restableser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.d_h.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vgb_tabla)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_imp_c
            // 
            this.btn_imp_c.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btn_imp_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imp_c.Location = new System.Drawing.Point(6, 80);
            this.btn_imp_c.Name = "btn_imp_c";
            this.btn_imp_c.Size = new System.Drawing.Size(127, 57);
            this.btn_imp_c.TabIndex = 0;
            this.btn_imp_c.Text = "IMPRIMIR";
            this.btn_imp_c.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imp_c.UseVisualStyleBackColor = true;
            this.btn_imp_c.Click += new System.EventHandler(this.btn_imp_c_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_cli_e);
            this.groupBox1.Controls.Add(this.r_cli_d);
            this.groupBox1.Controls.Add(this.r_cli_a);
            this.groupBox1.Controls.Add(this.btn_b_c);
            this.groupBox1.Controls.Add(this.btn_imp_c);
            this.groupBox1.Location = new System.Drawing.Point(39, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE ESTADOS DE LOS CLIENTES";
            // 
            // r_cli_e
            // 
            this.r_cli_e.AutoSize = true;
            this.r_cli_e.Location = new System.Drawing.Point(195, 24);
            this.r_cli_e.Name = "r_cli_e";
            this.r_cli_e.Size = new System.Drawing.Size(141, 17);
            this.r_cli_e.TabIndex = 4;
            this.r_cli_e.Text = "TODOS LOS ESTADOS";
            this.r_cli_e.UseVisualStyleBackColor = true;
            // 
            // r_cli_d
            // 
            this.r_cli_d.AutoSize = true;
            this.r_cli_d.Location = new System.Drawing.Point(6, 47);
            this.r_cli_d.Name = "r_cli_d";
            this.r_cli_d.Size = new System.Drawing.Size(163, 17);
            this.r_cli_d.TabIndex = 3;
            this.r_cli_d.Text = "CLIENTES DESACTIVADOS";
            this.r_cli_d.UseVisualStyleBackColor = true;
            // 
            // r_cli_a
            // 
            this.r_cli_a.AutoSize = true;
            this.r_cli_a.Checked = true;
            this.r_cli_a.Location = new System.Drawing.Point(6, 24);
            this.r_cli_a.Name = "r_cli_a";
            this.r_cli_a.Size = new System.Drawing.Size(141, 17);
            this.r_cli_a.TabIndex = 2;
            this.r_cli_a.TabStop = true;
            this.r_cli_a.Text = "CLIENTES ACTIVADOS";
            this.r_cli_a.UseVisualStyleBackColor = true;
            // 
            // btn_b_c
            // 
            this.btn_b_c.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btn_b_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_b_c.Location = new System.Drawing.Point(231, 80);
            this.btn_b_c.Name = "btn_b_c";
            this.btn_b_c.Size = new System.Drawing.Size(127, 57);
            this.btn_b_c.TabIndex = 1;
            this.btn_b_c.Text = "VER";
            this.btn_b_c.UseVisualStyleBackColor = true;
            this.btn_b_c.Click += new System.EventHandler(this.btn_b_c_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_rango);
            this.groupBox2.Controls.Add(this.d_h);
            this.groupBox2.Controls.Add(this.btn_bu_cli);
            this.groupBox2.Controls.Add(this.txt_cliente);
            this.groupBox2.Controls.Add(this.btn_f_c);
            this.groupBox2.Controls.Add(this.btn_im_f);
            this.groupBox2.Location = new System.Drawing.Point(39, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FACTURAS DE LOS CLIENTES";
            // 
            // cb_rango
            // 
            this.cb_rango.AutoSize = true;
            this.cb_rango.Location = new System.Drawing.Point(5, 74);
            this.cb_rango.Name = "cb_rango";
            this.cb_rango.Size = new System.Drawing.Size(128, 17);
            this.cb_rango.TabIndex = 5;
            this.cb_rango.Text = "RANGO DE FECHAS";
            this.cb_rango.UseVisualStyleBackColor = true;
            this.cb_rango.CheckedChanged += new System.EventHandler(this.cb_rango_CheckedChanged);
            // 
            // d_h
            // 
            this.d_h.Controls.Add(this.dtp_hasta);
            this.d_h.Controls.Add(this.label2);
            this.d_h.Controls.Add(this.label1);
            this.d_h.Controls.Add(this.dtp_desde);
            this.d_h.Location = new System.Drawing.Point(6, 97);
            this.d_h.Name = "d_h";
            this.d_h.Size = new System.Drawing.Size(211, 113);
            this.d_h.TabIndex = 6;
            this.d_h.TabStop = false;
            this.d_h.Text = "DESDE-HASTA";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(6, 75);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(200, 20);
            this.dtp_hasta.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "HASTA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DESDE";
            // 
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(6, 36);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(200, 20);
            this.dtp_desde.TabIndex = 5;
            // 
            // btn_bu_cli
            // 
            this.btn_bu_cli.Location = new System.Drawing.Point(6, 45);
            this.btn_bu_cli.Name = "btn_bu_cli";
            this.btn_bu_cli.Size = new System.Drawing.Size(127, 23);
            this.btn_bu_cli.TabIndex = 5;
            this.btn_bu_cli.Text = "BUSCAR CLIENTES";
            this.btn_bu_cli.UseVisualStyleBackColor = true;
            this.btn_bu_cli.Click += new System.EventHandler(this.btn_bu_cli_Click);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(6, 19);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(289, 20);
            this.txt_cliente.TabIndex = 2;
            // 
            // btn_f_c
            // 
            this.btn_f_c.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btn_f_c.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_f_c.Location = new System.Drawing.Point(223, 74);
            this.btn_f_c.Name = "btn_f_c";
            this.btn_f_c.Size = new System.Drawing.Size(135, 57);
            this.btn_f_c.TabIndex = 1;
            this.btn_f_c.Text = "VER";
            this.btn_f_c.UseVisualStyleBackColor = true;
            this.btn_f_c.Click += new System.EventHandler(this.btn_f_c_Click);
            // 
            // btn_im_f
            // 
            this.btn_im_f.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btn_im_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_im_f.Location = new System.Drawing.Point(223, 153);
            this.btn_im_f.Name = "btn_im_f";
            this.btn_im_f.Size = new System.Drawing.Size(135, 57);
            this.btn_im_f.TabIndex = 0;
            this.btn_im_f.Text = "IMPRIMIR";
            this.btn_im_f.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_im_f.UseVisualStyleBackColor = true;
            this.btn_im_f.Click += new System.EventHandler(this.btn_im_f_Click);
            // 
            // vgb_tabla
            // 
            this.vgb_tabla.AllowUserToAddRows = false;
            this.vgb_tabla.AllowUserToDeleteRows = false;
            this.vgb_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vgb_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vgb_tabla.Location = new System.Drawing.Point(221, 59);
            this.vgb_tabla.Name = "vgb_tabla";
            this.vgb_tabla.ReadOnly = true;
            this.vgb_tabla.Size = new System.Drawing.Size(902, 657);
            this.vgb_tabla.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "VISTA PREVIA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_paquete);
            this.groupBox4.Controls.Add(this.rb_servicio);
            this.groupBox4.Controls.Add(this.btn_ver_paquete);
            this.groupBox4.Controls.Add(this.btn_imprimir_paquete);
            this.groupBox4.Location = new System.Drawing.Point(39, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(364, 143);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SERVICIOS Y PAQUETES";
            // 
            // rb_paquete
            // 
            this.rb_paquete.AutoSize = true;
            this.rb_paquete.Location = new System.Drawing.Point(6, 47);
            this.rb_paquete.Name = "rb_paquete";
            this.rb_paquete.Size = new System.Drawing.Size(83, 17);
            this.rb_paquete.TabIndex = 3;
            this.rb_paquete.Text = "PAQUETES";
            this.rb_paquete.UseVisualStyleBackColor = true;
            // 
            // rb_servicio
            // 
            this.rb_servicio.AutoSize = true;
            this.rb_servicio.Checked = true;
            this.rb_servicio.Location = new System.Drawing.Point(6, 24);
            this.rb_servicio.Name = "rb_servicio";
            this.rb_servicio.Size = new System.Drawing.Size(82, 17);
            this.rb_servicio.TabIndex = 2;
            this.rb_servicio.TabStop = true;
            this.rb_servicio.Text = "SERVICIOS";
            this.rb_servicio.UseVisualStyleBackColor = true;
            // 
            // btn_ver_paquete
            // 
            this.btn_ver_paquete.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btn_ver_paquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_paquete.Location = new System.Drawing.Point(231, 80);
            this.btn_ver_paquete.Name = "btn_ver_paquete";
            this.btn_ver_paquete.Size = new System.Drawing.Size(127, 57);
            this.btn_ver_paquete.TabIndex = 1;
            this.btn_ver_paquete.Text = "VER";
            this.btn_ver_paquete.UseVisualStyleBackColor = true;
            this.btn_ver_paquete.Click += new System.EventHandler(this.btn_ver_paquete_Click);
            // 
            // btn_imprimir_paquete
            // 
            this.btn_imprimir_paquete.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btn_imprimir_paquete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir_paquete.Location = new System.Drawing.Point(6, 80);
            this.btn_imprimir_paquete.Name = "btn_imprimir_paquete";
            this.btn_imprimir_paquete.Size = new System.Drawing.Size(127, 57);
            this.btn_imprimir_paquete.TabIndex = 0;
            this.btn_imprimir_paquete.Text = "IMPRIMIR";
            this.btn_imprimir_paquete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir_paquete.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.rb_sectores);
            this.groupBox5.Controls.Add(this.rb_colonias);
            this.groupBox5.Controls.Add(this.rb_barrio);
            this.groupBox5.Controls.Add(this.btn_ver_lugares);
            this.groupBox5.Controls.Add(this.btn_imprimir_sector);
            this.groupBox5.Location = new System.Drawing.Point(39, 181);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 203);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "REPORTE DE LOS LUGARES";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_selecciona);
            this.groupBox6.Controls.Add(this.txt_nombre_sector);
            this.groupBox6.Location = new System.Drawing.Point(6, 47);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 87);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BUSCAR POR SECTORES";
            // 
            // btn_selecciona
            // 
            this.btn_selecciona.Location = new System.Drawing.Point(6, 19);
            this.btn_selecciona.Name = "btn_selecciona";
            this.btn_selecciona.Size = new System.Drawing.Size(157, 23);
            this.btn_selecciona.TabIndex = 7;
            this.btn_selecciona.Text = "SELECCIONAR SECTOR";
            this.btn_selecciona.UseVisualStyleBackColor = true;
            this.btn_selecciona.Click += new System.EventHandler(this.btn_selecciona_Click);
            // 
            // txt_nombre_sector
            // 
            this.txt_nombre_sector.Enabled = false;
            this.txt_nombre_sector.Location = new System.Drawing.Point(6, 48);
            this.txt_nombre_sector.Name = "txt_nombre_sector";
            this.txt_nombre_sector.Size = new System.Drawing.Size(340, 20);
            this.txt_nombre_sector.TabIndex = 7;
            // 
            // rb_sectores
            // 
            this.rb_sectores.AutoSize = true;
            this.rb_sectores.Location = new System.Drawing.Point(275, 24);
            this.rb_sectores.Name = "rb_sectores";
            this.rb_sectores.Size = new System.Drawing.Size(83, 17);
            this.rb_sectores.TabIndex = 4;
            this.rb_sectores.Text = "SECTORES";
            this.rb_sectores.UseVisualStyleBackColor = true;
            this.rb_sectores.CheckedChanged += new System.EventHandler(this.rb_sectores_CheckedChanged);
            // 
            // rb_colonias
            // 
            this.rb_colonias.AutoSize = true;
            this.rb_colonias.Location = new System.Drawing.Point(133, 24);
            this.rb_colonias.Name = "rb_colonias";
            this.rb_colonias.Size = new System.Drawing.Size(79, 17);
            this.rb_colonias.TabIndex = 3;
            this.rb_colonias.Text = "COLONIAS";
            this.rb_colonias.UseVisualStyleBackColor = true;
            // 
            // rb_barrio
            // 
            this.rb_barrio.AutoSize = true;
            this.rb_barrio.Checked = true;
            this.rb_barrio.Location = new System.Drawing.Point(6, 24);
            this.rb_barrio.Name = "rb_barrio";
            this.rb_barrio.Size = new System.Drawing.Size(73, 17);
            this.rb_barrio.TabIndex = 2;
            this.rb_barrio.TabStop = true;
            this.rb_barrio.Text = "BARRIOS";
            this.rb_barrio.UseVisualStyleBackColor = true;
            // 
            // btn_ver_lugares
            // 
            this.btn_ver_lugares.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btn_ver_lugares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ver_lugares.Location = new System.Drawing.Point(231, 140);
            this.btn_ver_lugares.Name = "btn_ver_lugares";
            this.btn_ver_lugares.Size = new System.Drawing.Size(127, 57);
            this.btn_ver_lugares.TabIndex = 1;
            this.btn_ver_lugares.Text = "VER";
            this.btn_ver_lugares.UseVisualStyleBackColor = true;
            this.btn_ver_lugares.Click += new System.EventHandler(this.btn_ver_lugares_Click);
            // 
            // btn_imprimir_sector
            // 
            this.btn_imprimir_sector.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btn_imprimir_sector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir_sector.Location = new System.Drawing.Point(6, 140);
            this.btn_imprimir_sector.Name = "btn_imprimir_sector";
            this.btn_imprimir_sector.Size = new System.Drawing.Size(127, 57);
            this.btn_imprimir_sector.TabIndex = 0;
            this.btn_imprimir_sector.Text = "IMPRIMIR";
            this.btn_imprimir_sector.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir_sector.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(442, 414);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "REPORTES DE CLIENTES Y FACTURAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "REPORTES DE SERVICIOS Y LUGARES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.Location = new System.Drawing.Point(12, 476);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(168, 65);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_restableser
            // 
            this.btn_restableser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_restableser.Location = new System.Drawing.Point(282, 476);
            this.btn_restableser.Name = "btn_restableser";
            this.btn_restableser.Size = new System.Drawing.Size(168, 65);
            this.btn_restableser.TabIndex = 9;
            this.btn_restableser.Text = "LIMPIAR";
            this.btn_restableser.UseVisualStyleBackColor = true;
            this.btn_restableser.Click += new System.EventHandler(this.btn_restableser_Click);
            // 
            // ReportesTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 749);
            this.Controls.Add(this.btn_restableser);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vgb_tabla);
            this.Name = "ReportesTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesTipo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ReportesTipo_Activated);
            this.Load += new System.EventHandler(this.ReportesTipo_Load);
            this.Resize += new System.EventHandler(this.ReportesTipo_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.d_h.ResumeLayout(false);
            this.d_h.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vgb_tabla)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imp_c;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton r_cli_d;
        private System.Windows.Forms.RadioButton r_cli_a;
        private System.Windows.Forms.Button btn_b_c;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_rango;
        private System.Windows.Forms.GroupBox d_h;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Button btn_bu_cli;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_f_c;
        private System.Windows.Forms.Button btn_im_f;
        private System.Windows.Forms.DataGridView vgb_tabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_paquete;
        private System.Windows.Forms.RadioButton rb_servicio;
        private System.Windows.Forms.Button btn_ver_paquete;
        private System.Windows.Forms.Button btn_imprimir_paquete;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_colonias;
        private System.Windows.Forms.RadioButton rb_barrio;
        private System.Windows.Forms.Button btn_ver_lugares;
        private System.Windows.Forms.Button btn_imprimir_sector;
        private System.Windows.Forms.RadioButton r_cli_e;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_selecciona;
        private System.Windows.Forms.TextBox txt_nombre_sector;
        private System.Windows.Forms.RadioButton rb_sectores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_restableser;
    }
}