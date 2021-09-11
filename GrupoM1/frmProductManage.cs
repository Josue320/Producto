using Infraestructura.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoM1
{
    public partial class frmProductManage : Form
    {
        private ProductoModel productoModel;
        public frmProductManage()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void CmbFinder_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlFindById.Visible = true;
                    pnlCaducity.Visible = false;
                    PnlRagePrice.Visible = false;
                    pnlUnidadMedida.Visible = false;
                    break;
                case 1:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    PnlRagePrice.Visible = false;
                    pnlUnidadMedida.Visible = true;
                    break;
                case 2:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = false;
                    PnlRagePrice.Visible = true;
                    pnlUnidadMedida.Visible = false;
                    break;
                case 3:
                    pnlFindById.Visible = false;
                    pnlCaducity.Visible = true;
                    PnlRagePrice.Visible = false;
                    pnlUnidadMedida.Visible = false;
                    break;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProducto f1 = new FrmProducto();
            f1.PModel = productoModel;
            f1.ShowDialog();

            rtbProductView.Text = productoModel.GetProductoAsJson();
        }
    }
}
