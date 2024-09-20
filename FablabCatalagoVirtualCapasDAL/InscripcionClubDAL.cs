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
	/// Clase que maneja el acceso a datos para las inscripciones en clubes en la base de datos.
	/// </summary>
	public class InscripcionClubDAL
	{
		/// <summary>
		/// Guarda una nueva inscripción en el club en la base de datos.
		/// </summary>
		/// <param name="pInscr">Objeto de tipo <see cref="InscripcionClub"/> que contiene los datos de la inscripción.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int GuardarInscripcion(InscripcionClub pInscr)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAddInscripcion";
			cmd.Parameters.AddWithValue("@IdAutor", pInscr.IdAutor);
			cmd.Parameters.AddWithValue("@IdClub", pInscr.IdClub);
			cmd.Parameters.AddWithValue("@FechaInscripcion", pInscr.FechaInscripcion);
			cmd.Parameters.AddWithValue("@Detalle", pInscr.Detalle);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Recupera una lista de todas las inscripciones en clubes desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="InscripcionClub"/> que representan las inscripciones en clubes.</returns>
		public List<InscripcionClub> RegresarLista()
		{
			List<InscripcionClub> ListaInscripcion = new List<InscripcionClub>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaInscripcion";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				InscripcionClub Club = new InscripcionClub();
				Club.Id = reader.GetInt32(0);
				Club.IdAutor = reader.GetInt32(1);
				Club.IdClub = reader.GetInt32(2);
				Club.FechaInscripcion = reader.GetDateTime(3);
				Club.Detalle = reader.GetString(4);

				ListaInscripcion.Add(Club);
			}
			return ListaInscripcion;
		}

		/// <summary>
		/// Modifica una inscripción existente en el club en la base de datos.
		/// </summary>
		/// <param name="pInscr">Objeto de tipo <see cref="InscripcionClub"/> con los datos actualizados de la inscripción.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int ModificarInscripcion(InscripcionClub pInscr)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPModiInscripcion";
			cmd.Parameters.AddWithValue("@Id", pInscr.Id);
			cmd.Parameters.AddWithValue("@IdAutor", pInscr.IdAutor);
			cmd.Parameters.AddWithValue("@IdClub", pInscr.IdClub);
			cmd.Parameters.AddWithValue("@FechaInscripcion", pInscr.FechaInscripcion);
			cmd.Parameters.AddWithValue("@Detalle", pInscr.Detalle);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina una inscripción del club en la base de datos.
		/// </summary>
		/// <param name="pInscr">Objeto de tipo <see cref="InscripcionClub"/> que representa la inscripción a eliminar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int EliminarInscripcion(InscripcionClub pInscr)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPDeleteInscripcion";
			cmd.Parameters.AddWithValue("@Id", pInscr.Id);
			return ComunBD.EjecutarComand(cmd);
		}
	}

}
