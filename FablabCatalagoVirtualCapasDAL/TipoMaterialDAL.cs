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
	public class TipoMaterialDAL
	{
		public List<TipoMaterial> RegresarListaTipo()
		{
			List<TipoMaterial> lista = new List<TipoMaterial>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPRegresarTipoMaterial";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				TipoMaterial tipoMaterial = new TipoMaterial();
				tipoMaterial.Id = reader.GetInt32(0);
				tipoMaterial.NombreTipo = reader.GetString(1);
				tipoMaterial.Descripcion = reader.GetString(2);
				lista.Add(tipoMaterial);
			}
			return lista;
		}
		public TipoMaterial MostrarPorIdTipo(int Id)
		{
			var Regresar = new TipoMaterial();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarTipoId";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				TipoMaterial tipos = new TipoMaterial();
				tipos.Id = reader.GetInt32(0);
				tipos.NombreTipo = reader.GetString(1);
				tipos.Descripcion = reader.GetString(2);
				Regresar = tipos;
			}
			return Regresar;
		}
	}
}
