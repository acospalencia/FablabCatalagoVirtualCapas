using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class TipoMaterialBL
	{
		TipoMaterialDAL TipoBL = new TipoMaterialDAL();
		public List<TipoMaterial> regresarTipoMaterial()
		{
			return TipoBL.RegresarListaTipo();
		}
		public TipoMaterial MostrarPorIdTipo(int Id)
		{
			return TipoBL.MostrarPorIdTipo(Id);
		}

	}
}
