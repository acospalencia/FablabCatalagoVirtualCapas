using FablabCatalagoVirtualCapasEN;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasDAL
{
	public class EstadosDAL
	{
		public List<Estados> RegresarEstadosPrototipos()
		{
			List<Estados> ListaEstados = new List<Estados>();
 			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarEstadosPrototipos";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read()) 
			{
				Estados estados = new Estados();
				estados.Id = reader.GetInt32(0);
				estados.NombreEstado = reader.GetString(1);
				estados.Detalle = reader.GetString(2);
				ListaEstados.Add(estados);
			}
			return ListaEstados;
		}
	}
}
