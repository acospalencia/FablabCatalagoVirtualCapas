using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	public class SolicitudProyectos
	{
		public int Id { get; set; }
		public string TipoProyecto { get; set; }
		public string Descripcion { get; set; }
		public string Integrantes { get; set; }
		public DateTime Fecha { get; set; }
		public string Estado { get; set; }
		public int IdAutor { get; set; }
	}
}
