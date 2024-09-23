using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
    public class AutoresController : Controller
    {
		private AutoresBL autorBL = new AutoresBL();
        // GET: Autores
        public ActionResult Index()
        {
			var autores = autorBL.RegresarLista();
			return View(autores);
        }
		// GET: Autores/Details
		public ActionResult Details(int Id)
		{
			var autor = autorBL.RegresarLista().FirstOrDefault(c => c.Id == Id);
			if (autor == null)
			{
				return HttpNotFound();
			}
			return View(autor);
		}
		//GET: Autores/Create
		public ActionResult Create()
		{
			return View();
		}
		// POST: Autores/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Autores autor)
		{
			if (ModelState.IsValid)
			{
				autorBL.GuardarAutor(autor);
				return RedirectToAction("Index");
			}
			return View(autor);
		}
		// GET: Autores/Edit
		public ActionResult Edit(int id)
		{
			var autor = autorBL.RegresarLista().FirstOrDefault(c => c.Id == id);
			if (autor == null)
			{
				return HttpNotFound();
			}
			return View(autor);
		}
		// POST: Cliente/Edit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Autores autor)
		{
			if (ModelState.IsValid)
			{
				autorBL.ModificarAutor(autor);
				return RedirectToAction("Index");
			}
			return View(autor);
		}
	}

}


    
