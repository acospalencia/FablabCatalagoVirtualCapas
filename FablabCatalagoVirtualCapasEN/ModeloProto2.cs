using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un modelo de prototipo con información detallada.
	/// </summary>
	public class ModeloProto2
	{
		public int Id { get; set; }
		/// <summary>
		/// Nombre del prototipo.
		/// </summary>
		public string NombrePrototipo { get; set; }

		public string CatNombre { get; set; }


		/// <summary>
		/// Nombre del material asociado con el prototipo.
		/// </summary>
		public string NombreMaterial { get; set; }

		/// <summary>
		/// Coordenada X del prototipo en el sistema.
		/// </summary>
		public string X { get; set; }

		/// <summary>
		/// Coordenada Y del prototipo en el sistema.
		/// </summary>
		public string Y { get; set; }

		/// <summary>
		/// Coordenada Z del prototipo en el sistema.
		/// </summary>
		public string Z { get; set; }

		/// <summary>
		/// Tiempo requerido para el armado del prototipo.
		/// </summary>
		public string TiempoArmado { get; set; }

		/// <summary>
		/// Tiempo requerido para el diseño del prototipo.
		/// </summary>
		public string TiempoDiseno { get; set; }

		/// <summary>
		/// Tiempo requerido para la fabricación del prototipo.
		/// </summary>
		public string TiempoFabricado { get; set; }

		/// <summary>
		/// Nombre del estado actual del prototipo.
		/// </summary>
		public string NombreEstado { get; set; }

		/// <summary>
		/// Descripción detallada del prototipo.
		/// </summary>
		public string Descripcion { get; set; }

		/// <summary>
		/// Imagen del prototipo en formato de arreglo de bytes.
		/// </summary>
		public byte[] Imagen { get; set; }

		/// <summary>
		/// Nombre del autor o creador del prototipo.
		/// </summary>
		public string Nombre { get; set; }
	}

}
