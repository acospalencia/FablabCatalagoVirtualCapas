using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa las duraciones de diferentes fases del proceso de producción de un prototipo.
	/// </summary>
	public class Duraciones
	{
		/// <summary>
		/// Identificador único de la duración.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Tiempo dedicado al diseño del prototipo.
		/// </summary>
		public string TiempoDiseno { get; set; }

		/// <summary>
		/// Tiempo dedicado a la fabricación del prototipo.
		/// </summary>
		public string TiempoFabricado { get; set; }

		/// <summary>
		/// Tiempo dedicado al armado del prototipo.
		/// </summary>
		public string TiempoArmado { get; set; }
	}

}
