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
    public partial class FrmMantenimientoClienteBuscarCliente : Form
    {
        public short id = -1;

        public FrmMantenimientoClienteBuscarCliente()
        {
            InitializeComponent();
        }

        private void txtEntidad_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    BuscarClientesPorEntidad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiarTxt_Click(object sender, EventArgs e)
        {
            txtEntidad.Text = "";
            dgvLista.Rows.Clear();
            txtEntidad.Focus();
        }

        private void BuscarClientesPorEntidad()
        {
            try
            {
                dgvLista.Rows.Clear();
                ClienteBLL clienteBLL = new ClienteBLL();
                List<Cliente> clientes = clienteBLL.buscarPorEntidad(txtEntidad.Text);
                foreach (Cliente cliente in clientes)
                {
                    dgvLista.Rows.Add(dgvLista.Rows.Count + 1, cliente.Entidad, cliente.Ruc, cliente.IdCliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt16(dgvLista.Rows[e.RowIndex].Cells["IdCliente"].Value);
            this.Close();
        }
    }
}
