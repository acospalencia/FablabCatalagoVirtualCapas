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
	public class ClubDAL
	{
		public int GuardarClub(Club pClub)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAddClubs";
			cmd.Parameters.AddWithValue("@NombreClub", pClub.NombreClub);
			return ComunBD.EjecutarComand(cmd);
		}
		public List<Club> RegresarLista()
		{
			List<Club> ListaClubs = new List<Club>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaClubs";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Club Club = new Club();
				Club.Id = reader.GetInt32(0);
				Club.NombreClub = reader.GetString(1);

				ListaClubs.Add(Club);
			}
			return ListaClubs;
		}
	}
}
