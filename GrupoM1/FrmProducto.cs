using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmProducto : Form
    {
        public ProductoModel PModel { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto()
            {
                Id = PModel.GetLastProductoId() + 1,
                Nombres = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Existencia = (int)nudExistencia.Value,
                Precio = nudPrecio.Value,
                FechaVencimiento = dtpCaducidad.Value,
                unidadMedida = (UnidadMedida)cmbUnidaMedida.SelectedIndex
            };
            PModel.Add(p);
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbUnidaMedida.Items.AddRange(Enum.GetValues(typeof(UnidadMedida)).Cast<Object>().ToArray();
        }
    }
}
