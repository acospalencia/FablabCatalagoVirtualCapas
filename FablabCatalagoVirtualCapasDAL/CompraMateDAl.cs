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
	/// Clase que maneja la capa de acceso a datos para las compras de materiales.
	/// </summary>
	public class CompraMateDAL
	{
		/// <summary>
		/// Guarda una nueva compra de material en la base de datos.
		/// </summary>
		/// <param name="pCompra">Instancia del objeto CompraMate a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarCompra(CompraMate pCompra)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAddCompra";
			cmd.Parameters.AddWithValue("@IdMaterial", pCompra.IdMaterial);
			cmd.Parameters.AddWithValue("@IdProveedor", pCompra.IdProveedor);
			cmd.Parameters.AddWithValue("@CantidadCompra", pCompra.CantidadCompra);
			cmd.Parameters.AddWithValue("@TotalPagar", pCompra.TotalPagar);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Modifica una compra de material existente en la base de datos.
		/// </summary>
		/// <param name="pCompra">Instancia del objeto CompraMate con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModificarCompra(CompraMate pCompra)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPModiCompra";
			cmd.Parameters.AddWithValue("@Id", pCompra.Id);
			cmd.Parameters.AddWithValue("@IdMaterial", pCompra.IdMaterial);
			cmd.Parameters.AddWithValue("@IdProveedor", pCompra.IdProveedor);
			cmd.Parameters.AddWithValue("@CantidadCompra", pCompra.CantidadCompra);
			cmd.Parameters.AddWithValue("@TotalPagar", pCompra.TotalPagar);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina una compra de material de la base de datos.
		/// </summary>
		/// <param name="pCompra">Instancia del objeto CompraMate a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int DeleteCompra(CompraMate pCompra)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPDeleteCompra";
			cmd.Parameters.AddWithValue("@Id", pCompra.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Obtiene la lista completa de compras de materiales desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos CompraMate.</returns>
		public List<CompraMate> RegresarLista()
		{
			List<CompraMate> ListaCompras = new List<CompraMate>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaCompra";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				CompraMate compra = new CompraMate
				{
					Id = reader.GetInt32(0),
					IdMaterial = reader.GetInt32(1),
					IdProveedor = reader.GetInt32(2),
					CantidadCompra = reader.GetString(3),
					TotalPagar = reader.GetDecimal(4)
				};

				ListaCompras.Add(compra);
			}
			return ListaCompras;
		}
	}

}
