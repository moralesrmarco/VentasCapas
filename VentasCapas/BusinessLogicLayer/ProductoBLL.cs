using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.DataAccessLayer;
using VentasCapas.Entities;

namespace VentasCapas.BusinessLogicLayer
{
    internal class ProductoBLL
    {
        public List<Producto> buscarPorDescripcion(string descripcion)
        {
            try
            {
                List<Producto> productos = new List<Producto>();
                ProductoDAL productoDAL = new ProductoDAL();
                productos = productoDAL.buscarPorDescripcion(descripcion);
                return productos;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
