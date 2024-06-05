using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasDAL
{
	public class ComunBD
	{
		const string strConexion = @"Data Source=DESKTOP-0H8BTTE;Initial Catalog=FablabBD;Integrated Security=True;Trust Server Certificate=True";

		private static SqlConnection obtenerconec()
		{
			SqlConnection conn = new SqlConnection(strConexion);
			conn.Open();
			return conn;
		}

		public static SqlCommand ObtenerComan()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = obtenerconec();
			return cmd;
		}

		public static int EjecutarComand(SqlCommand pComando)
		{
			int resultado = pComando.ExecuteNonQuery();
			pComando.Connection.Close();
			return resultado;
		}

		public static SqlDataReader EjecutarReader(SqlCommand pComando)
		{
			SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
			return reader;
		}

	}
}
