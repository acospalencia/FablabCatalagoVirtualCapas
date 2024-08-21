using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class ReporteBL
	{
		ReporteDAL reporte = new ReporteDAL(); 
		public List<Reporte> RegresarLista()
		{
			return reporte.RegresarLista();
		}
	}
}
