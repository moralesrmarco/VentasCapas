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
    public partial class FrmCambiarClave : Form
    {
        public FrmCambiarClave()
        {
            InitializeComponent();
        }

        private void FrmCambiarClave_Load(object sender, EventArgs e)
        {
            txtIdUsuario.Text = UsuarioLogueado.idUsuario.ToString();
            txtApellidosNombres.Text = UsuarioLogueado.apellidosNombres;
            txtDNI.Text = UsuarioLogueado.dni;
            txtRol.Text = UsuarioLogueado.rol;
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            try
            {
                string claveActual = txtClaveActual.Text;
                string claveNueva1 = txtClaveNueva.Text;
                string claveNueva2 = txtRepetirClaveNueva.Text;
                if (string.IsNullOrWhiteSpace(claveActual))
                {
                    MessageBox.Show("Proporcione la contraseña actual", "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(claveNueva1))
                {
                    MessageBox.Show("Proporcione la nueva contraseña", "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(claveNueva2))
                {
                    MessageBox.Show("Proporcione la confirmación de la nueva contraseña", "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (claveNueva1.CompareTo(claveNueva2) != 0)
                {
                    MessageBox.Show("La nueva contraseña y la confirmación de la nueva contraseña no coinciden", "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBLL.cambiarClave(claveActual, claveNueva1);
                MessageBox.Show("La contraseña ha sido cambiada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
