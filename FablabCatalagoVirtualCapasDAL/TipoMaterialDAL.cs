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
	/// Clase que maneja el acceso a datos para los tipos de material en la base de datos.
	/// </summary>
	public class TipoMaterialDAL
	{
		/// <summary>
		/// Recupera una lista de tipos de material desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="TipoMaterial"/> que representan los tipos de material obtenidos.</returns>
		public List<TipoMaterial> RegresarListaTipo()
		{
			List<TipoMaterial> lista = new List<TipoMaterial>(); // Definición de la lista.
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPRegresarTipoMaterial";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				TipoMaterial tipoMaterial = new TipoMaterial
				{
					Id = reader.GetInt32(0),
					NombreTipo = reader.GetString(1),
					Descripcion = reader.GetString(2)
				};
				lista.Add(tipoMaterial);
			}
			return lista;
		}

		/// <summary>
		/// Recupera un tipo de material específico desde la base de datos utilizando su ID.
		/// </summary>
		/// <param name="Id">El ID del tipo de material a recuperar.</param>
		/// <returns>Un objeto de tipo <see cref="TipoMaterial"/> que representa el tipo de material obtenido.</returns>
		public TipoMaterial MostrarPorIdTipo(int Id)
		{
			TipoMaterial Regresar = new TipoMaterial(); // Instancia del objeto TipoMaterial.
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarTipoId";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				TipoMaterial tipos = new TipoMaterial
				{
					Id = reader.GetInt32(0),
					NombreTipo = reader.GetString(1),
					Descripcion = reader.GetString(2)
				};
				Regresar = tipos;
			}
			return Regresar;
		}
	}

}
