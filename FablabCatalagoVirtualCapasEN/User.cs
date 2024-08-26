using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa un usuario con su información de autenticación.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Identificador único del usuario.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Nombre de usuario para el inicio de sesión.
		/// </summary>
		public string Usuario { get; set; }

		/// <summary>
		/// Contraseña del usuario para el inicio de sesión.
		/// </summary>
		public string Password { get; set; }
	}

}
