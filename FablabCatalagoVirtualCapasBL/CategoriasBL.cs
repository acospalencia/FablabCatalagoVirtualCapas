using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;


namespace FablabCatalagoVirtualCapasBL
{
	public class CategoriasBL
	{
		CategoriasDAL catDAL = new CategoriasDAL();

		public List<Categorias> ListaCatego ()
		{
			return catDAL.Categorias();
		}
	}
}
