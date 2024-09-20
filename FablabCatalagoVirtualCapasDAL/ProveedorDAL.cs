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
	/// Clase que maneja el acceso a datos para los proveedores en la base de datos.
	/// </summary>
	public class ProveedorDAL
	{
		/// <summary>
		/// Agrega un nuevo proveedor a la base de datos.
		/// </summary>
		/// <param name="pProveedor">Objeto de tipo <see cref="Proveedor"/> que representa el proveedor a agregar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarProveedor(Proveedor pProveedor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAggProveedor";
			cmd.Parameters.AddWithValue("@Nombres", pProveedor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pProveedor.Apellidos);
			cmd.Parameters.AddWithValue("@Direccion", pProveedor.Direccion);
			cmd.Parameters.AddWithValue("@NumTelefono", pProveedor.NumTelefono);
			cmd.Parameters.AddWithValue("@CorreoElectronico", pProveedor.CorreoElectronico);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Recupera una lista de todos los proveedores desde la base de datos.
		/// </summary>
		/// <returns>Una lista de objetos de tipo <see cref="Proveedor"/> que representan todos los proveedores.</returns>
		public List<Proveedor> RegresarLista()
		{
			List<Proveedor> ListaProveedor = new List<Proveedor>(); // Definición de la lista.
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaProveedor";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Proveedor proveedor = new Proveedor
				{
					Id = reader.GetInt32(0),
					Nombres = reader.GetString(1),
					Apellidos = reader.GetString(2),
					Direccion = reader.GetString(3),
					NumTelefono = reader.GetString(4),
					CorreoElectronico = reader.GetString(5)
				};

				ListaProveedor.Add(proveedor);
			}
			return ListaProveedor;
		}

		/// <summary>
		/// Modifica un proveedor existente en la base de datos.
		/// </summary>
		/// <param name="pProveedor">Objeto de tipo <see cref="Proveedor"/> que representa el proveedor a modificar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ActualizarProveedores(Proveedor pProveedor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActuProveedores";
			cmd.Parameters.AddWithValue("@Id", pProveedor.Id);
			cmd.Parameters.AddWithValue("@Nombres", pProveedor.Nombres);
			cmd.Parameters.AddWithValue("@Apellidos", pProveedor.Apellidos);
			cmd.Parameters.AddWithValue("@Direccion", pProveedor.Direccion);
			cmd.Parameters.AddWithValue("@NumTelefono", pProveedor.NumTelefono);
			cmd.Parameters.AddWithValue("@CorreoElectronico", pProveedor.CorreoElectronico);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Elimina un proveedor de la base de datos.
		/// </summary>
		/// <param name="pProveedor">Objeto de tipo <see cref="Proveedor"/> que representa el proveedor a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarProveedor(Proveedor pProveedor)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarProveedor";
			cmd.Parameters.AddWithValue("@Id", pProveedor.Id);
			return ComunBD.EjecutarComand(cmd);
		}
	}

}
