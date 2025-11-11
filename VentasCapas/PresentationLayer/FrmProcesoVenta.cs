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
using static System.Windows.Forms.MonthCalendar;

namespace VentasCapas.PresentationLayer
{
    public partial class FrmProcesoVenta : Form
    {
        public FrmProcesoVenta()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMantenimientoClienteBuscarCliente form = new FrmMantenimientoClienteBuscarCliente();
                form.ShowDialog(this);
                if (form.id > 0)
                {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.buscarPorId(form.id);
                    if (cliente != null)
                    {
                        txtIdCliente.Text = cliente.IdCliente.ToString();
                        txtEntidad.Text = cliente.Entidad;
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
            try
            {
                FrmProcesoVentaBusquedaProducto form = new FrmProcesoVentaBusquedaProducto();
                form.ShowDialog(this);
                if (form.idProducto_ > 0)
                {
                    dgvLista.Rows.Add(
                        dgvLista.Rows.Count + 1,
                        form.idProducto_,
                        form.descripcion_,
                        form.precioUnitario_,
                        form.cantidad_,
                        form.precioUnitario_ * form.cantidad_
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                short idCliente;
                short.TryParse(txtIdCliente.Text, out idCliente);
                if (idCliente == 0)
                {
                    MessageBox.Show("Ingrese cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (dgvLista.Rows.Count == 0)
                {
                    MessageBox.Show("Ingrese productos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIdVenta.Text))
                {
                    Venta venta = new Venta();
                    venta.Cliente = new Cliente();
                    venta.VentaDetalles = new List<VentaDetalle>();

                    venta.Fecha = dtpFecha.Value;
                    venta.Cliente.IdCliente = idCliente;
                    foreach (DataGridViewRow row in dgvLista.Rows)
                    {
                        VentaDetalle ventaDetalle = new VentaDetalle();
                        ventaDetalle.Producto = new Producto();
                        ventaDetalle.Producto.IdProducto = short.Parse(row.Cells["idProducto"].Value.ToString());
                        ventaDetalle.Cantidad = int.Parse(row.Cells["cantidad"].Value.ToString());
                        ventaDetalle.PrecioUnitario = decimal.Parse(row.Cells["precioUnitario"].Value.ToString());
                        venta.VentaDetalles.Add(ventaDetalle);
                    }

                    VentaBLL ventaBLL = new VentaBLL();
                    ventaBLL.insertar(venta);
                    txtIdVenta.Text = venta.IdVenta.ToString();
                }
                else
                {
                    MessageBox.Show("Aqui debe ir el proceso de actualización de la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdVenta.Text = "";
            txtEntidad.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            dgvLista.Rows.Clear();
        }
    }
}
