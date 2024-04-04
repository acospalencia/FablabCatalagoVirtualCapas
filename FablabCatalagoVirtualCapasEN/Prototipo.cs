using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	public class Prototipo
	{
		public int Id { get; set; }
		public string NombrePrototipo { get; set; }
		public string TipoMaterial { get; set; }
		public double Dimensiones { get; set; } 
		public double Precio { get; set;}
		public string Descripcion { get; set;}
		public Image ImagenPrototipo { get; set;}
		public double TiempoTranscurrido { get; set;}

	}
}
