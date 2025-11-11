using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VentasCapas.Entities;
using VentasCapas.DataAccessLayer;

namespace VentasCapas.BusinessLogicLayer
{
    internal class ClienteBLL
    {

        public int insertar(Cliente cliente)
        {
			try
			{
				int resp = 0;
				ClienteDAL clienteDAL = new ClienteDAL();
				resp = clienteDAL.insertar(cliente);
                return resp;
			}
			catch (Exception)
			{
				throw;
			}
        }

        public int actualizar(Cliente cliente)
        {
            try
            {
                int resp = 0;
                ClienteDAL clienteDAL = new ClienteDAL();
                resp = clienteDAL.actualizar(cliente);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int eliminar(short idCliente)
        {
            try
            {
                int resp = 0;
                ClienteDAL clienteDAL = new ClienteDAL();
                resp = clienteDAL.eliminar(idCliente);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cliente> buscarPorEntidad(string entidad)
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                ClienteDAL clienteDAL = new ClienteDAL();
                clientes = clienteDAL.buscarPorEntidad(entidad);
                return clientes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cliente buscarPorId(short idCliente)
        {
            try
            {
                Cliente cliente = new Cliente();
                ClienteDAL clienteDAL = new ClienteDAL();
                cliente = clienteDAL.buscarPorId(idCliente);
                return cliente;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
