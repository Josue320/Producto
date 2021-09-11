namespace GrupoM1
{
    partial class FrmProducto
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.dtpCaducidad = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.lblUnidaMedida = new System.Windows.Forms.Label();
            this.cmbUnidaMedida = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.cmbUnidaMedida);
            this.groupBox1.Controls.Add(this.lblUnidaMedida);
            this.groupBox1.Controls.Add(this.lblCaducidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblExistencia);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.dtpCaducidad);
            this.groupBox1.Controls.Add(this.nudPrecio);
            this.groupBox1.Controls.Add(this.nudExistencia);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(185, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(185, 64);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 51);
            this.txtDescripcion.TabIndex = 1;
            // 
            // nudExistencia
            // 
            this.nudExistencia.Location = new System.Drawing.Point(185, 121);
            this.nudExistencia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(200, 20);
            this.nudExistencia.TabIndex = 2;
            this.nudExistencia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(185, 147);
            this.nudPrecio.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudPrecio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(200, 20);
            this.nudPrecio.TabIndex = 3;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpCaducidad
            // 
            this.dtpCaducidad.Location = new System.Drawing.Point(185, 173);
            this.dtpCaducidad.Name = "dtpCaducidad";
            this.dtpCaducidad.Size = new System.Drawing.Size(200, 20);
            this.dtpCaducidad.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(66, 123);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblExistencia.TabIndex = 6;
            this.lblExistencia.Text = "Existencia";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(66, 67);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(66, 149);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.AutoSize = true;
            this.lblCaducidad.Location = new System.Drawing.Point(66, 179);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(113, 13);
            this.lblCaducidad.TabIndex = 9;
            this.lblCaducidad.Text = "Fecha de Vencimiento";
            // 
            // lblUnidaMedida
            // 
            this.lblUnidaMedida.AutoSize = true;
            this.lblUnidaMedida.Location = new System.Drawing.Point(69, 212);
            this.lblUnidaMedida.Name = "lblUnidaMedida";
            this.lblUnidaMedida.Size = new System.Drawing.Size(79, 13);
            this.lblUnidaMedida.TabIndex = 10;
            this.lblUnidaMedida.Text = "Unidad Medida";
            // 
            // cmbUnidaMedida
            // 
            this.cmbUnidaMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidaMedida.FormattingEnabled = true;
            this.cmbUnidaMedida.Location = new System.Drawing.Point(185, 209);
            this.cmbUnidaMedida.Name = "cmbUnidaMedida";
            this.cmbUnidaMedida.Size = new System.Drawing.Size(200, 21);
            this.cmbUnidaMedida.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAceptar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 273);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 36);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(3, 3);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(84, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 348);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbUnidaMedida;
        private System.Windows.Forms.Label lblUnidaMedida;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dtpCaducidad;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
    }
}