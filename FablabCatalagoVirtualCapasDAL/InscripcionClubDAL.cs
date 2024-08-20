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
	public class InscripcionClubDAL
	{
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
