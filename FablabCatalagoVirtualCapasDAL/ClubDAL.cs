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
	/// Clase que maneja la capa de acceso a datos para los clubes.
	/// </summary>
	public class ClubDAL
	{
		/// <summary>
		/// Guarda un nuevo club en la base de datos.
		/// </summary>
		/// <param name="pClub">Instancia del objeto Club a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarClub(Club pClub)
		{
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPAddClubs";
			cmd.Parameters.AddWithValue("@NombreClub", pClub.NombreClub);
			cmd.Parameters.AddWithValue("@Detalle", pClub.Detalle);
			return ComunBD.EjecutarComand(cmd);
		}

		/// <summary>
		/// Obtiene la lista completa de clubes desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos Club.</returns>
		public List<Club> RegresarLista()
		{
			List<Club> ListaClubs = new List<Club>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SPListaClubs";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Club club = new Club
				{
					Id = reader.GetInt32(0),
					NombreClub = reader.GetString(1),
					Detalle = reader.GetString(2)
				};

				ListaClubs.Add(club);
			}
			return ListaClubs;
		}
	}

}
