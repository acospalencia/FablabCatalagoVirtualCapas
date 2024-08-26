using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasDAL
{
	/// <summary>
	/// Clase que maneja el acceso a datos para los reportes en la base de datos.
	/// </summary>
	public class ReporteDAL
	{
		/// <summary>
		/// Recupera una lista de reportes desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Reporte"/> que representan los reportes obtenidos.</returns>
		public List<Reporte> RegresarLista()
		{
			List<Reporte> ListaClubs = new List<Reporte>(); // Definición de la lista.
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPReporte";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Reporte reporte = new Reporte
				{
					Autor = reader.GetString(0),
					CantidadPrototipos = reader.GetInt32(1)
				};

				ListaClubs.Add(reporte);
			}
			return ListaClubs;
		}
	}

}
