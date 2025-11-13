using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasCapas.BusinessLogicLayer;
using VentasCapas.Entities;

namespace VentasCapas.PresentationLayer
{
    public partial class FrmProcesoVentaBusquedaProducto : Form
    {

        public int idProducto_;
        public string descripcion_;
        public decimal precioUnitario_;
        public int cantidad_;

        public FrmProcesoVentaBusquedaProducto()
        {
            InitializeComponent();
        }

        private void txtCadenaBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dgvLista.Rows.Clear();
                    ProductoBLL productoBLL = new ProductoBLL();
                    List<Producto> productos = new List<Producto>();
                    string cadenaBusqueda = txtCadenaBusqueda.Text;
                    productos = productoBLL.buscarPorDescripcion(cadenaBusqueda);
                    foreach (Producto producto in productos)
                    {
                        dgvLista.Rows.Add(
                            dgvLista.Rows.Count + 1,
                            producto.Descripcion,
                            producto.IdProducto,
                            producto.PrecioUnitario
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdProducto.Text, out this.idProducto_);
            this.descripcion_ = txtDescripcion.Text;
            decimal.TryParse(txtPrecioUnitario.Text, out this.precioUnitario_);
            int.TryParse(nudCantidad.Value.ToString(), out this.cantidad_);
            this.Close();
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dgvLista.Rows[e.RowIndex].Cells["idProducto"].Value.ToString();
            txtDescripcion.Text = dgvLista.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            txtPrecioUnitario.Text = dgvLista.Rows[e.RowIndex].Cells["precioUnitario"].Value.ToString();
        }

        private void btnLimpiarTxt_Click(object sender, EventArgs e)
        {
            txtCadenaBusqueda.Clear();
            txtPrecioUnitario.Clear();
            txtIdProducto.Clear();
            txtDescripcion.Clear();
            nudCantidad.Value = 1;
            dgvLista.Rows.Clear();
            txtCadenaBusqueda.Focus();
        }
    }
}
