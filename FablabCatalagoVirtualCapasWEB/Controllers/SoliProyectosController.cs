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
			var autor = Session["Autor"] as Autores;

			if (autor != null)
			{
				var ListasSolis = solisBL.RegresarLista().Where(c => c.IdAutor == autor.Id).ToList();

				return View(ListasSolis);
			}
			else
			{
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
					return RedirectToAction("Mis_Solicitudes");  
				}

				return View(soli);  
			}
			else
			{
				return RedirectToAction("InciarSesion", "Autores");
			}
		}






	}
}