using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class ClubBL
	{
		ClubDAL clubBl = new ClubDAL();
		public int GuardarClub(Club pClub)
		{
			return clubBl.GuardarClub(pClub);
		}
	}
}
