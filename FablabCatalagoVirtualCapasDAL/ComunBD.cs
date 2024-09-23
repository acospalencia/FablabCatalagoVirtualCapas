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
	/// Clase que proporciona métodos comunes para la gestión de conexiones y comandos SQL en la base de datos.
	/// </summary>
	public class ComunBD
	{
		// Cadena de conexión a la base de datos
		const string strConexion = @"Data Source=DESKTOP-0H8BTTE;Initial Catalog=FablabBD;Integrated Security=True";


		/// <summary>
		/// Obtiene una nueva conexión a la base de datos y la abre.
		/// </summary>
		/// <returns>Una instancia de SqlConnection abierta.</returns>
		private static SqlConnection obtenerconec()
		{
			SqlConnection conn = new SqlConnection(strConexion);
			conn.Open();
			return conn;
		}

		/// <summary>
		/// Crea y devuelve un nuevo SqlCommand asociado a una conexión abierta a la base de datos.
		/// </summary>
		/// <returns>Una instancia de SqlCommand con una conexión abierta.</returns>
		public static SqlCommand ObtenerComan()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = obtenerconec();
			return cmd;
		}

		/// <summary>
		/// Ejecuta un comando SQL que no devuelve filas, como una instrucción INSERT, UPDATE o DELETE.
		/// </summary>
		/// <param name="pComando">El SqlCommand a ejecutar.</param>
		/// <returns>El número de filas afectadas por el comando.</returns>
		public static int EjecutarComand(SqlCommand pComando)
		{
			int resultado = pComando.ExecuteNonQuery();
			pComando.Connection.Close();
			return resultado;
		}

		/// <summary>
		/// Ejecuta un comando SQL que devuelve un conjunto de resultados, como una instrucción SELECT.
		/// </summary>
		/// <param name="pComando">El SqlCommand a ejecutar.</param>
		/// <returns>Un SqlDataReader que puede leer los datos devueltos por el comando.</returns>
		public static SqlDataReader EjecutarReader(SqlCommand pComando)
		{
			SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
			return reader;
		}
	}

}
