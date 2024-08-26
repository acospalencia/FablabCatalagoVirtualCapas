using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasDAL
{
	/// <summary>
	/// Clase que maneja el acceso a datos para la maquinaria en la base de datos.
	/// </summary>
	public class MaquinariaDAL
	{
		/// <summary>
		/// Recupera una lista de todas las maquinarias desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Maquinaria"/> que representan las maquinarias.</returns>
		public List<Maquinaria> RegresarMaquinaria()
		{
			List<Maquinaria> ListaMaquinaria = new List<Maquinaria>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarMaquinaria";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Maquinaria maquinaria = new Maquinaria();
				maquinaria.Id = reader.GetInt32(0);
				maquinaria.Nombre = reader.GetString(1);
				maquinaria.Marca = reader.GetString(2);
				maquinaria.Detalle = reader.GetString(3);
				maquinaria.Idestado = reader.GetInt32(4);
				ListaMaquinaria.Add(maquinaria);
			}
			return ListaMaquinaria;
		}

		/// <summary>
		/// Recupera una maquinaria por su identificador desde la base de datos.
		/// </summary>
		/// <param name="Id">El identificador de la maquinaria a recuperar.</param>
		/// <returns>Un objeto de tipo <see cref="Maquinaria"/> que representa la maquinaria.</returns>
		public Maquinaria MostrarPorIdMaquinaria(int Id)
		{
			var Regresar = new Maquinaria();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdMaquinaria";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Maquinaria maquinaria = new Maquinaria();
				maquinaria.Id = reader.GetInt32(0);
				maquinaria.Nombre = reader.GetString(1);
				maquinaria.Marca = reader.GetString(2);
				maquinaria.Detalle = reader.GetString(3);
				maquinaria.Idestado = reader.GetInt32(4);
				Regresar = maquinaria;
			}
			return Regresar;
		}

		/// <summary>
		/// Guarda una nueva maquinaria en la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Objeto de tipo <see cref="Maquinaria"/> que contiene los datos de la maquinaria.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int GuardarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAggMaquinaria";
			cmd.Parameters.AddWithValue("@Nombre", pMaquinaria.Nombre);
			cmd.Parameters.AddWithValue("@Marca", pMaquinaria.Marca);
			cmd.Parameters.AddWithValue("@Detalle", pMaquinaria.Detalle);
			cmd.Parameters.AddWithValue("@IdEstado", pMaquinaria.Idestado);

			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Actualiza una maquinaria existente en la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Objeto de tipo <see cref="Maquinaria"/> con los datos actualizados de la maquinaria.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int ActualizarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActuMaquinaria";
			cmd.Parameters.AddWithValue("@Id", pMaquinaria.Id);
			cmd.Parameters.AddWithValue("@Nombre", pMaquinaria.Nombre);
			cmd.Parameters.AddWithValue("@Marca", pMaquinaria.Marca);
			cmd.Parameters.AddWithValue("@Detalle", pMaquinaria.Detalle);
			cmd.Parameters.AddWithValue("@IdEstado", pMaquinaria.Idestado);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina una maquinaria de la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Objeto de tipo <see cref="Maquinaria"/> que representa la maquinaria a eliminar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int EliminarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarMaquinaria";
			cmd.Parameters.AddWithValue("@Id", pMaquinaria.Id);
			return ComunBD.EjecutarComand(cmd);
		}
	}

}
