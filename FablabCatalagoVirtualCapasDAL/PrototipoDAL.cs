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
			new Prototipo {Id = 1, NombrePrototipo = "Robot de 3 ruedas", Dimensiones = 12*10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico"}
		};

		//metodo para agregar un nuevo prototipo a la lista
		public void guardarNuevoPrototipo(Prototipo pPrototipo)
		{
			pPrototipo.Id = listaPrototipos.Select(listaPrototipos => listaPrototipos.Id).DefaultIfEmpty(0).Max() + 1 ;
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
