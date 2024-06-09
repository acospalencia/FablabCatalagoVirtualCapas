using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
	public class MaquinariaBL
	{
		MaquinariaDAL maquinariaDAL = new MaquinariaDAL();
		public List<Maquinaria> MaquinariaList()
		{
			return maquinariaDAL.RegresarMaquinaria();
		}
	}
}
