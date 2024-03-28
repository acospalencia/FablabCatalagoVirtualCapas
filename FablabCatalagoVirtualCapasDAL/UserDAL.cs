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
			new User {Name = "Ulises", Password = "12345"}
		};
		
		public void guardarNuevoUser(User pUser)
		{
			listUsers.Add(pUser);
		}
		public void eliminarUsuario (User pUser)
		{
			listUsers.Remove(pUser);
		}
	}
}
