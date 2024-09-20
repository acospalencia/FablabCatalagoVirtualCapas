using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con las duraciones.
	/// </summary>
	public class DuracionesBL
	{
		// Instancia de la capa de acceso a datos para las duraciones.
		DuracionesDAL duracionesDAL = new DuracionesDAL();

		/// <summary>
		/// Guarda una nueva duración en la base de datos.
		/// </summary>
		/// <param name="pDuracion">Instancia del objeto Duraciones a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarDuracion(Duraciones pDuracion)
		{
			return duracionesDAL.GuardarDuraciones(pDuracion);
		}

		/// <summary>
		/// Actualiza una duración existente en la base de datos.
		/// </summary>
		/// <param name="pDuracion">Instancia del objeto Duraciones con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ActualizarDuraciones(Duraciones pDuracion)
		{
			return duracionesDAL.ActualizarDuraciones(pDuracion);
		}

		/// <summary>
		/// Obtiene el identificador de la última duración insertada en la base de datos.
		/// </summary>
		/// <returns>El identificador de la última duración insertada.</returns>
		public int RegresarId()
		{
			return duracionesDAL.RegresarId();
		}

		/// <summary>
		/// Muestra los detalles de una duración específica según su identificador.
		/// </summary>
		/// <param name="pDuracion">El identificador de la duración a mostrar.</param>
		/// <returns>Una instancia del objeto Duraciones con los detalles de la duración solicitada.</returns>
		public Duraciones MostrarPorIdDuraciones(int pDuracion)
		{
			return duracionesDAL.MostrarPorIdDuraciones(pDuracion);
		}
	}

}
