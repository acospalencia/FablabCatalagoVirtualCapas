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
	public class CompraMateDAl
	{
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
		public int DeleteCompra(CompraMate pCompra)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPDeleteCompra";
			cmd.Parameters.AddWithValue("@Id", pCompra.Id);
			return ComunBD.EjecutarComand(cmd);
		}

		public List<CompraMate> RegresarLista()
		{
			List<CompraMate> ListaClubs = new List<CompraMate>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaCompra";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				CompraMate Club = new CompraMate();
				Club.Id = reader.GetInt32(0);
				Club.IdMaterial = reader.GetInt32(1);
				Club.IdProveedor = reader.GetInt32(2);
				Club.CantidadCompra = reader.GetString(3);
				Club.TotalPagar = reader.GetDecimal(4);

				ListaClubs.Add(Club);
			}
			return ListaClubs;
		}
	}
}
