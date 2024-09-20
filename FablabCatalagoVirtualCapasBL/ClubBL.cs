using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los clubes.
	/// </summary>
	public class ClubBL
	{
		// Instancia de la capa de acceso a datos para clubes.
		ClubDAL clubBl = new ClubDAL();

		/// <summary>
		/// Guarda un nuevo club en la base de datos.
		/// </summary>
		/// <param name="pClub">Instancia del objeto Club a guardar.</param>
		/// <returns>El identificador del club guardado.</returns>
		public int GuardarClub(Club pClub)
		{
			return clubBl.GuardarClub(pClub);
		}

		/// <summary>
		/// Obtiene la lista completa de clubes desde la base de datos.
		/// </summary>
		/// <returns>Lista de clubes.</returns>
		public List<Club> RegresarLista()
		{
			return clubBl.RegresarLista();
		}
	}
}
