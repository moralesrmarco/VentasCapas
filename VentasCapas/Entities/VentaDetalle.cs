using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCapas.Entities
{
    internal class VentaDetalle
    {
        private Venta venta;

        public Venta Venta
        {
            get { return venta; }
            set { venta = value; }
        }

        private Producto producto;

        public Producto Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        private int cantidad;
                    
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private decimal precioUnitario;

        public decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }


    }
}
