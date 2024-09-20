using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing.Imaging;

namespace FablabCatalagoVirtualCapasDAL
{
	/// <summary>
	/// Clase que maneja el acceso a datos para los materiales en la base de datos.
	/// </summary>
	public class MaterialesDAL
	{
		/// <summary>
		/// Recupera una lista de todos los materiales desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Materiales"/> que representan los materiales.</returns>
		public List<Materiales> regresarLista()
		{
			List<Materiales> lista = new List<Materiales>(); // Definición de lista
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerTodoMateriales";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Materiales material = new Materiales();
				material.Id = reader.GetInt32(0);
				material.NombreMaterial = reader.GetString(1);
				material.X = reader.GetString(2);
				material.Y = reader.GetString(3);
				material.Z = reader.GetString(4);
				material.IdTipoMaterial = reader.GetInt32(5);
				material.Precio = reader.GetDecimal(6);
				lista.Add(material);
			}
			return lista;
		}

		/// <summary>
		/// Guarda un nuevo material en la base de datos.
		/// </summary>
		/// <param name="pMateriales">Objeto de tipo <see cref="Materiales"/> que contiene los datos del material.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int guardarMaterial(Materiales pMateriales)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spAgregarMaterial";
			cmd.Parameters.AddWithValue("@NombreMaterial", pMateriales.NombreMaterial);
			cmd.Parameters.AddWithValue("@X", pMateriales.X);
			cmd.Parameters.AddWithValue("@Y", pMateriales.Y);
			cmd.Parameters.AddWithValue("@Z", pMateriales.Z);
			cmd.Parameters.AddWithValue("@IdTipoMaterial", pMateriales.IdTipoMaterial);
			cmd.Parameters.AddWithValue("@Precio", pMateriales.Precio);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Actualiza un material existente en la base de datos.
		/// </summary>
		/// <param name="pMateriales">Objeto de tipo <see cref="Materiales"/> con los datos actualizados del material.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int actualizarMaterial(Materiales pMateriales)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spActualizarMaterial";
			cmd.Parameters.AddWithValue("@Id", pMateriales.Id);
			cmd.Parameters.AddWithValue("@NombreMaterial", pMateriales.NombreMaterial);
			cmd.Parameters.AddWithValue("@X", pMateriales.X);
			cmd.Parameters.AddWithValue("@Y", pMateriales.Y);
			cmd.Parameters.AddWithValue("@Z", pMateriales.Z);
			cmd.Parameters.AddWithValue("@IdTipoMaterial", pMateriales.IdTipoMaterial);
			cmd.Parameters.AddWithValue("@Precio", pMateriales.Precio);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina un material de la base de datos.
		/// </summary>
		/// <param name="pMateriales">Objeto de tipo <see cref="Materiales"/> que representa el material a eliminar.</param>
		/// <returns>El número de filas afectadas por la operación.</returns>
		public int eliminarMateriales(Materiales pMateriales)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarMaterial";
			cmd.Parameters.AddWithValue("@Id", pMateriales.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Recupera un material por su identificador desde la base de datos.
		/// </summary>
		/// <param name="Id">El identificador del material a recuperar.</param>
		/// <returns>Un objeto de tipo <see cref="Materiales"/> que representa el material.</returns>
		public Materiales MostrarPorIdMateriales(int Id)
		{
			var regresar = new Materiales();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdMateriales";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Materiales material = new Materiales();
				material.Id = reader.GetInt32(0);
				material.NombreMaterial = reader.GetString(1);
				material.X = reader.GetString(2);
				material.Y = reader.GetString(3);
				material.Z = reader.GetString(4);
				material.IdTipoMaterial = reader.GetInt32(5);
				material.Precio = reader.GetDecimal(6);

				regresar = material;
			}
			return regresar;
		}
	}

}
