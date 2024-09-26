using FablabCatalagoVirtualCapasBL; // Lógica de negocio
using FablabCatalagoVirtualCapasEN; // Entidades
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
	public class InscripClubsController : Controller
	{
		// Instancia de la lógica de negocio para interactuar con los datos de inscripción.
		private InscripcionClubBL inscrpBL = new InscripcionClubBL();

		// GET: InscripClubs
		// Método para listar todas las inscripciones.
		public ActionResult Index()
		{
			// Llama al método de la lógica de negocio para obtener todas las inscripciones.
			var inscripciones = inscrpBL.RegresarLista();
			// Retorna la vista con la lista de inscripciones.
			return View(inscripciones);
		}

		// GET: InscripClubs/Details/5
		// Método que muestra los detalles de una inscripción específica por su ID.
		public ActionResult Details(int id)
		{
			// Busca la inscripción por ID en la lista.
			var inscripcion = inscrpBL.RegresarLista().FirstOrDefault(i => i.InscripcionID == id);

			// Si no se encuentra la inscripción, retorna un error 404.
			if (inscripcion == null)
			{
				return HttpNotFound();
			}

			// Si se encuentra, retorna la vista con los detalles de la inscripción.
			return View(inscripcion);
		}

		// GET: InscripClubs/Create
		// Método que muestra el formulario para crear una nueva inscripción.
		public ActionResult Create()
		{
			return View();
		}

		// POST: InscripClubs/Create
		// Método que recibe los datos del formulario para crear una nueva inscripción.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(InscripcionClub inscripcion)
		{
			if (ModelState.IsValid)
			{
				// Llama al método de la lógica de negocio para agregar la inscripción.
				inscrpBL.AddInscripcion(inscripcion);
				// Redirige al listado de inscripciones tras crear una nueva.
				return RedirectToAction("Index");
			}

			// Si el modelo no es válido, retorna la misma vista para mostrar errores.
			return View(inscripcion);
		}

		// GET: InscripClubs/Edit/5
		// Método que muestra el formulario para editar una inscripción existente.
		public ActionResult Edit(int id)
		{
			// Busca la inscripción por ID.
			var inscripcion = inscrpBL.RegresarLista().FirstOrDefault(i => i.InscripcionID == id);

			// Si no se encuentra la inscripción, retorna un error 404.
			if (inscripcion == null)
			{
				return HttpNotFound();
			}

			// Retorna la vista de edición con los datos de la inscripción.
			return View(inscripcion);
		}

		// POST: InscripClubs/Edit/5
		// Método que recibe los datos del formulario para modificar una inscripción.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(InscripcionClub inscripcion)
		{
			if (ModelState.IsValid)
			{
				// Llama al método de la lógica de negocio para modificar la inscripción.
				inscrpBL.ModiInscripcion(inscripcion);
				// Redirige al listado de inscripciones tras modificar la inscripción.
				return RedirectToAction("Index");
			}

			// Si el modelo no es válido, retorna la misma vista para mostrar errores.
			return View(inscripcion);
		}
	}
}

