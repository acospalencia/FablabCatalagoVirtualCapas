using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasBL
{
	public class EstadosBL
	{
		EstadosDAL EstadosDal = new EstadosDAL();
		public List<Estados> RegresarEstadosPrototipos()
		{
			return EstadosDal.RegresarEstadosPrototipos();
		}
		public Estados MostrarPorIdEstados(int Id)
		{
			return EstadosDal.MostrarPorIdEstados(Id);
		}
	}
}
