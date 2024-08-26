using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa la inscripción de un autor en un club.
	/// </summary>
	public class InscripcionClub
	{
		/// <summary>
		/// Identificador único de la inscripción.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Identificador del autor que se inscribe en el club.
		/// </summary>
		public int IdAutor { get; set; }

		/// <summary>
		/// Identificador del club al que se inscribe el autor.
		/// </summary>
		public int IdClub { get; set; }

		/// <summary>
		/// Fecha en la que se realizó la inscripción.
		/// </summary>
		public DateTime FechaInscripcion { get; set; }

		/// <summary>
		/// Detalle o descripción adicional sobre la inscripción.
		/// </summary>
		public string Detalle { get; set; }
	}

}
