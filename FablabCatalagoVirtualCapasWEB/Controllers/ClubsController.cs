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
	public class ClubsController : Controller
	{
		private ClubBL clubsBL = new ClubBL();

		// GET: Clubs
		public ActionResult Index()
		{
			var clubes = clubsBL.RegresarLista();
			return View(clubes);
		}

		// GET: Clubs/Details/5
		public ActionResult Details(int id)
		{
			var club = clubsBL.RegresarLista().FirstOrDefault(c => c.Id == id);
			if (club == null)
			{
				return HttpNotFound();
			}
			return View(club);
		}

		// GET: Clubs/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Clubs/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Club club)
		{
			if (ModelState.IsValid)
			{
				clubsBL.GuardarClub(club);
				return RedirectToAction("Index");
			}
			return View(club);
		}

	
	}
}