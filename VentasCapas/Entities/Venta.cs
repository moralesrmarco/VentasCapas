using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCapas.Entities
{
	internal class Venta
	{
		private int idVenta;

		public int IdVenta
		{
			get { return idVenta; }
			set { idVenta = value; }
		}

		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		private List<VentaDetalle> ventaDetalles;

		public List<VentaDetalle> VentaDetalles
		{
			get { return ventaDetalles; }
			set { ventaDetalles = value; }
		}

	}
}
