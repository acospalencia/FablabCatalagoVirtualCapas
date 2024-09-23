using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasWEB.Permisos;


namespace FablabCatalagoVirtualCapasWEB.Controllers
{
	public class PrototiposController : Controller
    {
		private ModeloProto2BL modelo2BL = new ModeloProto2BL();
		// GET: Prototipos
		public ActionResult Index()
        {
            var modelos = modelo2BL.MostrarInfoCat1();
            return View(modelos);
        }
		public ActionResult PTecnologicos()
		{
			var modelos = modelo2BL.MostrarInfoCat1();
			return View(modelos);
		}
		public ActionResult Testing()
		{
			var modelos = modelo2BL.MostrarInfoCat2();
			return View(modelos);
		}
		public ActionResult PLPIT()
		{
			var modelos = modelo2BL.MostrarInfoCat3();
			return View(modelos);
		}
	}
}