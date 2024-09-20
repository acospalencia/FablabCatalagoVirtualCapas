using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los estados.
	/// </summary>
	public class EstadosBL
	{
		// Instancia de la capa de acceso a datos para los estados.
		EstadosDAL EstadosDal = new EstadosDAL();

		/// <summary>
		/// Obtiene una lista de los estados asociados a los prototipos.
		/// </summary>
		/// <returns>Lista de estados para prototipos.</returns>
		public List<Estados> RegresarEstadosPrototipos()
		{
			return EstadosDal.RegresarEstadosPrototipos();
		}

		/// <summary>
		/// Muestra los detalles de un estado específico según su identificador.
		/// </summary>
		/// <param name="Id">El identificador del estado a mostrar.</param>
		/// <returns>Una instancia del objeto Estados con los detalles del estado solicitado.</returns>
		public Estados MostrarPorIdEstados(int Id)
		{
			return EstadosDal.MostrarPorIdEstados(Id);
		}

		/// <summary>
		/// Obtiene una lista de los estados asociados a las maquinarias.
		/// </summary>
		/// <returns>Lista de estados para maquinarias.</returns>
		public List<Estados> RegresarEstadosMaquinarias()
		{
			return EstadosDal.RegresarEstadosMaquinarias();
		}
	}

}
