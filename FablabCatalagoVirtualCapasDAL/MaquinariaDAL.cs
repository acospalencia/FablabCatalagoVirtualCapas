using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasDAL
{
	public class MaquinariaDAL
	{
		public List<Maquinaria> RegresarMaquinaria()
		{
			List<Maquinaria> ListaMaquinaria = new List<Maquinaria>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarMAquinaria";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Maquinaria maquinaria = new Maquinaria();
				maquinaria.Id = reader.GetInt32(0);
				maquinaria.Nombre = reader.GetString(1);
				maquinaria.Marca = reader.GetString(2);
				maquinaria.Detalle = reader.GetString(3);
				maquinaria.Idestado = reader.GetInt32(4);
				ListaMaquinaria.Add(maquinaria);
			}
			return ListaMaquinaria;
		}
		public Maquinaria MostrarPorIdMaquinaria(int Id)
		{
			var Regresar = new Maquinaria();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdMaquinaria";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Maquinaria maquinaria = new Maquinaria();
				maquinaria.Id = reader.GetInt32(0);
				maquinaria.Nombre = reader.GetString(1);
				maquinaria.Marca = reader.GetString(2);
				maquinaria.Detalle = reader.GetString(3);
				maquinaria.Idestado = reader.GetInt32(4);
				Regresar = maquinaria;
			}
			return Regresar;
		}

		public int GuardarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAggMaquinaria";
			cmd.Parameters.AddWithValue("@Nombre", pMaquinaria.Nombre);
			cmd.Parameters.AddWithValue("@Marca", pMaquinaria.Marca);
			cmd.Parameters.AddWithValue("@Detalle", pMaquinaria.Detalle);
			cmd.Parameters.AddWithValue("@IdEstado", pMaquinaria.Idestado);
			
			return ComunBD.EjecutarComand(cmd);
		}
		public int ActualizarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActuMaquinaria";
			cmd.Parameters.AddWithValue("@Id", pMaquinaria.Id);
			cmd.Parameters.AddWithValue("@Nombre", pMaquinaria.Nombre);
			cmd.Parameters.AddWithValue("@Marca", pMaquinaria.Marca);
			cmd.Parameters.AddWithValue("@Detalle", pMaquinaria.Detalle);
			cmd.Parameters.AddWithValue("@IdEstado", pMaquinaria.Idestado);
			return ComunBD.EjecutarComand(cmd);
		}
		public int EliminarMaquinaria(Maquinaria pMaquinaria)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPEliminarMaquinaria";
			cmd.Parameters.AddWithValue("@Id", pMaquinaria.Id);
			return ComunBD.EjecutarComand(cmd);
		}
	} 
}
