using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentasCapas.Entities;
using VentasCapas.PresentationLayer;

namespace VentasCapas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            frm.DialogResult = DialogResult.OK;
            if (frm.DialogResult == DialogResult.OK)
            {
                if (UsuarioLogueado.rol.CompareTo("Administrador") == 0)
                {
                    Application.Run(new FrmMenuAdministrador());
                }
                else if (UsuarioLogueado.rol.CompareTo("Vendedor") == 0)
                {
                    //Application.Run(new FrmMenuVendedor());
                }
                else if (UsuarioLogueado.rol.CompareTo("Gerente") == 0)
                {
                    //Application.Run(new FrmMenuGerente());
                }
                frm.Close();
            }
        }
    }
}
