using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class CompraMateBL
	{
		CompraMateDAl CompraDAl = new CompraMateDAl();
		public int GuardarCompra(CompraMate pComra)
		{
			return CompraDAl.GuardarCompra(pComra);
		}
	}
}
