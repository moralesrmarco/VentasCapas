using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCapas.Entities
{
    internal class Producto
    {
		private int idProducto;

		public int IdProducto
		{
			get { return idProducto; }
			set { idProducto = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private decimal precioUnitario;

		public decimal PrecioUnitario
		{
			get { return precioUnitario; }
			set { precioUnitario = value; }
		}

		private List<VentaDetalle> ventaDetalles;

		public List<VentaDetalle> VentaDetalles
		{
			get { return ventaDetalles; }
			set { ventaDetalles = value; }
		}

	}
}
