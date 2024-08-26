using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los usuarios.
	/// </summary>
	public class UserBL
	{
		// Instancia de la capa de acceso a datos para los usuarios.
		private UserDAL UserDAL = new UserDAL();

		/// <summary>
		/// Guarda un nuevo usuario en la base de datos.
		/// </summary>
		/// <param name="pUser">Instancia del objeto User a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarUser(User pUser)
		{
			return UserDAL.GuardarNuevoUser(pUser);
		}

		/// <summary>
		/// Elimina un usuario de la base de datos.
		/// </summary>
		/// <param name="pUser">Instancia del objeto User a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarUsuario(User pUser)
		{
			return UserDAL.EliminarUsuario(pUser);
		}

		/// <summary>
		/// Modifica los datos de un usuario existente en la base de datos.
		/// </summary>
		/// <param name="pUser">Instancia del objeto User con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModificarUsuario(User pUser)
		{
			return UserDAL.ActualizarUsuarios(pUser);
		}

		/// <summary>
		/// Obtiene la lista completa de usuarios desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos User.</returns>
		public List<User> regresarLista()
		{
			return UserDAL.RegresarLista();
		}

		/// <summary>
		/// Realiza el proceso de inicio de sesión para un usuario.
		/// </summary>
		/// <param name="pUser">Instancia del objeto User con las credenciales para el inicio de sesión.</param>
		/// <returns>Una instancia del objeto User si las credenciales son correctas, o null si no lo son.</returns>
		public User Login(User pUser)
		{
			return UserDAL.Logearse(pUser);
		}
	}

}
