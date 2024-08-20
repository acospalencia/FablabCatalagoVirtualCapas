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

	public class PrototipoDAL
	{
		//metodo para agregar un nuevo prototipo a la lista
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
		//metodo para modificar un prototipo en la lista
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
			//cmd.Parameters.AddWithValue("@Imagen", pPrototipo.Imagen);
			cmd.Parameters.AddWithValue("@IdDuracion", pPrototipo.IdDuracion);
			cmd.Parameters.AddWithValue("@IdEstado", pPrototipo.IdEstado);
			cmd.Parameters.AddWithValue("@IdMaquinaria", pPrototipo.IdMaquinaria);
			return ComunBD.EjecutarComand(cmd);
		}
		//Metodo para eliminar un prototipo de la lista 
		public int EliminarPrototipo(Prototipo pPrototipo)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarPrototipo";
			cmd.Parameters.AddWithValue("@Id", pPrototipo.Id);
			return ComunBD.EjecutarComand(cmd);
		}
		//metodo para regresar la lista
		public List<Prototipo> RegresarLista()
		{
			List<Prototipo> lista = new List<Prototipo>();//-- definicion de lista 
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
	}
}
