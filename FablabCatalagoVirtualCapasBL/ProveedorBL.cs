using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los proveedores.
	/// </summary>
	public class ProveedorBL
	{
		// Instancia de la capa de acceso a datos para los proveedores.
		ProveedorDAL proveedorDAL = new ProveedorDAL();

		/// <summary>
		/// Guarda un nuevo proveedor en la base de datos.
		/// </summary>
		/// <param name="pProveedor">Instancia del objeto Proveedor a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarProveedor(Proveedor pProveedor)
		{
			return proveedorDAL.GuardarProveedor(pProveedor);
		}

		/// <summary>
		/// Obtiene la lista completa de proveedores desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos Proveedor.</returns>
		public List<Proveedor> RegresarLista()
		{
			return proveedorDAL.RegresarLista();
		}

		/// <summary>
		/// Actualiza los datos de un proveedor existente en la base de datos.
		/// </summary>
		/// <param name="pProveedor">Instancia del objeto Proveedor con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ActualizarProveedores(Proveedor pProveedor)
		{
			return proveedorDAL.ActualizarProveedores(pProveedor);
		}

		/// <summary>
		/// Elimina un proveedor de la base de datos.
		/// </summary>
		/// <param name="pProveedor">Instancia del objeto Proveedor a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarProveedor(Proveedor pProveedor)
		{
			return proveedorDAL.EliminarProveedor(pProveedor);
		}
	}

}
