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
	public class UserBL
	{
		private UserDAL UserDAL = new UserDAL();
		public int GuardarUser (User pUser)
		{
			return UserDAL.GuardarNuevoUser(pUser);
		}
		public int EliminarUsuario (User pUser)
		{
			return UserDAL.EliminarUsuario(pUser);
		}
		public int ModificarUsuario (User pUser)
		{
			return UserDAL.ActualizarUsuarios(pUser);
		}
		public List<User> regresarLista()
		{
			return UserDAL.RegresarLista();
		}
		public User Login(User pUser)
		{
			return UserDAL.Logearse(pUser);
		}
	}
}
