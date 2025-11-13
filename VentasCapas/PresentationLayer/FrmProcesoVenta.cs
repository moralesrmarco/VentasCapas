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

        private string igvIni = "18";

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
                    venta.Serie = txtSerie.Text;
                    venta.Numero = txtNumero.Text;
                    venta.TipoComprobante = cboTipoComprobante.Text.Substring(0,1);

                    decimal igv = 0;
                    decimal.TryParse(txtIGV.Text, out igv);
                    venta.Igv = igv/100;

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
            dtpFecha.Value = DateTime.Today;
            txtSerie.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtIGV.Text = igvIni;
            cboTipoComprobante.SelectedIndexChanged -= cboTipoComprobante_SelectedIndexChanged;
            cboTipoComprobante.SelectedIndex = -1;
            cboTipoComprobante.SelectedIndexChanged += cboTipoComprobante_SelectedIndexChanged;
            cboTipoComprobante.SelectedIndex = 0;
            dgvLista.Rows.Clear();
            btnNuevo.Focus();
        }

        private void FrmProcesoVenta_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoComprobante.SelectedIndex = 0;
                string tipoComprobante = cboTipoComprobante.Text.Substring(0,1);
                VentaBLL ventaBLL = new VentaBLL();
                Venta venta = new Venta();
                venta = ventaBLL.generarSerieNumeroComprobante(tipoComprobante);
                txtSerie.Text = venta.Serie;
                txtNumero.Text = venta.Numero;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboTipoComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tipoComprobante = cboTipoComprobante.Text.Substring(0, 1);
                VentaBLL ventaBLL = new VentaBLL();
                Venta venta = new Venta();
                venta = ventaBLL.generarSerieNumeroComprobante(tipoComprobante);
                txtSerie.Text = venta.Serie;
                txtNumero.Text = venta.Numero;

                if (tipoComprobante.CompareTo("F") == 0)
                {
                    lblIGV.Visible = true;
                    txtIGV.Visible =true;
                    txtIGV.Text = igvIni;
                }
                else
                {
                    lblIGV.Visible=false;
                    txtIGV.Visible=false;
                    txtIGV.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
