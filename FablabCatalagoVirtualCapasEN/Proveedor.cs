using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa la información de un proveedor.
	/// </summary>
	public class Proveedor
	{
		/// <summary>
		/// Identificador único del proveedor.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre del proveedor.
		/// </summary>
		public string Nombres { get; set; }

		/// <summary>
		/// Apellidos del proveedor.
		/// </summary>
		public string Apellidos { get; set; }

		/// <summary>
		/// Dirección física del proveedor.
		/// </summary>
		public string Direccion { get; set; }

		/// <summary>
		/// Número de teléfono del proveedor.
		/// </summary>
		public string NumTelefono { get; set; }

		/// <summary>
		/// Correo electrónico del proveedor.
		/// </summary>
		public string CorreoElectronico { get; set; }
	}

}
