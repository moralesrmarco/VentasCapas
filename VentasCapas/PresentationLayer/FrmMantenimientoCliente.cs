using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VentasCapas.Entities;
using VentasCapas.BusinessLogicLayer;

namespace VentasCapas.PresentationLayer
{
    public partial class FrmMantenimientoCliente : Form
    {
        public FrmMantenimientoCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                short id;
                short.TryParse(txtIdCliente.Text, out id);
                Cliente cliente = new Cliente();
                cliente.Entidad = txtEntidad.Text;
                cliente.Ruc = txtRuc.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Contacto = txtContacto.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Area = txtArea.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Observacion = txtObservacion.Text;
                cliente.Ciudad = txtCiudad.Text;
                ClienteBLL clienteBLL = new ClienteBLL();
                if (id == 0)
                {
                    // Nuevo cliente
                    int resp = clienteBLL.insertar(cliente);
                    txtIdCliente.Text = cliente.IdCliente.ToString();
                    //if (resp > 0)
                    //{
                    //    MessageBox.Show("Cliente insertado correctamente.");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error al insertar el cliente.");
                    //}
                }
                else
                {
                    // Actualizar cliente existente
                    cliente.IdCliente = id;
                    int resp = clienteBLL.actualizar(cliente);
                    //if (resp > 0)
                    //{
                    //    MessageBox.Show("Cliente actualizado correctamente.");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error al actualizar el cliente.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                short id;
                short.TryParse(txtIdCliente.Text, out id);
                if (id == 0)
                {
                    MessageBox.Show("No hay un cliente seleccionado para eliminar.", "Aviso error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dialog = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dialog == DialogResult.Yes) {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    int resp = clienteBLL.eliminar(id);
                    //if (resp > 0)
                    //{
                    //    // Limpiar los campos del formulario después de la eliminación
                    //    txtIdCliente.Text = "";
                    //    txtEntidad.Text = "";
                    //    txtRuc.Text = "";
                    //    txtDireccion.Text = "";
                    //    txtContacto.Text = "";
                    //    txtCorreo.Text = "";
                    //    txtArea.Text = "";
                    //    txtTelefono.Text = "";
                    //    txtObservacion.Text = "";
                    //    txtCiudad.Text = "";
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Error al eliminar el cliente.");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMantenimientoClienteBuscarCliente form = new FrmMantenimientoClienteBuscarCliente();
                form.ShowDialog(this);
                if (form.id > 0) { 
                    ClienteBLL clienteBLL = new ClienteBLL();
                    Cliente cliente = clienteBLL.buscarPorId(form.id);
                    if (cliente != null)
                    {
                        txtIdCliente.Text = cliente.IdCliente.ToString();
                        txtEntidad.Text = cliente.Entidad;
                        txtRuc.Text = cliente.Ruc;
                        txtDireccion.Text = cliente.Direccion;
                        txtContacto.Text = cliente.Contacto;
                        txtCorreo.Text = cliente.Correo;
                        txtArea.Text = cliente.Area;
                        txtTelefono.Text = cliente.Telefono;
                        txtObservacion.Text = cliente.Observacion;
                        txtCiudad.Text = cliente.Ciudad;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
