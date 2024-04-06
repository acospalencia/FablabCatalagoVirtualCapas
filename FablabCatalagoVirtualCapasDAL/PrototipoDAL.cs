using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasDAL
{
	public class PrototipoDAL
	{
		//crear la lista donde se ingresaran los nuevos prototipos
		public static List<Prototipo> listaPrototipos = new List<Prototipo>()
		{
			new Prototipo {Id = 1, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas"},
			new Prototipo {Id = 2, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas"},
			new Prototipo {Id = 3, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas"},
			new Prototipo {Id = 4, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas"},
			new Prototipo {Id = 5, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas"}
		};

		//metodo para agregar un nuevo prototipo a la lista
		public void guardarNuevoPrototipo(Prototipo pPrototipo)
		{
			pPrototipo.Id = listaPrototipos.Select(listaPrototipos => listaPrototipos.Id).DefaultIfEmpty(0).Max() + 1;
			listaPrototipos.Add(pPrototipo);
		}
		//metodo para modificar un prototipo en la lista
		public void ModificarPrototipo(Prototipo pPrototipo)
		{
			var modificar = listaPrototipos.FirstOrDefault(i => i.Id == pPrototipo.Id);
			listaPrototipos.Add(pPrototipo);
			listaPrototipos.Remove(modificar);
		}
		//Metodo para elimianar un prototipo de la lista 
		public void EliminarPrototipo(Prototipo pPrototipo)
		{
			var Eliminar = listaPrototipos.FirstOrDefault(i => i.Id == pPrototipo.Id);
			listaPrototipos.Remove(Eliminar);
		}
		//metodo para regresar la lista
		public List<Prototipo> RegresarLista()
		{
			return listaPrototipos;
		}
	}
}
