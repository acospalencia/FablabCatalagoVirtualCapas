using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un tipo de material con detalles descriptivos.
	/// </summary>
	public class TipoMaterial
	{
		/// <summary>
		/// Identificador único del tipo de material.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre del tipo de material.
		/// </summary>
		public string NombreTipo { get; set; }

		/// <summary>
		/// Descripción adicional sobre el tipo de material.
		/// </summary>
		public string Descripcion { get; set; }
	}

}
