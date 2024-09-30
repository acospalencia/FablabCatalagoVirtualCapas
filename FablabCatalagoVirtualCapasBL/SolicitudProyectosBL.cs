using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class SolicitudProyectosBL
	{
		SolicitudProyectosDAL solisDAL = new SolicitudProyectosDAL();
		public int GuardarSoli(SolicitudProyectos pSoli)
		{
			return solisDAL.GuardarSoli(pSoli);
		}
		public int ModiSoli(SolicitudProyectos pSoli)
		{
			return solisDAL.ModificarSoli(pSoli);
		}
		public int EliminarSoli(SolicitudProyectos pSoli)
		{
			return solisDAL.DeleteSoli(pSoli);
		}
		public int ModificarAprobacion(SolicitudProyectos pSoli)
		{
			return solisDAL.ModificarAprobacion(pSoli);
		}
		public List<SolicitudProyectos> RegresarLista()
		{
			return solisDAL.RegresarLista();
		}
		public SolicitudProyectos MostrarInfo(SolicitudProyectos pSoli)
		{
			return solisDAL.MostrarInfo(pSoli);
		}
	}
}
