using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los tipos de material.
	/// </summary>
	public class TipoMaterialBL
	{
		// Instancia de la capa de acceso a datos para los tipos de material.
		TipoMaterialDAL TipoBL = new TipoMaterialDAL();

		/// <summary>
		/// Obtiene la lista completa de tipos de material desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos TipoMaterial.</returns>
		public List<TipoMaterial> regresarTipoMaterial()
		{
			return TipoBL.RegresarListaTipo();
		}

		/// <summary>
		/// Muestra los detalles de un tipo de material específico según su identificador.
		/// </summary>
		/// <param name="Id">El identificador del tipo de material a mostrar.</param>
		/// <returns>Una instancia del objeto TipoMaterial con los detalles del tipo de material solicitado.</returns>
		public TipoMaterial MostrarPorIdTipo(int Id)
		{
			return TipoBL.MostrarPorIdTipo(Id);
		}
	}

}
