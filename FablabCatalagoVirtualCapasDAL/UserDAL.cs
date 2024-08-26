using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using System.Runtime.InteropServices;

namespace FablabCatalagoVirtualCapasDAL
{
	/// <summary>
	/// Clase que maneja el acceso a datos para los usuarios en la base de datos.
	/// </summary>
	public class UserDAL
	{
		/// <summary>
		/// Agrega un nuevo usuario a la base de datos.
		/// </summary>
		/// <param name="pUser">Objeto <see cref="User"/> que representa el usuario a agregar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int GuardarNuevoUser(User pUser)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAgregarUsuarios";
			cmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
			cmd.Parameters.AddWithValue("@Pasword", pUser.Password);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina un usuario de la base de datos.
		/// </summary>
		/// <param name="pUser">Objeto <see cref="User"/> que representa el usuario a eliminar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int EliminarUsuario(User pUser)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarUsuarios";
			cmd.Parameters.AddWithValue("@Id", pUser.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Actualiza la información de un usuario en la base de datos.
		/// </summary>
		/// <param name="pUser">Objeto <see cref="User"/> que representa el usuario a actualizar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int ActualizarUsuarios(User pUser)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActualizarUsuarios";
			cmd.Parameters.AddWithValue("@Id", pUser.Id);
			cmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
			cmd.Parameters.AddWithValue("@Pasword", pUser.Password);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Recupera una lista de todos los usuarios desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="User"/> que representan los usuarios obtenidos.</returns>
		public List<User> RegresarLista()
		{
			List<User> listUsers = new List<User>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerTodoUsuarios";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				User usuarios = new User
				{
					Id = reader.GetInt32(0),
					Usuario = reader.GetString(1),
					Password = reader.GetString(2)
				};
				listUsers.Add(usuarios);
			}
			return listUsers;
		}

		/// <summary>
		/// Autentica a un usuario en la base de datos.
		/// </summary>
		/// <param name="pUser">Objeto <see cref="User"/> que representa el usuario que intenta iniciar sesión.</param>
		/// <returns>Un objeto <see cref="User"/> con la información del usuario autenticado, o un objeto vacío si la autenticación falla.</returns>
		public User Logearse(User pUser)
		{
			User regresar = new User();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPLogin";
			cmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
			cmd.Parameters.AddWithValue("@Contra", pUser.Password);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				regresar = new User
				{
					Id = reader.GetInt32(0),
					Usuario = reader.GetString(1),
					Password = reader.GetString(2)
				};
			}
			return regresar;
		}
	}


}

