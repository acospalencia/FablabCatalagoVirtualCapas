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
	/// <summary>
	/// Clase que maneja el acceso a datos para los estados en la base de datos.
	/// </summary>
	public class EstadosDAL
	{
		/// <summary>
		/// Recupera la lista de estados de prototipos desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Estados"/> que representan los estados de prototipos.</returns>
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

		/// <summary>
		/// Recupera un estado específico basado en el identificador proporcionado.
		/// </summary>
		/// <param name="Id">El identificador del estado a recuperar.</param>
		/// <returns>Un objeto de tipo <see cref="Estados"/> con la información del estado correspondiente.</returns>
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
				Estados estados = new Estados();
				estados.Id = reader.GetInt32(0);
				estados.NombreEstado = reader.GetString(1);
				estados.Detalle = reader.GetString(2);
				regresar = estados;
			}
			return regresar;
		}

		/// <summary>
		/// Recupera la lista de estados de maquinarias desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Estados"/> que representan los estados de maquinarias.</returns>
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
