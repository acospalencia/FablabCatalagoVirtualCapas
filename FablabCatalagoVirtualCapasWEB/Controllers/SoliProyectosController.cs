using FablabCatalagoVirtualCapasBL;
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
    }
}