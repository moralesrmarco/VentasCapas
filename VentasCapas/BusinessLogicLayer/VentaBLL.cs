using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasCapas.DataAccessLayer;
using VentasCapas.Entities;

namespace VentasCapas.BusinessLogicLayer
{
    internal class VentaBLL
    {
        public int insertar(Venta venta)
        {
            try
            {
                int resp = 0;
                VentaDAL ventaDAL = new VentaDAL();
                resp = ventaDAL.insertar(venta);
                return resp;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Venta generarSerieNumeroComprobante(string tipoComprobante)
        {
            try
            {
                Venta venta = new Venta();
                VentaDAL ventaDAL = new VentaDAL();
                venta = ventaDAL.generarSerieNumeroComprobante(tipoComprobante);
                return venta;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
