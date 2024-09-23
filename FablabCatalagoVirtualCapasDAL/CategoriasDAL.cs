using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasDAL
{
	public class CategoriasDAL
	{
		public List<Categorias> Categorias()
		{
			List<Categorias> ListaCateg = new List<Categorias>();
			SqlCommand cmd = ComunBD.ObtenerComan();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "spShowCategorias";
			SqlDataReader reader = ComunBD.EjecutarReader(cmd);
			while (reader.Read())
			{
				Categorias Catego = new Categorias
				{
					Id = reader.GetInt32(0),
					Nombre = reader.GetString(1)
				};

				ListaCateg.Add(Catego);
			}
			return ListaCateg;
		}
	}
}
