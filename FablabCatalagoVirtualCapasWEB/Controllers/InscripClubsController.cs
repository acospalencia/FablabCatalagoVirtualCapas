using FablabCatalagoVirtualCapasBL; // Lógica de negocio
using FablabCatalagoVirtualCapasEN; // Entidades
using FablabCatalagoVirtualCapasWEB.Permisos;
using System;
using System.Linq;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Controllers
{
	[ValidarSesion]

	public class InscripClubsController : Controller
	{
		// Instancia de la lógica de negocio para interactuar con los datos de inscripción.
		private InscripcionClubBL inscrpBL = new InscripcionClubBL();
		private ClubBL clubBL = new ClubBL(); // Lógica de negocio para Club

		// GET: InscripClubs
		// Método para listar todas las inscripciones.
		public ActionResult Index()
		{
			var autor = Session["Autor"] as Autores;
			if (autor != null)
			{
				// Llama al método de la lógica de negocio para obtener todas las inscripciones.
				var inscripciones = inscrpBL.RegresarLista().Where(c => c.IdAutor == autor.Id).ToList();

				return View(inscripciones);
			}
			else
			{
				return RedirectToAction("InciarSesion", "Autores");
			}
			
		}

		// GET: InscripClubs/Details/5
		// Método que muestra los detalles de una inscripción específica por su ID.
		public ActionResult Details(int id)
		{
			// Busca la inscripción por ID en la lista.
			var inscripcion = inscrpBL.RegresarLista().FirstOrDefault(i => i.Id == id);

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
			// Obtener el autor de la sesión
			if (Session["Autor"] is Autores autor) // Asegurarse que "Autor" es del tipo correcto
			{
				// Cargar la lista de clubes
				var clubes = clubBL.RegresarLista();

				// Pasar la lista de clubes a la vista
				ViewBag.Clubes = new SelectList(clubes, "Id", "NombreClub");

				// Crear un modelo para la vista
				var model = new InscripcionClub
				{
					IdAutor = autor.Id // Asignar el ID del autor al modelo
				};

				return View(model);
			}

			// Si la sesión no es válida, redirigir a la página de inicio de sesión
			return RedirectToAction("Login", "Account"); // Cambia esto según tu lógica
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

			// Si el modelo no es válido, recarga la lista de clubes
			var clubes = clubBL.RegresarLista();
			ViewBag.Clubes = new SelectList(clubes, "Id", "NombreClub", inscripcion.IdClub);

			// Retorna la misma vista para mostrar errores
			return View(inscripcion);
		}

		// GET: InscripClubs/Edit/5
		// Método que muestra el formulario para editar una inscripción existente.
		public ActionResult Edit(int id)
		{
			// Busca la inscripción por ID.
			var inscripcion = inscrpBL.RegresarLista().FirstOrDefault(i => i.Id == id);

			// Si no se encuentra la inscripción, retorna un error 404.
			if (inscripcion == null)
			{
				return HttpNotFound();
			}

			// Cargar la lista de clubes
			var clubes = clubBL.RegresarLista();
			ViewBag.Clubes = new SelectList(clubes, "Id", "NombreClub", inscripcion.IdClub);

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

			// Si el modelo no es válido, recarga la lista de clubes
			var clubes = clubBL.RegresarLista();
			ViewBag.Clubes = new SelectList(clubes, "Id", "NombreClub", inscripcion.IdClub);

			// Retorna la misma vista para mostrar errores
			return View(inscripcion);
		}
	}
}
