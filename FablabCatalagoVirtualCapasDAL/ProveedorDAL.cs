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
	public class ProveedorDAL
	{
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
		public List<Proveedor> RegresarLista()
		{
			List<Proveedor> ListaProveedor = new List<Proveedor>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaProveedor";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Proveedor maquinaria = new Proveedor();
				maquinaria.Id = reader.GetInt32(0);
				maquinaria.Nombres = reader.GetString(1);
				maquinaria.Apellidos = reader.GetString(2);
				maquinaria.Direccion = reader.GetString(3);
				maquinaria.NumTelefono = reader.GetString(4);
				maquinaria.CorreoElectronico = reader.GetString(5);

				ListaProveedor.Add(maquinaria);
			}
			return ListaProveedor;
		}
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
