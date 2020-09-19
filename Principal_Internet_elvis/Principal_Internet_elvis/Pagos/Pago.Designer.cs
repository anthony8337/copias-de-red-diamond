namespace Principal_Internet_elvis.Pagos
{
    partial class Pago
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
            this.gb_cliente = new System.Windows.Forms.GroupBox();
            this.btnbusCLI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion_c = new System.Windows.Forms.TextBox();
            this.txt_rtn_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo_c = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBusConcep = new System.Windows.Forms.GroupBox();
            this.btnAtrasConcepto = new System.Windows.Forms.Button();
            this.dgv_tabla_p = new System.Windows.Forms.DataGridView();
            this.gb_paquete = new System.Windows.Forms.GroupBox();
            this.cb_adelantado = new System.Windows.Forms.CheckBox();
            this.dtp_mes_p = new System.Windows.Forms.DateTimePicker();
            this.btnBusCON = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_monto_p = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descripcion_p = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo_p = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtp_fechaemision = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgv_detalles = new System.Windows.Forms.DataGridView();
            this.txt_totalpagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.bt_borrar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gb_acciones = new System.Windows.Forms.GroupBox();
            this.cb_tipopago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_efectivo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.dgv_tabla_c = new System.Windows.Forms.DataGridView();
            this.btnAtrasCliente = new System.Windows.Forms.Button();
            this.txt_buscar_c = new System.Windows.Forms.TextBox();
            this.gBusCliente = new System.Windows.Forms.GroupBox();
            this.txt_b_p = new System.Windows.Forms.TextBox();
            this.gb_cliente.SuspendLayout();
            this.gBusConcep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_p)).BeginInit();
            this.gb_paquete.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.gb_acciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_c)).BeginInit();
            this.gBusCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_cliente
            // 
            this.gb_cliente.BackColor = System.Drawing.Color.White;
            this.gb_cliente.Controls.Add(this.btnbusCLI);
            this.gb_cliente.Controls.Add(this.label4);
            this.gb_cliente.Controls.Add(this.txt_direccion_c);
            this.gb_cliente.Controls.Add(this.txt_rtn_c);
            this.gb_cliente.Controls.Add(this.label3);
            this.gb_cliente.Controls.Add(this.txt_nombre_c);
            this.gb_cliente.Controls.Add(this.label2);
            this.gb_cliente.Controls.Add(this.txt_codigo_c);
            this.gb_cliente.Controls.Add(this.label1);
            this.gb_cliente.Location = new System.Drawing.Point(207, 12);
            this.gb_cliente.Name = "gb_cliente";
            this.gb_cliente.Size = new System.Drawing.Size(509, 188);
            this.gb_cliente.TabIndex = 0;
            this.gb_cliente.TabStop = false;
            this.gb_cliente.Text = "DATOS DEL CLIENTE";
            // 
            // btnbusCLI
            // 
            this.btnbusCLI.BackColor = System.Drawing.Color.White;
            this.btnbusCLI.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btnbusCLI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbusCLI.Location = new System.Drawing.Point(393, 13);
            this.btnbusCLI.Name = "btnbusCLI";
            this.btnbusCLI.Size = new System.Drawing.Size(108, 47);
            this.btnbusCLI.TabIndex = 8;
            this.btnbusCLI.Text = "BUSCAR";
            this.btnbusCLI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbusCLI.UseVisualStyleBackColor = false;
            this.btnbusCLI.Click += new System.EventHandler(this.btnbusCLI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DIRECCION:";
            // 
            // txt_direccion_c
            // 
            this.txt_direccion_c.Location = new System.Drawing.Point(92, 117);
            this.txt_direccion_c.Name = "txt_direccion_c";
            this.txt_direccion_c.ReadOnly = true;
            this.txt_direccion_c.Size = new System.Drawing.Size(386, 20);
            this.txt_direccion_c.TabIndex = 6;
            // 
            // txt_rtn_c
            // 
            this.txt_rtn_c.Location = new System.Drawing.Point(92, 93);
            this.txt_rtn_c.Name = "txt_rtn_c";
            this.txt_rtn_c.ReadOnly = true;
            this.txt_rtn_c.Size = new System.Drawing.Size(145, 20);
            this.txt_rtn_c.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RTN:";
            // 
            // txt_nombre_c
            // 
            this.txt_nombre_c.Location = new System.Drawing.Point(92, 65);
            this.txt_nombre_c.Name = "txt_nombre_c";
            this.txt_nombre_c.ReadOnly = true;
            this.txt_nombre_c.Size = new System.Drawing.Size(386, 20);
            this.txt_nombre_c.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE:";
            // 
            // txt_codigo_c
            // 
            this.txt_codigo_c.Location = new System.Drawing.Point(92, 39);
            this.txt_codigo_c.Name = "txt_codigo_c";
            this.txt_codigo_c.ReadOnly = true;
            this.txt_codigo_c.Size = new System.Drawing.Size(69, 20);
            this.txt_codigo_c.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            // 
            // gBusConcep
            // 
            this.gBusConcep.BackColor = System.Drawing.Color.White;
            this.gBusConcep.Controls.Add(this.txt_b_p);
            this.gBusConcep.Controls.Add(this.btnAtrasConcepto);
            this.gBusConcep.Controls.Add(this.dgv_tabla_p);
            this.gBusConcep.Location = new System.Drawing.Point(207, 212);
            this.gBusConcep.Name = "gBusConcep";
            this.gBusConcep.Size = new System.Drawing.Size(509, 179);
            this.gBusConcep.TabIndex = 6;
            this.gBusConcep.TabStop = false;
            this.gBusConcep.Text = "BUSCAR PAQUETE";
            // 
            // btnAtrasConcepto
            // 
            this.btnAtrasConcepto.Location = new System.Drawing.Point(420, 14);
            this.btnAtrasConcepto.Name = "btnAtrasConcepto";
            this.btnAtrasConcepto.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasConcepto.TabIndex = 1;
            this.btnAtrasConcepto.Text = "ATRAS";
            this.btnAtrasConcepto.UseVisualStyleBackColor = true;
            this.btnAtrasConcepto.Click += new System.EventHandler(this.btnAtrasConcepto_Click);
            // 
            // dgv_tabla_p
            // 
            this.dgv_tabla_p.AllowUserToAddRows = false;
            this.dgv_tabla_p.AllowUserToDeleteRows = false;
            this.dgv_tabla_p.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla_p.Location = new System.Drawing.Point(6, 41);
            this.dgv_tabla_p.Name = "dgv_tabla_p";
            this.dgv_tabla_p.ReadOnly = true;
            this.dgv_tabla_p.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla_p.Size = new System.Drawing.Size(489, 138);
            this.dgv_tabla_p.TabIndex = 0;
            // 
            // gb_paquete
            // 
            this.gb_paquete.BackColor = System.Drawing.Color.White;
            this.gb_paquete.Controls.Add(this.cb_adelantado);
            this.gb_paquete.Controls.Add(this.dtp_mes_p);
            this.gb_paquete.Controls.Add(this.btnBusCON);
            this.gb_paquete.Controls.Add(this.label5);
            this.gb_paquete.Controls.Add(this.txt_monto_p);
            this.gb_paquete.Controls.Add(this.label6);
            this.gb_paquete.Controls.Add(this.txt_descripcion_p);
            this.gb_paquete.Controls.Add(this.label7);
            this.gb_paquete.Controls.Add(this.txt_codigo_p);
            this.gb_paquete.Controls.Add(this.label8);
            this.gb_paquete.Location = new System.Drawing.Point(207, 212);
            this.gb_paquete.Name = "gb_paquete";
            this.gb_paquete.Size = new System.Drawing.Size(509, 179);
            this.gb_paquete.TabIndex = 5;
            this.gb_paquete.TabStop = false;
            this.gb_paquete.Text = "DATOS ";
            // 
            // cb_adelantado
            // 
            this.cb_adelantado.AutoSize = true;
            this.cb_adelantado.Location = new System.Drawing.Point(15, 143);
            this.cb_adelantado.Name = "cb_adelantado";
            this.cb_adelantado.Size = new System.Drawing.Size(125, 17);
            this.cb_adelantado.TabIndex = 9;
            this.cb_adelantado.Text = "MES ADELANTADO";
            this.cb_adelantado.UseVisualStyleBackColor = true;
            // 
            // dtp_mes_p
            // 
            this.dtp_mes_p.CustomFormat = "MMMM yyyy";
            this.dtp_mes_p.Enabled = false;
            this.dtp_mes_p.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_mes_p.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_mes_p.Location = new System.Drawing.Point(360, 99);
            this.dtp_mes_p.Name = "dtp_mes_p";
            this.dtp_mes_p.ShowUpDown = true;
            this.dtp_mes_p.Size = new System.Drawing.Size(141, 20);
            this.dtp_mes_p.TabIndex = 7;
            // 
            // btnBusCON
            // 
            this.btnBusCON.Image = global::Principal_Internet_elvis.Properties.Resources.lupa_chiquito;
            this.btnBusCON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusCON.Location = new System.Drawing.Point(393, 14);
            this.btnBusCON.Name = "btnBusCON";
            this.btnBusCON.Size = new System.Drawing.Size(108, 47);
            this.btnBusCON.TabIndex = 8;
            this.btnBusCON.Text = "BUSCAR";
            this.btnBusCON.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusCON.Click += new System.EventHandler(this.btnBusCON_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MES DE PAGO:";
            // 
            // txt_monto_p
            // 
            this.txt_monto_p.Location = new System.Drawing.Point(94, 99);
            this.txt_monto_p.Name = "txt_monto_p";
            this.txt_monto_p.ReadOnly = true;
            this.txt_monto_p.Size = new System.Drawing.Size(143, 20);
            this.txt_monto_p.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "MONTO:";
            // 
            // txt_descripcion_p
            // 
            this.txt_descripcion_p.BackColor = System.Drawing.SystemColors.Control;
            this.txt_descripcion_p.Enabled = false;
            this.txt_descripcion_p.Location = new System.Drawing.Point(94, 67);
            this.txt_descripcion_p.Name = "txt_descripcion_p";
            this.txt_descripcion_p.Size = new System.Drawing.Size(407, 20);
            this.txt_descripcion_p.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "DESCRIPCION:";
            // 
            // txt_codigo_p
            // 
            this.txt_codigo_p.Location = new System.Drawing.Point(94, 38);
            this.txt_codigo_p.Name = "txt_codigo_p";
            this.txt_codigo_p.ReadOnly = true;
            this.txt_codigo_p.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_p.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CODIGO:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtp_fechaemision);
            this.groupBox6.Location = new System.Drawing.Point(722, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 65);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FECHA DE EMICION";
            // 
            // dtp_fechaemision
            // 
            this.dtp_fechaemision.Location = new System.Drawing.Point(6, 26);
            this.dtp_fechaemision.Name = "dtp_fechaemision";
            this.dtp_fechaemision.Size = new System.Drawing.Size(200, 20);
            this.dtp_fechaemision.TabIndex = 9;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgv_detalles);
            this.groupBox7.Location = new System.Drawing.Point(12, 397);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(923, 114);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DETALLE DEL COMPROBANTE DE PAGO";
            // 
            // dgv_detalles
            // 
            this.dgv_detalles.AllowUserToAddRows = false;
            this.dgv_detalles.AllowUserToDeleteRows = false;
            this.dgv_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detalles.Location = new System.Drawing.Point(6, 19);
            this.dgv_detalles.Name = "dgv_detalles";
            this.dgv_detalles.ReadOnly = true;
            this.dgv_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detalles.Size = new System.Drawing.Size(910, 89);
            this.dgv_detalles.TabIndex = 0;
            // 
            // txt_totalpagar
            // 
            this.txt_totalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalpagar.Location = new System.Drawing.Point(788, 530);
            this.txt_totalpagar.Name = "txt_totalpagar";
            this.txt_totalpagar.ReadOnly = true;
            this.txt_totalpagar.Size = new System.Drawing.Size(142, 20);
            this.txt_totalpagar.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(629, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "TOTAL A PAGAR:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources.emblemunreadable_93487;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(328, 514);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 55);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::Principal_Internet_elvis.Properties.Resources.Print_icon_icons_com_55835;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(170, 514);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(152, 55);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Principal_Internet_elvis.Properties.Resources.savetheapplication_guardar_2958_1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 513);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // img_logo
            // 
            this.img_logo.Image = global::Principal_Internet_elvis.Properties.Resources.Logo_del_proyecto;
            this.img_logo.Location = new System.Drawing.Point(18, 96);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(170, 170);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 12;
            this.img_logo.TabStop = false;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Image = global::Principal_Internet_elvis.Properties.Resources.rounded_add_button_icon_icons_com_72592;
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_agregar.Location = new System.Drawing.Point(7, 19);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(200, 46);
            this.bt_agregar.TabIndex = 11;
            this.bt_agregar.Text = "AGREGAR";
            this.bt_agregar.UseVisualStyleBackColor = true;
            // 
            // bt_borrar
            // 
            this.bt_borrar.Image = global::Principal_Internet_elvis.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.bt_borrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_borrar.Location = new System.Drawing.Point(6, 71);
            this.bt_borrar.Name = "bt_borrar";
            this.bt_borrar.Size = new System.Drawing.Size(200, 46);
            this.bt_borrar.TabIndex = 10;
            this.bt_borrar.Text = "BORRAR";
            this.bt_borrar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Image = global::Principal_Internet_elvis.Properties.Resources.cancel_86054;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(6, 123);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(200, 46);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "CANCELAR";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            // 
            // gb_acciones
            // 
            this.gb_acciones.Controls.Add(this.bt_agregar);
            this.gb_acciones.Controls.Add(this.bt_borrar);
            this.gb_acciones.Controls.Add(this.bt_cancelar);
            this.gb_acciones.Location = new System.Drawing.Point(722, 84);
            this.gb_acciones.Name = "gb_acciones";
            this.gb_acciones.Size = new System.Drawing.Size(213, 182);
            this.gb_acciones.TabIndex = 16;
            this.gb_acciones.TabStop = false;
            this.gb_acciones.Text = "ACCIONES";
            // 
            // cb_tipopago
            // 
            this.cb_tipopago.FormattingEnabled = true;
            this.cb_tipopago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARGETA DE CREDITO",
            "BITCOIN",
            "TIGO MONEY",
            "DEPOSITO BANCARIO"});
            this.cb_tipopago.Location = new System.Drawing.Point(6, 19);
            this.cb_tipopago.Name = "cb_tipopago";
            this.cb_tipopago.Size = new System.Drawing.Size(199, 21);
            this.cb_tipopago.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tipopago);
            this.groupBox1.Location = new System.Drawing.Point(723, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 48);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE PAGO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_efectivo);
            this.groupBox2.Location = new System.Drawing.Point(723, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(97, 48);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EFECTIVO:";
            // 
            // txt_efectivo
            // 
            this.txt_efectivo.Enabled = false;
            this.txt_efectivo.Location = new System.Drawing.Point(6, 16);
            this.txt_efectivo.Name = "txt_efectivo";
            this.txt_efectivo.Size = new System.Drawing.Size(85, 20);
            this.txt_efectivo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_cambio);
            this.groupBox3.Location = new System.Drawing.Point(826, 326);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 48);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CAMBIO:";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(6, 16);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.ReadOnly = true;
            this.txt_cambio.Size = new System.Drawing.Size(92, 20);
            this.txt_cambio.TabIndex = 0;
            // 
            // dgv_tabla_c
            // 
            this.dgv_tabla_c.AllowUserToAddRows = false;
            this.dgv_tabla_c.AllowUserToDeleteRows = false;
            this.dgv_tabla_c.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_tabla_c.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla_c.Location = new System.Drawing.Point(6, 41);
            this.dgv_tabla_c.Name = "dgv_tabla_c";
            this.dgv_tabla_c.ReadOnly = true;
            this.dgv_tabla_c.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabla_c.Size = new System.Drawing.Size(495, 137);
            this.dgv_tabla_c.TabIndex = 0;
            this.dgv_tabla_c.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_c_CellClick);
            // 
            // btnAtrasCliente
            // 
            this.btnAtrasCliente.Location = new System.Drawing.Point(426, 12);
            this.btnAtrasCliente.Name = "btnAtrasCliente";
            this.btnAtrasCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasCliente.TabIndex = 1;
            this.btnAtrasCliente.Text = "ATRAS";
            this.btnAtrasCliente.UseVisualStyleBackColor = true;
            this.btnAtrasCliente.Click += new System.EventHandler(this.btnAtrasCliente_Click);
            // 
            // txt_buscar_c
            // 
            this.txt_buscar_c.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar_c.Location = new System.Drawing.Point(9, 14);
            this.txt_buscar_c.Name = "txt_buscar_c";
            this.txt_buscar_c.Size = new System.Drawing.Size(411, 20);
            this.txt_buscar_c.TabIndex = 4;
            this.txt_buscar_c.TextChanged += new System.EventHandler(this.txt_buscar_c_TextChanged);
            // 
            // gBusCliente
            // 
            this.gBusCliente.BackColor = System.Drawing.Color.White;
            this.gBusCliente.Controls.Add(this.txt_buscar_c);
            this.gBusCliente.Controls.Add(this.btnAtrasCliente);
            this.gBusCliente.Controls.Add(this.dgv_tabla_c);
            this.gBusCliente.Location = new System.Drawing.Point(207, 12);
            this.gBusCliente.Name = "gBusCliente";
            this.gBusCliente.Size = new System.Drawing.Size(509, 188);
            this.gBusCliente.TabIndex = 1;
            this.gBusCliente.TabStop = false;
            this.gBusCliente.Text = "BUSCAR CLIENTE";
            // 
            // txt_b_p
            // 
            this.txt_b_p.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_b_p.Location = new System.Drawing.Point(6, 15);
            this.txt_b_p.Name = "txt_b_p";
            this.txt_b_p.Size = new System.Drawing.Size(411, 20);
            this.txt_b_p.TabIndex = 5;
            this.txt_b_p.TextChanged += new System.EventHandler(this.txt_b_p_TextChanged);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 580);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_acciones);
            this.Controls.Add(this.txt_totalpagar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gb_cliente);
            this.Controls.Add(this.gBusCliente);
            this.Controls.Add(this.gb_paquete);
            this.Controls.Add(this.gBusConcep);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGO";
            this.Load += new System.EventHandler(this.Pago_Load);
            this.gb_cliente.ResumeLayout(false);
            this.gb_cliente.PerformLayout();
            this.gBusConcep.ResumeLayout(false);
            this.gBusConcep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_p)).EndInit();
            this.gb_paquete.ResumeLayout(false);
            this.gb_paquete.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.gb_acciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_c)).EndInit();
            this.gBusCliente.ResumeLayout(false);
            this.gBusCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_direccion_c;
        private System.Windows.Forms.TextBox txt_rtn_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre_c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbusCLI;
        private System.Windows.Forms.GroupBox gBusConcep;
        private System.Windows.Forms.Button btnAtrasConcepto;
        private System.Windows.Forms.DataGridView dgv_tabla_p;
        private System.Windows.Forms.GroupBox gb_paquete;
        private System.Windows.Forms.DateTimePicker dtp_mes_p;
        private System.Windows.Forms.Button btnBusCON;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion_p;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo_p;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtp_fechaemision;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_borrar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgv_detalles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txt_totalpagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_acciones;
        private System.Windows.Forms.ComboBox cb_tipopago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_efectivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.CheckBox cb_adelantado;
        private System.Windows.Forms.DataGridView dgv_tabla_c;
        private System.Windows.Forms.Button btnAtrasCliente;
        private System.Windows.Forms.TextBox txt_buscar_c;
        private System.Windows.Forms.GroupBox gBusCliente;
        private System.Windows.Forms.TextBox txt_b_p;
    }
}