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
			
	}
}
