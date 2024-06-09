using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class DuracionesBL
	{
		DuracionesDAL duracionesDAL = new DuracionesDAL();
		
		public int GuardarDuracion(Duraciones pDuracion)
		{
			return duracionesDAL.GuardarDuraciones(pDuracion);
		}
		public int RegresarId()
		{
			return duracionesDAL.RegresarId();
		}
	}
}
