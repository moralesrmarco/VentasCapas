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
    public partial class FrmCrearUsuario : Form
    {
        public FrmCrearUsuario()
        {
            InitializeComponent();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            cboRol.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtApellidosNombres.Text) || string.IsNullOrWhiteSpace(txtDni.Text) || string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(txtConfirmarClave.Text)) 
                {
                    MessageBox.Show("Proporcione todos los datos.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtApellidosNombres.Focus();
                    return;
                }
                if (txtClave.Text.Length < 4)
                {
                    MessageBox.Show("La contraseña debe contener almenos 4 caracteres.", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClave.Focus();
                    return;
                }
                if (txtClave.Text != txtConfirmarClave.Text)
                {
                    MessageBox.Show("La contraseña y la confirmación de la contraseña no coinciden, intentelo de nuevo.", "Contraseñas erroneas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClave.Focus();
                    return;
                }
                int id;
                int.TryParse(txtIdUsuario.Text, out id);
                Usuario usuario = new Usuario();
                usuario.ApellidosNombres = txtApellidosNombres.Text;
                usuario.Dni = txtDni.Text;
                usuario.Rol = cboRol.Text;
                usuario.Clave = txtClave.Text;

                UsuarioBLL usuarioBLL = new UsuarioBLL();

                if (id == 0)
                {
                    usuarioBLL.insertar(usuario);
                    txtIdUsuario.Text = usuario.IdUsuario.ToString();
                }
                else
                {
                    MessageBox.Show("Aqui va el codigo para actualizacion de usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = txtApellidosNombres.Text = txtDni.Text = txtClave.Text = txtConfirmarClave.Text = string.Empty;
        }
    }
}
