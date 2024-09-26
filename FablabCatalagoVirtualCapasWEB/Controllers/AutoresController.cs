using FablabCatalagoVirtualCapasBL;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasWEB.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

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

		public ActionResult Registrarse()
		{
			return View();
		}

		public ActionResult InciarSesion()
		{
			return View();
		}

		[ValidarSesion]
		// GET: Autores/Details
		public ActionResult Details(int Id)
		{
			if (Session["Autor"] == null)
			{
				return RedirectToAction("Login", "Account");
			}
			var autor = autorBL.RegresarLista().FirstOrDefault(c => c.Id == Id);
			if (autor == null)
			{
				return HttpNotFound();
			}
			return View(autor);
		}

		[ValidarSesion]
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

		[ValidarSesion]
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

		[HttpPost]
		public ActionResult Registrarse(Autores pAutor)
		{

			(bool Registrado, string mensaje) = autorBL.RegistrarAutor(pAutor);

			ViewData["Mensaje"] = mensaje;

            if (Registrado)
            {
				return RedirectToAction("InciarSesion", "Autores");
            }
            else
            {
				return View();
            }
		}

		[HttpPost]
		public ActionResult InciarSesion(Autores pAutor)
		{

			Autores InfoAutor = autorBL.IniciarSesion(pAutor);

            if (InfoAutor.Id != 0)
            {
				Session["Autor"] = InfoAutor;
				return RedirectToAction("Index", "Home");
			}
			else
            {
				ViewData["Mensaje"] = "Autor no encontrado. Revisa las credenciales";
				return View();
			}

		}
	}

}


    
