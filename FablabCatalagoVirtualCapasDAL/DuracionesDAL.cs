﻿using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasDAL
{
	public class DuracionesDAL
	{
		public int GuardarDuraciones(Duraciones pDuraciones)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPGuardarDuracion";
			cmd.Parameters.AddWithValue("@TiempoDiseno", pDuraciones.TiempoDiseno);
			cmd.Parameters.AddWithValue("@TiempoFabricado", pDuraciones.TiempoFabricado);
			cmd.Parameters.AddWithValue("@TiempoArmado", pDuraciones.TiempoArmado);
			return ComunBD.EjecutarComand(cmd);
		}
		public int ActualizarDuraciones(Duraciones pDuraciones)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPActualizarDuraciones";
			cmd.Parameters.AddWithValue("@id", pDuraciones.Id);
			cmd.Parameters.AddWithValue("@Disenado", pDuraciones.TiempoDiseno);
			cmd.Parameters.AddWithValue("@Fabricado", pDuraciones.TiempoFabricado);
			cmd.Parameters.AddWithValue("@Armado", pDuraciones.TiempoArmado);
			return ComunBD.EjecutarComand(cmd);
		}

		public int RegresarId()
		{
			int Id = 0;
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPObtenerUltimoId";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Id = reader.GetInt32(0);

			}
			return Id;
		}
		public Duraciones MostrarPorIdDuraciones(int Id)
		{
			var test = new Duraciones();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarPorIdDuraciones";
			cmd.Parameters.AddWithValue("@Id", Id);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Duraciones duraciones = new Duraciones();
				duraciones.Id = reader.GetInt32(0);
				duraciones.TiempoDiseno = reader.GetString(1);
				duraciones.TiempoFabricado = reader.GetString(2);
				duraciones.TiempoArmado = reader.GetString(3);
				test = duraciones;
			}
			return test;
		}
	}
}
