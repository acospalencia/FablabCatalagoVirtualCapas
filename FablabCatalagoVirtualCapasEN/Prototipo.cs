using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un prototipo con información detallada sobre su fabricación y características.
	/// </summary>
	public class Prototipo
	{
		/// <summary>
		/// Identificador único del prototipo.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre del prototipo.
		/// </summary>
		public string NombrePrototipo { get; set; }

		/// <summary>
		/// Identificador del material utilizado en el prototipo.
		/// </summary>
		public int IdMaterial { get; set; }

		/// <summary>
		/// Coordenada X en el espacio o en el diseño del prototipo.
		/// </summary>
		public string X { get; set; }

		/// <summary>
		/// Coordenada Y en el espacio o en el diseño del prototipo.
		/// </summary>
		public string Y { get; set; }

		/// <summary>
		/// Coordenada Z en el espacio o en el diseño del prototipo.
		/// </summary>
		public string Z { get; set; }

		/// <summary>
		/// Descripción detallada del prototipo.
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Imagen del prototipo en formato de bytes.
		/// </summary>
		public byte[] Imagen { get; set; }

		/// <summary>
		/// Identificador del tiempo de duración asociado al prototipo.
		/// </summary>
		public int IdDuracion { get; set; }

		/// <summary>
		/// Identificador del estado actual del prototipo.
		/// </summary>
		public int IdEstado { get; set; }

		/// <summary>
		/// Identificador de la maquinaria utilizada para el prototipo.
		/// </summary>
		public int IdMaquinaria { get; set; }
	}

}
