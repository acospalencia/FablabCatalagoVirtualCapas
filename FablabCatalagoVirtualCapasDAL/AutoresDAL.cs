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
	public class AutoresDAL
	{
		public List<Autores> RegresarLista()
		{
			List<Autores> ListaAutores = new List<Autores>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaAutores";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Autores Autores = new Autores();
				Autores.Id = reader.GetInt32(0);
				Autores.Nombres = reader.GetString(1);
				Autores.Apellidos = reader.GetString(2);
				Autores.CorreElectronico = reader.GetString(3);
				Autores.FechaRegistro = reader.GetDateTime(4);

				ListaAutores.Add(Autores);
			}
			return ListaAutores;
		}
		public int GuardarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAggAutor";
			cmd.Parameters.AddWithValue("@Nombres", pAutor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pAutor.Apellidos);
			cmd.Parameters.AddWithValue("@CorreElectronico", pAutor.CorreElectronico);
			cmd.Parameters.AddWithValue("@FechaRegistro", pAutor.FechaRegistro);
			return ComunBD.EjecutarComand(cmd);
		}
		public int ModificarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPModiAutor";
			cmd.Parameters.AddWithValue("@Id", pAutor.Id);
			cmd.Parameters.AddWithValue("@Nombres", pAutor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pAutor.Apellidos);
			cmd.Parameters.AddWithValue("@CorreElectronico", pAutor.CorreElectronico);
			cmd.Parameters.AddWithValue("@FechaRegistro", pAutor.FechaRegistro);
			return ComunBD.EjecutarComand(cmd);
		}
		public int EliminarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarAutor";
			cmd.Parameters.AddWithValue("@Id", pAutor.Id);
			return ComunBD.EjecutarComand(cmd);
		}
	}
}
