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
		private PrototipoDAL PrototiposDAL = new PrototipoDAL();
		
		public void Guardar(Prototipo pPrototipo)
		{
			PrototiposDAL.guardarNuevoPrototipo(pPrototipo);
		}
		public void Modificar(Prototipo pPrototipo)
		{
			PrototiposDAL.ModificarPrototipo(pPrototipo);
		}
		public void Eliminar (Prototipo pPrototipo)
		{
			PrototiposDAL.EliminarPrototipo(pPrototipo);
		}
		public List<Prototipo> regresarlista()
		{
			return PrototiposDAL.RegresarLista();
		}
	}
}
