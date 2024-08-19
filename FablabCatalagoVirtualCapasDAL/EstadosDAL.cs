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
		public Estados MostrarPorIdEstados(int Id)
		{
			var regresar = new Estados();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdEstados";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Estados Estados = new Estados();
				Estados.Id = reader.GetInt32(0);
				Estados.NombreEstado = reader.GetString(1);
				Estados.Detalle = reader.GetString(2);
				regresar = Estados;
			}
			return regresar;
		}
		public List<Estados> RegresarEstadosMaquinarias()
		{
			List<Estados> ListaEstados = new List<Estados>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaEstados";
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
