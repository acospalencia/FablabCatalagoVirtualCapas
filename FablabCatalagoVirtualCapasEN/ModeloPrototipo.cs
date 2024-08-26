using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un modelo de prototipo con información básica sobre el prototipo.
	/// </summary>
	public class ModeloPrototipo
	{
		/// <summary>
		/// Nombre del prototipo.
		/// </summary>
		public string Nombre { get; set; }

		/// <summary>
		/// Material utilizado en la fabricación del prototipo.
		/// </summary>
		public string MaterialUsado { get; set; }

		/// <summary>
		/// Maquinaria utilizada para la creación del prototipo.
		/// </summary>
		public string MaquinariaUsada { get; set; }

		/// <summary>
		/// Estado actual del prototipo.
		/// </summary>
		public string Estado { get; set; }
	}

}
