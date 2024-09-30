using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult CerrarSesion()
		{
			// Limpiar la sesión
			Session.Clear();
			Session.Abandon();

			// Evitar el caché en la página
			HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
			HttpContext.Response.Cache.SetValidUntilExpires(false);
			HttpContext.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
			HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
			HttpContext.Response.Cache.SetNoStore();

			return RedirectToAction("InciarSesion", "Autores");
		}
	}
}