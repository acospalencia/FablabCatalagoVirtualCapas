using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class InscripcionClubBL
	{
		InscripcionClubDAL inscrpDAL = new InscripcionClubDAL();

		public int AddInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.GuardarInscripcion(pInscr);
		}
		public List<InscripcionClub> RegresarLista()
		{
			return inscrpDAL.RegresarLista();
		}
		public int ModiInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.ModificarInscripcion(pInscr);
		}
		public int DeleteInscripcion(InscripcionClub pInscr)
		{
			return inscrpDAL.EliminarInscripcion(pInscr);
		}
	}
}
