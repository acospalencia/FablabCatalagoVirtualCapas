using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FablabCatalagoVirtualCapasBL;


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
    }
}