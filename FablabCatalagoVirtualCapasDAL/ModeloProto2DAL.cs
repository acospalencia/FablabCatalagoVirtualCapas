﻿using FablabCatalagoVirtualCapasEN;
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
	/// Clase que maneja el acceso a datos para la información del prototipo en la base de datos.
	/// </summary>
	public class ModeloProto2DAL
	{
		/// <summary>
		/// Recupera la información de un prototipo desde la base de datos basado en el nombre del prototipo.
		/// </summary>
		/// <param name="pPrototipo">Objeto de tipo <see cref="Prototipo"/> que contiene el nombre del prototipo.</param>
		/// <returns>Un objeto de tipo <see cref="ModeloProto2"/> que representa la información del prototipo.</returns>
		public ModeloProto2 MostrarInfo(Prototipo pPrototipo)
		{
			var test = new ModeloProto2();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPMostrarInfo";
			cmd.Parameters.AddWithValue("@NombrePrototipo", pPrototipo.NombrePrototipo);
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				ModeloProto2 prototipo = new ModeloProto2
				{
					NombrePrototipo = reader.GetString(0),
					NombreMaterial = reader.GetString(1),
					X = reader.GetString(2),
					Y = reader.GetString(3),
					Z = reader.GetString(4),
					Descripcion = reader.GetString(5),
					TiempoArmado = reader.GetString(6),
					TiempoDiseno = reader.GetString(7),
					TiempoFabricado = reader.GetString(8),
					NombreEstado = reader.GetString(9),
					Nombre = reader.GetString(10),
				};

				if (!reader.IsDBNull(11))
				{
					long length = reader.GetBytes(11, 0, null, 0, 0);
					byte[] buffer = new byte[length];
					reader.GetBytes(11, 0, buffer, 0, (int)length);
					prototipo.Imagen = buffer;
				}

				test = prototipo;
			}
			return test;
		}
	}

}
