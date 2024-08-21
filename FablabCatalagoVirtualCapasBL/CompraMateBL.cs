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
		public List<CompraMate> RegresarLista()
		{
			return CompraDAl.RegresarLista();
		}
		public int ModificarCompra(CompraMate pComra)
		{
			return CompraDAl.ModificarCompra(pComra);
		}
		public int EliminarCompra(CompraMate pComra)
		{
			return CompraDAl.DeleteCompra(pComra);
		}
	}
}
