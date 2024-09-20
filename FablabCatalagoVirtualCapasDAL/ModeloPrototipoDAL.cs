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
	/// <summary>
	/// Clase que maneja el acceso a datos para los modelos de prototipo en la base de datos.
	/// </summary>
	public class ModeloPrototipoDAL
	{
		/// <summary>
		/// Recupera una lista de modelos de prototipo desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="ModeloPrototipo"/> que representan los modelos de prototipo.</returns>
		public List<ModeloPrototipo> RegresarListaModelo()
		{
			List<ModeloPrototipo> lista = new List<ModeloPrototipo>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarProto";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				ModeloPrototipo ModeloProto = new ModeloPrototipo
				{
					Nombre = reader.GetString(0),
					MaterialUsado = reader.GetString(1),
					MaquinariaUsada = reader.GetString(2),
					Estado = reader.GetString(3)
				};
				lista.Add(ModeloProto);
			}
			return lista;
		}
	}

}
