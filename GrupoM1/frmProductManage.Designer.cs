namespace GrupoM1
{
    partial class frmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.pnlFindById = new System.Windows.Forms.FlowLayoutPanel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.pnlUnidadMedida = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.PnlRagePrice = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.pnlCaducity = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlFindById.SuspendLayout();
            this.pnlUnidadMedida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            this.PnlRagePrice.SuspendLayout();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 391);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad Medida",
            "Rango Precio",
            "Fecha Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(26, 13);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(121, 21);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.CmbFinder_SelectedIndexChanged);
            // 
            // pnlFindById
            // 
            this.pnlFindById.Controls.Add(this.txtId);
            this.pnlFindById.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlFindById.Location = new System.Drawing.Point(199, 13);
            this.pnlFindById.Name = "pnlFindById";
            this.pnlFindById.Size = new System.Drawing.Size(314, 21);
            this.pnlFindById.TabIndex = 2;
            this.pnlFindById.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(297, 20);
            this.txtId.TabIndex = 0;
            // 
            // pnlUnidadMedida
            // 
            this.pnlUnidadMedida.Controls.Add(this.cmbUnidadMedida);
            this.pnlUnidadMedida.Location = new System.Drawing.Point(199, 12);
            this.pnlUnidadMedida.Name = "pnlUnidadMedida";
            this.pnlUnidadMedida.Size = new System.Drawing.Size(314, 22);
            this.pnlUnidadMedida.TabIndex = 3;
            this.pnlUnidadMedida.Visible = false;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(3, 3);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(297, 21);
            this.cmbUnidadMedida.TabIndex = 0;
            // 
            // nudEnd
            // 
            this.nudEnd.Location = new System.Drawing.Point(129, 3);
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(120, 20);
            this.nudEnd.TabIndex = 3;
            // 
            // nudStart
            // 
            this.nudStart.Location = new System.Drawing.Point(3, 3);
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(120, 20);
            this.nudStart.TabIndex = 4;
            // 
            // PnlRagePrice
            // 
            this.PnlRagePrice.Controls.Add(this.nudStart);
            this.PnlRagePrice.Controls.Add(this.nudEnd);
            this.PnlRagePrice.Location = new System.Drawing.Point(199, 12);
            this.PnlRagePrice.Name = "PnlRagePrice";
            this.PnlRagePrice.Size = new System.Drawing.Size(314, 22);
            this.PnlRagePrice.TabIndex = 5;
            this.PnlRagePrice.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(84, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(165, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(3, 3);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(200, 20);
            this.dtpCaducity.TabIndex = 6;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(199, 12);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(314, 24);
            this.pnlCaducity.TabIndex = 7;
            this.pnlCaducity.Visible = false;
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(29, 62);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(717, 274);
            this.rtbProductView.TabIndex = 8;
            this.rtbProductView.Text = "";
            // 
            // frmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlUnidadMedida);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.PnlRagePrice);
            this.Controls.Add(this.pnlFindById);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmProductManage";
            this.Text = "frmProductManage";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlFindById.ResumeLayout(false);
            this.pnlFindById.PerformLayout();
            this.pnlUnidadMedida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            this.PnlRagePrice.ResumeLayout(false);
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.FlowLayoutPanel pnlFindById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.FlowLayoutPanel pnlUnidadMedida;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.FlowLayoutPanel PnlRagePrice;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
        private System.Windows.Forms.FlowLayoutPanel pnlCaducity;
        private System.Windows.Forms.RichTextBox rtbProductView;
    }
}