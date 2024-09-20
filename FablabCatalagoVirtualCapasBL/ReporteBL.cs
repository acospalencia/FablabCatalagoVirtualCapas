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
	/// Clase que maneja la lógica de negocio relacionada con los reportes.
	/// </summary>
	public class ReporteBL
	{
		// Instancia de la capa de acceso a datos para los reportes.
		ReporteDAL reporte = new ReporteDAL();

		/// <summary>
		/// Obtiene la lista completa de reportes desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos Reporte.</returns>
		public List<Reporte> RegresarLista()
		{
			return reporte.RegresarLista();
		}
	}

}
