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

		private string serie;

		public string Serie
		{
			get { return serie; }
			set { serie = value; }
		}

		private string numero;

		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private string tipoComprobante;

		public string TipoComprobante
		{
			get { return tipoComprobante; }
			set { tipoComprobante = value; }
		}

		private decimal igv;

		public decimal Igv
		{
			get { return igv; }
			set { igv = value; }
		}
	}
}
