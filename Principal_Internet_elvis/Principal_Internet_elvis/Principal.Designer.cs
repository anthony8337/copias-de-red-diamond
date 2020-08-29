namespace Proyecto_dawelin
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_botones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnPaquetes = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.dgv_pendientes = new System.Windows.Forms.DataGridView();
            this.lb_pendiente = new System.Windows.Forms.Label();
            this.bt_actualizar = new System.Windows.Forms.Button();
            this.panel_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_botones
            // 
            this.panel_botones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_botones.Controls.Add(this.btnPago);
            this.panel_botones.Controls.Add(this.btnCliente);
            this.panel_botones.Controls.Add(this.btnEstado);
            this.panel_botones.Controls.Add(this.btnPaquetes);
            this.panel_botones.Controls.Add(this.btnFactura);
            this.panel_botones.Controls.Add(this.btnUbicacion);
            this.panel_botones.Controls.Add(this.btnReportes);
            this.panel_botones.Controls.Add(this.btnConfiguracion);
            this.panel_botones.Controls.Add(this.btnSalir);
            this.panel_botones.Location = new System.Drawing.Point(13, 12);
            this.panel_botones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_botones.Name = "panel_botones";
            this.panel_botones.Size = new System.Drawing.Size(273, 675);
            this.panel_botones.TabIndex = 1;
            // 
            // btnPago
            // 
            this.btnPago.BackColor = System.Drawing.Color.White;
            this.btnPago.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPago.Location = new System.Drawing.Point(4, 3);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(261, 69);
            this.btnPago.TabIndex = 0;
            this.btnPago.Text = "PAGOS";
            this.btnPago.UseVisualStyleBackColor = false;
            this.btnPago.Click += new System.EventHandler(this.bntPago_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::Principal_Internet_elvis.Properties.Resources._4;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(4, 78);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(261, 69);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "CLIENTES";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.White;
            this.btnEstado.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Image = global::Principal_Internet_elvis.Properties.Resources._9;
            this.btnEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstado.Location = new System.Drawing.Point(4, 153);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(261, 69);
            this.btnEstado.TabIndex = 3;
            this.btnEstado.Text = "ESTADOS CLIENTES";
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Click += new System.EventHandler(this.bt_estado_Click);
            // 
            // btnPaquetes
            // 
            this.btnPaquetes.BackColor = System.Drawing.Color.White;
            this.btnPaquetes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaquetes.Image = global::Principal_Internet_elvis.Properties.Resources._6;
            this.btnPaquetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaquetes.Location = new System.Drawing.Point(4, 228);
            this.btnPaquetes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPaquetes.Name = "btnPaquetes";
            this.btnPaquetes.Size = new System.Drawing.Size(261, 69);
            this.btnPaquetes.TabIndex = 2;
            this.btnPaquetes.Text = "PAQUETES";
            this.btnPaquetes.UseVisualStyleBackColor = false;
            this.btnPaquetes.Click += new System.EventHandler(this.btnPaquetes_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.White;
            this.btnFactura.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.Image = global::Principal_Internet_elvis.Properties.Resources._7;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(4, 303);
            this.btnFactura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(261, 69);
            this.btnFactura.TabIndex = 3;
            this.btnFactura.Text = "FACTURAS";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.BackColor = System.Drawing.Color.White;
            this.btnUbicacion.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbicacion.Image = global::Principal_Internet_elvis.Properties.Resources._3;
            this.btnUbicacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUbicacion.Location = new System.Drawing.Point(4, 378);
            this.btnUbicacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(261, 69);
            this.btnUbicacion.TabIndex = 4;
            this.btnUbicacion.Text = "UBICACION";
            this.btnUbicacion.UseVisualStyleBackColor = false;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.White;
            this.btnReportes.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::Principal_Internet_elvis.Properties.Resources._5;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(4, 453);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(261, 69);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.White;
            this.btnConfiguracion.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Image = global::Principal_Internet_elvis.Properties.Resources._2;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(4, 528);
            this.btnConfiguracion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(261, 69);
            this.btnConfiguracion.TabIndex = 6;
            this.btnConfiguracion.Text = "CONFIGURACION";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Principal_Internet_elvis.Properties.Resources._8;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(4, 603);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(261, 68);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.Color.SlateGray;
            this.img_logo.Image = global::Principal_Internet_elvis.Properties.Resources.Logo_del_proyecto;
            this.img_logo.Location = new System.Drawing.Point(542, 21);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(229, 219);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logo.TabIndex = 0;
            this.img_logo.TabStop = false;
            // 
            // dgv_pendientes
            // 
            this.dgv_pendientes.AllowUserToAddRows = false;
            this.dgv_pendientes.AllowUserToDeleteRows = false;
            this.dgv_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_pendientes.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pendientes.Location = new System.Drawing.Point(281, 452);
            this.dgv_pendientes.Name = "dgv_pendientes";
            this.dgv_pendientes.ReadOnly = true;
            this.dgv_pendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pendientes.Size = new System.Drawing.Size(492, 255);
            this.dgv_pendientes.TabIndex = 3;
            this.dgv_pendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pendientes_CellDoubleClick);
            // 
            // lb_pendiente
            // 
            this.lb_pendiente.AutoSize = true;
            this.lb_pendiente.Location = new System.Drawing.Point(591, 395);
            this.lb_pendiente.Name = "lb_pendiente";
            this.lb_pendiente.Size = new System.Drawing.Size(180, 15);
            this.lb_pendiente.TabIndex = 4;
            this.lb_pendiente.Text = "PENDIENTE DE INSTALACION";
            // 
            // bt_actualizar
            // 
            this.bt_actualizar.Location = new System.Drawing.Point(629, 413);
            this.bt_actualizar.Name = "bt_actualizar";
            this.bt_actualizar.Size = new System.Drawing.Size(144, 33);
            this.bt_actualizar.TabIndex = 5;
            this.bt_actualizar.Text = "ACTUALIZAR";
            this.bt_actualizar.UseVisualStyleBackColor = true;
            this.bt_actualizar.Click += new System.EventHandler(this.bt_actualizar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(783, 720);
            this.Controls.Add(this.bt_actualizar);
            this.Controls.Add(this.lb_pendiente);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.dgv_pendientes);
            this.Controls.Add(this.panel_botones);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panel_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panel_botones;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPaquetes;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.DataGridView dgv_pendientes;
        private System.Windows.Forms.Label lb_pendiente;
        private System.Windows.Forms.Button bt_actualizar;
    }
}

