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
	/// Clase que maneja la capa de acceso a datos para los autores.
	/// </summary>
	public class AutoresDAL
	{
		/// <summary>
		/// Obtiene la lista completa de autores desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos Autores.</returns>
		public List<Autores> RegresarLista()
		{
			List<Autores> ListaAutores = new List<Autores>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaAutores";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Autores autor = new Autores
				{
					Id = reader.GetInt32(0),
					Nombres = reader.GetString(1),
					Apellidos = reader.GetString(2),
					CorreElectronico = reader.GetString(3),
					Password = reader.GetString(4),
					FechaRegistro = reader.GetDateTime(5)
				};

				ListaAutores.Add(autor);
			}
			return ListaAutores;
		}

		/// <summary>
		/// Guarda un nuevo autor en la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autores a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAggAutor";
			cmd.Parameters.AddWithValue("@Nombres", pAutor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pAutor.Apellidos);
			cmd.Parameters.AddWithValue("@CorreElectronico", pAutor.CorreElectronico);
			cmd.Parameters.AddWithValue("@FechaRegistro", pAutor.FechaRegistro);
			cmd.Parameters.AddWithValue("@Contraseña", pAutor.Password);

			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Modifica un autor existente en la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autores con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
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

		/// <summary>
		/// Elimina un autor de la base de datos.
		/// </summary>
		/// <param name="pAutor">Instancia del objeto Autores a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarAutor";
			cmd.Parameters.AddWithValue("@Id", pAutor.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		public (bool, string) RegistrarAutor(Autores pAutor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spNewAutor";
			cmd.Parameters.AddWithValue("@Nombres", pAutor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pAutor.Apellidos);
			cmd.Parameters.AddWithValue("@CorreElectronico", pAutor.CorreElectronico);
			cmd.Parameters.AddWithValue("@FechaRegistro", pAutor.FechaRegistro);
			cmd.Parameters.AddWithValue("@Contraseña", pAutor.Password);
			cmd.Parameters.Add("@Registrado", SqlDbType.Bit).Direction = ParameterDirection.Output;
			cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;

			ComunBD.EjecutarComand(cmd);

			bool registrado = Convert.ToBoolean(cmd.Parameters["@Registrado"].Value);
			string mensaje = cmd.Parameters["@Mensaje"].Value.ToString();

			return (registrado, mensaje);
		}

		public Autores IniciarSesion(Autores pAutor)
		{
			Autores InfoAutor = new Autores();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spValidacion";
			cmd.Parameters.AddWithValue("@CorreElectronico", pAutor.CorreElectronico);
			cmd.Parameters.AddWithValue("@Contraseña", pAutor.Password);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Autores autor = new Autores
				{
					Id = reader.GetInt32(0),
					Nombres = reader.GetString(1),
					Apellidos = reader.GetString(2),
					CorreElectronico = reader.GetString(3),
					Password = reader.GetString(4),
					FechaRegistro = reader.GetDateTime(5)
				};
				InfoAutor = autor;

			}
			return InfoAutor;
		}
	}
}
