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
	public class ModeloProto2DAL
	{
		public ModeloProto2 MostrarInfo(Prototipo pPrototipo)
		{
			var test = new ModeloProto2();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarInfo";
			cmd.Parameters.AddWithValue("@NombrePrototipo", pPrototipo.NombrePrototipo);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				ModeloProto2 prototipo = new ModeloProto2
				{
					NombrePrototipo = reader.GetString(0),
					NombreMaterial = reader.GetString(1),
					X = reader.GetString(2),
					Y = reader.GetString(3),
					Z = reader.GetString(4),
					Descripcion = reader.GetString(5),
					TiempoArmado = reader.GetString(6),
					TiempoDiseno = reader.GetString(7),
					TiempoFabricado = reader.GetString(8),
					NombreEstado = reader.GetString(9),
					Nombre = reader.GetString(10),
				};

				if (!reader.IsDBNull(11))
				{
					long length = reader.GetBytes(11, 0, null, 0, 0);
					byte[] buffer = new byte[length];
					reader.GetBytes(11, 0, buffer, 0, (int)length);
					prototipo.Imagen = buffer;
				}

				test = prototipo;
			}
			return test;
		}
	}
}
