using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;

namespace FablabCatalagoVirtualCapasBL
{
	public class PrototipoBL
	{
		//se crea la instancia de la capa prototiposDAL
		PrototipoDAL PrototiposDAL = new PrototipoDAL();
		
		public int Guardar(Prototipo pPrototipo)
		{
			return PrototiposDAL.guardarNuevoPrototipo(pPrototipo);
		}
		public int Modificar(Prototipo pPrototipo)
		{
			return PrototiposDAL.ModificarPrototipo(pPrototipo);
		}
		public int Eliminar (Prototipo pPrototipo)
		{
			return PrototiposDAL.EliminarPrototipo(pPrototipo);
		}
		public List<Prototipo> regresarlista()
		{
			return PrototiposDAL.RegresarLista();
		}
	}
}
