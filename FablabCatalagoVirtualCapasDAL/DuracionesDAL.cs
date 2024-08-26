using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasDAL
{
	/// <summary>
	/// Clase que maneja el acceso a datos para las duraciones de los procesos en la base de datos.
	/// </summary>
	public class DuracionesDAL
	{
		/// <summary>
		/// Guarda una nueva duración en la base de datos.
		/// </summary>
		/// <param name="pDuraciones">Instancia del objeto Duraciones que contiene la información de la duración a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarDuraciones(Duraciones pDuraciones)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPGuardarDuracion";
			cmd.Parameters.AddWithValue("@TiempoDiseno", pDuraciones.TiempoDiseno);
			cmd.Parameters.AddWithValue("@TiempoFabricado", pDuraciones.TiempoFabricado);
			cmd.Parameters.AddWithValue("@TiempoArmado", pDuraciones.TiempoArmado);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Actualiza las duraciones existentes en la base de datos.
		/// </summary>
		/// <param name="pDuraciones">Instancia del objeto Duraciones que contiene la información actualizada de la duración.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ActualizarDuraciones(Duraciones pDuraciones)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActualizarDuraciones";
			cmd.Parameters.AddWithValue("@id", pDuraciones.Id);
			cmd.Parameters.AddWithValue("@Disenado", pDuraciones.TiempoDiseno);
			cmd.Parameters.AddWithValue("@Fabricado", pDuraciones.TiempoFabricado);
			cmd.Parameters.AddWithValue("@Armado", pDuraciones.TiempoArmado);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Obtiene el último identificador registrado en la base de datos.
		/// </summary>
		/// <returns>El último identificador registrado.</returns>
		public int RegresarId()
		{
			int Id = 0;
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerUltimoId";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Id = reader.GetInt32(0);
			}
			return Id;
		}

		/// <summary>
		/// Muestra la información de duraciones basándose en el identificador proporcionado.
		/// </summary>
		/// <param name="Id">Identificador de la duración a recuperar.</param>
		/// <returns>Una instancia del objeto Duraciones con la información recuperada.</returns>
		public Duraciones MostrarPorIdDuraciones(int Id)
		{
			var test = new Duraciones();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdDuraciones";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Duraciones duraciones = new Duraciones();
				duraciones.Id = reader.GetInt32(0);
				duraciones.TiempoDiseno = reader.GetString(1);
				duraciones.TiempoFabricado = reader.GetString(2);
				duraciones.TiempoArmado = reader.GetString(3);
				test = duraciones;
			}
			return test;
		}
	}

}
