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
		//Crear atributos
		public int Id { get; set; }
		public string NombrePrototipo { get; set; }
		public int IdMaterial { get; set; }
		public string X { get; set; } 
		public string Y { get; set;}
		public string Z { get; set; }
		public string Descripcion { get; set;}
		public Image Imagen { get; set;}
		public int IdDuracion { get; set;}
		public int IdEstado {  get; set; }
		public int IdMaquinaria { get; set; }
	}
}
