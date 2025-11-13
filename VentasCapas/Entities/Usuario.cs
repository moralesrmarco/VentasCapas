using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasCapas.Entities
{
    internal class Usuario
    {

		private int idUsuario;

		public int IdUsuario
		{
			get { return idUsuario; }
			set { idUsuario = value; }
		}

		private string dni;

		public string  Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		private string clave;

		public string Clave
		{
			get { return clave; }
			set { clave = value; }
		}

		private string rol;

		public string Rol
		{
			get { return rol; }
			set { rol = value; }
		}

		private string apellidosNombres;

		public string ApellidosNombres
		{
			get { return apellidosNombres; }
			set { apellidosNombres = value; }
		}

		private bool activo;

		public bool Activo
		{
			get { return activo; }
			set { activo = value; }
		}


	}
}
