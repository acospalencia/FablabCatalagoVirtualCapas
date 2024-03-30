using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
	public class UserBL
	{
		private UserDAL UserDAL = new UserDAL();
		public void GuardarUser (User pUser)
		{
			UserDAL.guardarNuevoUser(pUser);
		}
		public void EliminarUsuario (User pUser)
		{
			UserDAL.eliminarUsuario(pUser);
		}
		public List<User> regresarLista()
		{
			return UserDAL.regresarLista();
		}
	}
}
