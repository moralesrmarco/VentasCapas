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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Dni = txtDni.Text;
                usuario.Clave = txtClave.Text;

                UsuarioBLL usuarioBLL = new UsuarioBLL();
                bool resp = usuarioBLL.validarUsuario(usuario);
                if (resp)
                {
                    UsuarioLogueado.idUsuario = usuario.IdUsuario;
                    UsuarioLogueado.dni = usuario.Dni; 
                    UsuarioLogueado.apellidosNombres = usuario.ApellidosNombres;
                    UsuarioLogueado.rol = usuario.Rol;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Acceso denegado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
