using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un registro de maquinaria en el sistema.
	/// </summary>
	public class Maquinaria
	{
		/// <summary>
		/// Identificador único de la maquinaria.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre de la maquinaria.
		/// </summary>
		public string Nombre { get; set; }

		/// <summary>
		/// Marca de la maquinaria.
		/// </summary>
		public string Marca { get; set; }

		/// <summary>
		/// Detalle o descripción adicional de la maquinaria.
		/// </summary>
		public string Detalle { get; set; }

		/// <summary>
		/// Identificador del estado actual de la maquinaria.
		/// </summary>
		public int Idestado { get; set; }
	}

}
