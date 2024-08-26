using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FablabCatalagoVirtualCapasEN;
using System.Data;
using System.Data.SqlClient;

namespace FablabCatalagoVirtualCapasDAL
{

	/// <summary>
	/// Clase que maneja el acceso a datos para los prototipos en la base de datos.
	/// </summary>
	public class PrototipoDAL
	{
		/// <summary>
		/// Agrega un nuevo prototipo a la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Objeto de tipo <see cref="Prototipo"/> que representa el prototipo a agregar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int guardarNuevoPrototipo(Prototipo pPrototipo)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spAgregarPrototipo";
			cmd.Parameters.AddWithValue("@NombrePrototipo", pPrototipo.NombrePrototipo);
			cmd.Parameters.AddWithValue("@IdMaterial", pPrototipo.IdMaterial);
			cmd.Parameters.AddWithValue("@X", pPrototipo.X);
			cmd.Parameters.AddWithValue("@Y", pPrototipo.Y);
			cmd.Parameters.AddWithValue("@Z", pPrototipo.Z);
			cmd.Parameters.AddWithValue("@Descripcion", pPrototipo.Descripcion);
			cmd.Parameters.AddWithValue("@Imagen", pPrototipo.Imagen);
			cmd.Parameters.AddWithValue("@IdDuracion", pPrototipo.IdDuracion);
			cmd.Parameters.AddWithValue("@IdEstado", pPrototipo.IdEstado);
			cmd.Parameters.AddWithValue("@IdMaquinaria", pPrototipo.IdMaquinaria);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Modifica un prototipo existente en la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Objeto de tipo <see cref="Prototipo"/> que representa el prototipo a modificar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModificarPrototipo(Prototipo pPrototipo)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spActualizarPrototipo";
			cmd.Parameters.AddWithValue("@Id", pPrototipo.Id);
			cmd.Parameters.AddWithValue("@NombrePrototipo", pPrototipo.NombrePrototipo);
			cmd.Parameters.AddWithValue("@IdMaterial", pPrototipo.IdMaterial);
			cmd.Parameters.AddWithValue("@X", pPrototipo.X);
			cmd.Parameters.AddWithValue("@Y", pPrototipo.Y);
			cmd.Parameters.AddWithValue("@Z", pPrototipo.Z);
			cmd.Parameters.AddWithValue("@Descripcion", pPrototipo.Descripcion);
			//cmd.Parameters.AddWithValue("@Imagen", pPrototipo.Imagen); // Imagen es opcional, no se actualiza en este método.
			cmd.Parameters.AddWithValue("@IdDuracion", pPrototipo.IdDuracion);
			cmd.Parameters.AddWithValue("@IdEstado", pPrototipo.IdEstado);
			cmd.Parameters.AddWithValue("@IdMaquinaria", pPrototipo.IdMaquinaria);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina un prototipo de la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Objeto de tipo <see cref="Prototipo"/> que representa el prototipo a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarPrototipo(Prototipo pPrototipo)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarPrototipo";
			cmd.Parameters.AddWithValue("@Id", pPrototipo.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Recupera una lista de todos los prototipos desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Prototipo"/> que representan todos los prototipos.</returns>
		public List<Prototipo> RegresarLista()
		{
			List<Prototipo> lista = new List<Prototipo>(); // Definición de la lista.
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerTodoPrototipos";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Prototipo prototipo = new Prototipo
				{
					Id = reader.GetInt32(0),
					NombrePrototipo = reader.GetString(1),
					IdMaterial = reader.GetInt32(2),
					X = reader.GetString(3),
					Y = reader.GetString(4),
					Z = reader.GetString(5),
					Descripcion = reader.GetString(6),
					IdDuracion = reader.GetInt32(8),
					IdEstado = reader.GetInt32(9),
					IdMaquinaria = reader.GetInt32(10)
				};
				if (!reader.IsDBNull(7))
				{
					long length = reader.GetBytes(7, 0, null, 0, 0);
					byte[] buffer = new byte[length];
					reader.GetBytes(7, 0, buffer, 0, (int)length);
					prototipo.Imagen = buffer;
				}

				lista.Add(prototipo);
			}
			return lista;
		}

		/// <summary>
		/// Recupera el último ID de prototipo generado en la base de datos.
		/// </summary>
		/// <returns>El ID del último prototipo.</returns>
		public int RegresarIdProto()
		{
			int Id = 0;
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPUltimoProto";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Id = reader.GetInt32(0);
			}
			return Id;
		}
	}

}
