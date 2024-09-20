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
	/// Clase que maneja la lógica de negocio relacionada con las inscripciones a clubes.
	/// </summary>
	public class InscripcionClubBL
	{
		// Instancia de la capa de acceso a datos para inscripciones a clubes.
		InscripcionClubDAL inscrpDAL = new InscripcionClubDAL();

		/// <summary>
		/// Agrega una nueva inscripción a un club en la base de datos.
		/// </summary>
		/// <param name="pInscr">Instancia del objeto InscripcionClub a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int AddInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.GuardarInscripcion(pInscr);
		}

		/// <summary>
		/// Obtiene la lista completa de inscripciones a clubes desde la base de datos.
		/// </summary>
		/// <returns>Lista de inscripciones a clubes.</returns>
		public List<InscripcionClub> RegresarLista()
		{
			return inscrpDAL.RegresarLista();
		}

		/// <summary>
		/// Modifica los datos de una inscripción existente en la base de datos.
		/// </summary>
		/// <param name="pInscr">Instancia del objeto InscripcionClub con los datos modificados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ModiInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.ModificarInscripcion(pInscr);
		}

		/// <summary>
		/// Elimina una inscripción a un club de la base de datos.
		/// </summary>
		/// <param name="pInscr">Instancia del objeto InscripcionClub a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int DeleteInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.EliminarInscripcion(pInscr);
		}
	}

}
