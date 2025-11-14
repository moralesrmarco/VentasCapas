using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.DataAccessLayer;
using VentasCapas.Entities;

namespace VentasCapas.BusinessLogicLayer
{
    internal class UsuarioBLL
    {
        public int insertar(Usuario usuario)
        {
            try
            {
                int resp = 0;
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                resp = usuarioDAL.insertar(usuario);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool validarUsuario(Usuario usuario)
        {
            try
            {
                bool resp = false;
                UsuarioDAL usuarioDAL = new UsuarioDAL();

                resp = usuarioDAL.validarUsuario(usuario);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int cambiarClave(string claveActual, string claveNueva)
        {
            try
            {
                int resp = 0;
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                resp = usuarioDAL.cambiarClave(claveActual, claveNueva);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
