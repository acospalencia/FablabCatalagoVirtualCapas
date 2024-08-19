using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class AutoresBL
	{
		AutoresDAL proveedorDAL = new AutoresDAL();
		public int GuardarAutor(Autores pAutor)
		{
			return proveedorDAL.GuardarAutor(pAutor);
		}
		public List<Autores> RegresarLista()
		{
			return proveedorDAL.RegresarLista();
		}
		public int ModificarAutor(Autores pAutor)
		{
			return proveedorDAL.ModificarAutor(pAutor);
		}
		public int EliminarAutor(Autores pAutor)
		{
			return proveedorDAL.EliminarAutor(pAutor);
		}
	}
}
