using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
    public class SoliProyectosController : Controller
    {
        SolicitudProyectosBL solisBL = new SolicitudProyectosBL();
        // GET: SoliProyectos
        public ActionResult Index()
        {
            var ListasSolis = solisBL.RegresarLista();
            return View(ListasSolis);
        }
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(SolicitudProyectos soli)
		{
			if (ModelState.IsValid)
			{
				solisBL.GuardarSoli(soli);

				return RedirectToAction("Index");
			}

			return View(soli);
		}
	}
}