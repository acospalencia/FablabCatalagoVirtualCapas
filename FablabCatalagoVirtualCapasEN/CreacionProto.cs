using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa la información de la creación de un prototipo.
	/// </summary>
	public class CreacionProto
	{
		/// <summary>
		/// Identificador único de la creación del prototipo.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Identificador del autor principal que lidera la creación del prototipo.
		/// </summary>
		public int IdAutorLider { get; set; }

		/// <summary>
		/// Identificador del prototipo que se está creando.
		/// </summary>
		public int IdPrototipo { get; set; }

		/// <summary>
		/// Identificador del usuario que está registrando la creación del prototipo.
		/// </summary>
		public int IdUsuario { get; set; }

		/// <summary>
		/// Fecha en la que se creó el prototipo.
		/// </summary>
		public DateTime FechaCreacion { get; set; }

		/// <summary>
		/// Número de autores en el equipo de creación del prototipo.
		/// </summary>
		public string NumeroAutoresEquipo { get; set; }

		/// <summary>
		/// Nombres de los autores del prototipo.
		/// </summary>
		public string Nombres { get; set; }
	}

}
