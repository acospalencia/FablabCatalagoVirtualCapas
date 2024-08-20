using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	public class InscripcionClub
	{
		public int Id { get; set; }
		public int IdAutor {  get; set; }
		public int IdClub { get; set; }
		public DateTime FechaInscripcion { get; set; }
		public string Detalle {  get; set; }
	}
}
