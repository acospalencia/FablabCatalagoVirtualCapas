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
	/// Clase que maneja la lógica de negocio relacionada con los autores.
	/// </summary>
	public class AutoresBL
	{
		// Instancia de la capa de acceso a datos para autores.
		AutoresDAL proveedorDAL = new AutoresDAL();

		/// <summary>
		/// Guarda un nuevo autor en la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autor a guardar.</param>
		/// <returns>El identificador del autor guardado.</returns>
		public int GuardarAutor(Autores pAutor)
		{
			return proveedorDAL.GuardarAutor(pAutor);
		}

		/// <summary>
		/// Obtiene la lista completa de autores desde la base de datos.
		/// </summary>
		/// <returns>Lista de autores.</returns>
		public List<Autores> RegresarLista()
		{
			return proveedorDAL.RegresarLista();
		}

		/// <summary>
		/// Modifica los datos de un autor existente en la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autor con los datos modificados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModificarAutor(Autores pAutor)
		{
			return proveedorDAL.ModificarAutor(pAutor);
		}

		/// <summary>
		/// Elimina un autor de la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autor a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarAutor(Autores pAutor)
		{
			return proveedorDAL.EliminarAutor(pAutor);
		}

		public (bool, string) RegistrarAutor(Autores pAutor)
		{
			return proveedorDAL.RegistrarAutor(pAutor);

		}
		public Autores IniciarSesion(Autores pAutor)
		{
			return proveedorDAL.IniciarSesion(pAutor);
		}
	}
}
