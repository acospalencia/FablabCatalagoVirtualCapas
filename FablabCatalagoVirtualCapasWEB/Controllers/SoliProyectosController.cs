using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWEB.Permisos;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
	[ValidarSesion]
	public class SoliProyectosController : Controller
    {
        SolicitudProyectosBL solisBL = new SolicitudProyectosBL();
		// GET: SoliProyectos
		public ActionResult Mis_Solicitudes()
		{
			// Recupera el autor desde la sesión
			var autor = Session["Autor"] as Autores;

			// Verifica si el autor existe en la sesión
			if (autor != null)
			{
				// Filtra las solicitudes del autor
				var ListasSolis = solisBL.RegresarLista().Where(c => c.IdAutor == autor.Id).ToList();

				// Retorna la vista con la lista de solicitudes del autor
				return View(ListasSolis);
			}
			else
			{
				// Si no hay autor en la sesión, redirige al inicio de sesión
				return RedirectToAction("InciarSesion", "Autores");
			}
		}
		public ActionResult Create()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(SolicitudProyectos soli)
		{
			var autor = Session["Autor"] as Autores;

			if (autor != null)
			{
				soli.IdAutor = autor.Id;

				if (ModelState.IsValid)
				{
					solisBL.GuardarSoli(soli);  
					return RedirectToAction("Index", "Home");  
				}

				return View(soli);  
			}
			else
			{
				// Si no hay autor en la sesión, redirige a la página de inicio de sesión
				return RedirectToAction("InciarSesion", "Autores");
			}
		}
	}
}