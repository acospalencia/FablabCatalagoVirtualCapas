using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	public class CreacionProto
	{

		public int Id { get; set; }
		public int IdAutorLider { get; set; }
		public int IdPrototipo { get; set; }
		public int IdUsuario { get; set; }
		public DateTime FechaCreacion { get; set; }
		public string NumeroAutoresEquipo { get; set; }
		public string Nombres { get; set; }

	}
}
