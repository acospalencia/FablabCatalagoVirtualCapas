using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un autor con información personal y de registro.
	/// </summary>
	public class Autores
	{
		/// <summary>
		/// Identificador único del autor.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombres del autor.
		/// </summary>
		public string Nombres { get; set; }

		/// <summary>
		/// Apellidos del autor.
		/// </summary>
		public string Apellidos { get; set; }

		/// <summary>
		/// Correo electrónico del autor.
		/// </summary>
		/// 
		public bool EstaInscrito { get; set; }

		public string CorreElectronico { get; set; }

		public string Password { get; set; }

		/// <summary>
		/// Fecha en la que el autor fue registrado.
		/// </summary>
		public DateTime FechaRegistro { get; set; }
	}

}
