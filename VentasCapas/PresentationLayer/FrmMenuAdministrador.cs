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

namespace VentasCapas.PresentationLayer
{
    public partial class FrmMenuAdministrador : Form
    {
        public FrmMenuAdministrador()
        {
            InitializeComponent();
        }

        private void FrmMenuAdministrador_Load(object sender, EventArgs e)
        {
            etiquetaDNI.Text = "DNI: " + UsuarioLogueado.dni +" | ";
            etiquetaApellidosNombres.Text = "Nombre: " + UsuarioLogueado.apellidosNombres + " | ";
            etiquetaRol.Text = "Rol: " + UsuarioLogueado.rol;
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProcesoVenta form = new FrmProcesoVenta();
            form.MdiParent = this;
            form.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCliente form = new FrmMantenimientoCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearUsuario form = new FrmCrearUsuario();
            form.MdiParent = this;
            form.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambiarClave form = new FrmCambiarClave();
            form.ShowDialog(this);
        }

        private void reporteClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteClientes form = new FrmReporteClientes();
            form.MdiParent = this;
            form.Show();
        }
    }
}
