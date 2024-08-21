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
	public class ReporteDAL
	{
		public List<Reporte> RegresarLista()
		{
			List<Reporte> ListaClubs = new List<Reporte>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPReporte";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Reporte Club = new Reporte();
				Club.Autor = reader.GetString(0);
				Club.CantidadPrototipos = reader.GetInt32(1);

				ListaClubs.Add(Club);
			}
			return ListaClubs;
		}
	}
}
