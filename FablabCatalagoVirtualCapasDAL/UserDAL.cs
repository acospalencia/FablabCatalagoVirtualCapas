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
	public class UserDAL
	{
		public int GuardarNuevoUser(User pUser)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAgregarUsuarios";
			cmd.Parameters.AddWithValue("@Usuario", pUser.Usuario);
			cmd.Parameters.AddWithValue("@Pasword", pUser.Password);
			return ComunBD.EjecutarComand(cmd);
		}
		public int EliminarUsuario(User pUser)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarUsuarios";
			cmd.Parameters.AddWithValue("@Id", pUser.Id);
			return ComunBD.EjecutarComand(cmd);
		}
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
		public List<User> RegresarLista()
		{
			List<User> listUsers = new List<User>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerTodoUsuarios";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				User usuarios = new User();
				usuarios.Id = reader.GetInt32(0);
				usuarios.Usuario = reader.GetString(1);
				usuarios.Password = reader.GetString(2);
				listUsers.Add(usuarios);
			}
			return listUsers;
		}
			
	}
	
}

