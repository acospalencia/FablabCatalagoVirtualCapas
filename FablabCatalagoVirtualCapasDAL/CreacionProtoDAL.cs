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
	/// Clase que maneja la capa de acceso a datos para la creación de prototipos.
	/// </summary>
	public class CreacionProtoDAL
	{
		/// <summary>
		/// Guarda una nueva creación de prototipo en la base de datos.
		/// </summary>
		/// <param name="pCreac">Instancia del objeto CreacionProto a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarCreacion(CreacionProto pCreac)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAddCreacion";
			cmd.Parameters.AddWithValue("@IdAutorLider", pCreac.IdAutorLider);
			cmd.Parameters.AddWithValue("@IdPrototipo", pCreac.IdPrototipo);
			cmd.Parameters.AddWithValue("@IdUsuario", pCreac.IdUsuario);
			cmd.Parameters.AddWithValue("@FechaCreacion", pCreac.FechaCreacion);
			cmd.Parameters.AddWithValue("@NumeroAutoresEquipo", pCreac.NumeroAutoresEquipo);
			cmd.Parameters.AddWithValue("@Nombres", pCreac.Nombres);
			return ComunBD.EjecutarComand(cmd);
		}
	}

}
