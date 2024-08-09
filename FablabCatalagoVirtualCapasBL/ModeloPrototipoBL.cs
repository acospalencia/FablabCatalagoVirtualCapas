using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;

namespace FablabCatalagoVirtualCapasBL
{
	public class ModeloPrototipoBL
	{
		ModeloPrototipoDAL modelo = new ModeloPrototipoDAL();
		public List<ModeloPrototipo> RegresarListaModelo()
		{
			return modelo.RegresarListaModelo();
		}
	}
}
