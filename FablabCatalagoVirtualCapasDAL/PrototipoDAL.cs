using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasDAL
{
	public class PrototipoDAL
	{
		//crear la lista donde se ingresaran los nuevos prototipos
		public static List<Prototipo> listaPrototipos = new List<Prototipo>()
		{
			new Prototipo {Id = 1, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "Resina", TiempoArmado = "4 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas", Autor = "Carlos"},
			new Prototipo {Id = 2, NombrePrototipo = "Sistema de regado", Ancho = 5 , Alto = 2, Descripcion = "Sistema de regado para jardines",
			TipoMaterial = "Plastico pvc", TiempoArmado = "2 Horas", TiempoDiseñado = "5 Horas", TiempoFabricado = "5 Horas", Autor = "FabLab"},
			new Prototipo {Id = 3, NombrePrototipo = "Barco de onepiece", Ancho = 25 , Alto = 20, Descripcion = "Barco hecho de playwood de la iconica serie onepiece",
			TipoMaterial = "Playwood", TiempoArmado = "5 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "3 Horas", Autor = "Alejandra", ImagenPrototipo = Image.FromFile("C:/Users/carlo/source/repos/FablabCatalagoVirtualCapas/preuba de imagen.jpeg")},
			new Prototipo {Id = 4, NombrePrototipo = "Lapicera de madera", Ancho = 5 , Alto = 9, Descripcion = "Lapicera de madera con el logo institucional grabado en playwood",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas", Autor = "Nicole"},
			new Prototipo {Id = 5, NombrePrototipo = "Robot de 3 ruedas", Ancho = 12 , Alto = 10, Descripcion = "pequeño robot de tres ruedas funcional",
			TipoMaterial = "plastico", TiempoArmado = "2 Horas", TiempoDiseñado = "4 Horas", TiempoFabricado = "5 Horas", Autor = "Yulisa"}
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
