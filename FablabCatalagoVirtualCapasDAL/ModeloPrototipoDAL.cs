using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using FablabCatalagoVirtualCapasEN;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasDAL
{
	public class ModeloPrototipoDAL
	{
		public List<ModeloPrototipo> RegresarListaModelo()
		{
			List<ModeloPrototipo> lista = new List<ModeloPrototipo>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarProto";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				ModeloPrototipo ModeloProto = new ModeloPrototipo();
				ModeloProto.Nombre = reader.GetString(0);
				ModeloProto.MaterialUsado = reader.GetString(1);
				ModeloProto.MaquinariaUsada = reader.GetString(2);
				ModeloProto.Estado = reader.GetString(3);
				lista.Add(ModeloProto);
			}
			return lista;

		}
	}
}
