using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasDAL
{
	public class UserDAL
	{
		private static List<User> listUsers = new List<User>()
		{
			new User {Name = "", Password = ""},
			new User {Name = "Carlos", Password = "loco1245"}
		};
		
		public void guardarNuevoUser(User pUser)
		{
			listUsers.Add(pUser);
		}
		public void eliminarUsuario (User pUser)
		{
			listUsers.Remove(pUser);
		}
		public List<User> regresarLista()
		{
			return listUsers;
		}
	}
}
