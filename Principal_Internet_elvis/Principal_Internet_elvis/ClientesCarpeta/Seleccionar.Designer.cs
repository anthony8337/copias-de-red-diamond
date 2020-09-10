namespace Principal_Internet_elvis.ClientesCarpeta
{
    partial class Seleccionar
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
            this.rb_colonia = new System.Windows.Forms.RadioButton();
            this.rb_barrio = new System.Windows.Forms.RadioButton();
            this.dgv_tabla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgv_tabla);
            this.groupBox1.Controls.Add(this.rb_barrio);
            this.groupBox1.Controls.Add(this.rb_colonia);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 282);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rb_colonia
            // 
            this.rb_colonia.AutoSize = true;
            this.rb_colonia.Checked = true;
            this.rb_colonia.Location = new System.Drawing.Point(6, 19);
            this.rb_colonia.Name = "rb_colonia";
            this.rb_colonia.Size = new System.Drawing.Size(72, 17);
            this.rb_colonia.TabIndex = 0;
            this.rb_colonia.TabStop = true;
            this.rb_colonia.Text = "COLONIA";
            this.rb_colonia.UseVisualStyleBackColor = true;
            this.rb_colonia.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_barrio
            // 
            this.rb_barrio.AutoSize = true;
            this.rb_barrio.Location = new System.Drawing.Point(97, 19);
            this.rb_barrio.Name = "rb_barrio";
            this.rb_barrio.Size = new System.Drawing.Size(66, 17);
            this.rb_barrio.TabIndex = 1;
            this.rb_barrio.TabStop = true;
            this.rb_barrio.Text = "BARRIO";
            this.rb_barrio.UseVisualStyleBackColor = true;
            this.rb_barrio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dgv_tabla
            // 
            this.dgv_tabla.AllowUserToAddRows = false;
            this.dgv_tabla.AllowUserToDeleteRows = false;
            this.dgv_tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla.Location = new System.Drawing.Point(6, 42);
            this.dgv_tabla.Name = "dgv_tabla";
            this.dgv_tabla.ReadOnly = true;
            this.dgv_tabla.Size = new System.Drawing.Size(398, 186);
            this.dgv_tabla.TabIndex = 2;
            this.dgv_tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabla_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Seleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 306);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Seleccionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar";
            this.Load += new System.EventHandler(this.Seleccionar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_tabla;
        private System.Windows.Forms.RadioButton rb_barrio;
        private System.Windows.Forms.RadioButton rb_colonia;
    }
}