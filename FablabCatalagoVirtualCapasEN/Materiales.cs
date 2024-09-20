using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un registro de materiales en el sistema.
	/// </summary>
	public class Materiales
	{
		/// <summary>
		/// Identificador único del material.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre del material.
		/// </summary>
		public string NombreMaterial { get; set; }

		/// <summary>
		/// Identificador del tipo de material.
		/// </summary>
		public int IdTipoMaterial { get; set; }

		/// <summary>
		/// Precio del material.
		/// </summary>
		public decimal Precio { get; set; }

		/// <summary>
		/// Coordenada X del material en el sistema.
		/// </summary>
		public string X { get; set; }

		/// <summary>
		/// Coordenada Y del material en el sistema.
		/// </summary>
		public string Y { get; set; }

		/// <summary>
		/// Coordenada Z del material en el sistema.
		/// </summary>
		public string Z { get; set; }
	}

}
