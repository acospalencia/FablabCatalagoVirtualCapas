using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class ProveedorBL
	{
		ProveedorDAL proveedorDAL = new ProveedorDAL();
		public int GuardarProveedor(Proveedor pProveedor)
		{
			return proveedorDAL.GuardarProveedor(pProveedor);
		}
		public List<Proveedor> RegresarLista()
		{
			return proveedorDAL.RegresarLista();
		}
		public int ActualizarProveedores(Proveedor pProveedor)
		{
			return proveedorDAL.ActualizarProveedores(pProveedor);
		}
		public int EliminarProveedor(Proveedor pProveedor)
		{
			return proveedorDAL.EliminarProveedor(pProveedor);
		}
	}
}
