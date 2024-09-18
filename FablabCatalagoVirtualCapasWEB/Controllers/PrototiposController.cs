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

        private PrototipoBL protosBL = new PrototipoBL();
        // GET: Prototipos
        public ActionResult Index()
        {
            var protos = protosBL.regresarlista();
            return View(protos);
        }
    }
}