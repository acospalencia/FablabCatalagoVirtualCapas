using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un estado dentro del sistema.
	/// </summary>
	public class Estados
	{
		/// <summary>
		/// Identificador único del estado.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre del estado.
		/// </summary>
		public string NombreEstado { get; set; }

		/// <summary>
		/// Detalle o descripción adicional sobre el estado.
		/// </summary>
		public string Detalle { get; set; }
	}

}
