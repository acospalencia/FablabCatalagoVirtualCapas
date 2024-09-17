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
	/// Clase que maneja la lógica de negocio relacionada con las compras de materiales.
	/// </summary>
	public class CompraMateBL
	{
		// Instancia de la capa de acceso a datos para compras de materiales.
		CompraMateDAL CompraDAl = new CompraMateDAL();

		/// <summary>
		/// Guarda una nueva compra de material en la base de datos.
		/// </summary>
		/// <param name="pComra">Instancia del objeto CompraMate a guardar.</param>
		/// <returns>El identificador de la compra guardada.</returns>
		public int GuardarCompra(CompraMate pComra)
		{
			return CompraDAl.GuardarCompra(pComra);
		}

		/// <summary>
		/// Obtiene la lista completa de compras de materiales desde la base de datos.
		/// </summary>
		/// <returns>Lista de compras de materiales.</returns>
		public List<CompraMate> RegresarLista()
		{
			return CompraDAl.RegresarLista();
		}

		/// <summary>
		/// Modifica los datos de una compra de material existente en la base de datos.
		/// </summary>
		/// <param name="pComra">Instancia del objeto CompraMate con los datos modificados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModificarCompra(CompraMate pComra)
		{
			return CompraDAl.ModificarCompra(pComra);
		}

		/// <summary>
		/// Elimina una compra de material de la base de datos.
		/// </summary>
		/// <param name="pComra">Instancia del objeto CompraMate a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarCompra(CompraMate pComra)
		{
			return CompraDAl.DeleteCompra(pComra);
		}
	}

}
