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
	public class SolicitudProyectosDAL
	{
		public int GuardarSoli(SolicitudProyectos pSoli)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spAggSoliProyecto";
			cmd.Parameters.AddWithValue("@TipoProyecto", pSoli.TipoProyecto);
			cmd.Parameters.AddWithValue("@Descripcion", pSoli.Descripcion);
			cmd.Parameters.AddWithValue("@Integrantes", pSoli.Integrantes);
			cmd.Parameters.AddWithValue("@Fecha", pSoli.Fecha);
			cmd.Parameters.AddWithValue("@IdAutor", pSoli.IdAutor);
			return ComunBD.EjecutarComand(cmd);
		}

		public int ModificarAprobacion(SolicitudProyectos pSoli)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spModiSoliAprobacion";
			cmd.Parameters.AddWithValue("@Id", pSoli.Id);
			cmd.Parameters.AddWithValue("@Aprovado", pSoli.Aprovado);
			return ComunBD.EjecutarComand(cmd);
		}

		public int ModificarSoli(SolicitudProyectos pSoli)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spModiSoliProyecto";
			cmd.Parameters.AddWithValue("@Id", pSoli.Id);
			cmd.Parameters.AddWithValue("@TipoProyecto", pSoli.TipoProyecto);
			cmd.Parameters.AddWithValue("@Descripcion", pSoli.Descripcion);
			cmd.Parameters.AddWithValue("@Integrantes", pSoli.Integrantes);
			cmd.Parameters.AddWithValue("@Fecha", pSoli.Fecha);
			cmd.Parameters.AddWithValue("@IdAutor", pSoli.IdAutor);
			return ComunBD.EjecutarComand(cmd);
		}

		public int DeleteSoli(SolicitudProyectos pSoli)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spDelSoliProyecto";
			cmd.Parameters.AddWithValue("@Id", pSoli.Id);
			
			return ComunBD.EjecutarComand(cmd);
		}

		public List<SolicitudProyectos> RegresarLista()
		{
			List<SolicitudProyectos> ListaSolis = new List<SolicitudProyectos>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spShowSoliProyecto";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				SolicitudProyectos club = new SolicitudProyectos
				{
					Id = reader.GetInt32(0),
					TipoProyecto = reader.GetString(1),
					Descripcion	 = reader.GetString(2),
					Integrantes = reader.GetInt32(3),
					Fecha = reader.GetDateTime(4),
					Aprovado = reader.GetBoolean(5),
					IdAutor = reader.GetInt32(6)
				};

				ListaSolis.Add(club);
			}
			return ListaSolis;
		}
		public SolicitudProyectos MostrarInfo(SolicitudProyectos pSoli)
		{
			var test = new SolicitudProyectos();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarInfoSoli";
			cmd.Parameters.AddWithValue("@Id", pSoli.Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				SolicitudProyectos Solicitud = new SolicitudProyectos
				{
					Id = reader.GetInt32(0),
					TipoProyecto = reader.GetString(1),
					Descripcion = reader.GetString(2),
					Integrantes = reader.GetInt32(3),
					Fecha = reader.GetDateTime(4),
					Aprovado = reader.GetBoolean(5),
					IdAutor = reader.GetInt32(6)

				};

				test = Solicitud;
			}
			return test;
		}
	}
}
