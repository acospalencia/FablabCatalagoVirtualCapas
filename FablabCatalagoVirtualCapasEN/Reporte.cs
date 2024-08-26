using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un reporte que incluye el autor y la cantidad de prototipos.
	/// </summary>
	public class Reporte
	{
		/// <summary>
		/// Nombre del autor del reporte.
		/// </summary>
		public string Autor { get; set; }

		/// <summary>
		/// Cantidad de prototipos asociados al reporte.
		/// </summary>
		public int CantidadPrototipos { get; set; }
	}

}
