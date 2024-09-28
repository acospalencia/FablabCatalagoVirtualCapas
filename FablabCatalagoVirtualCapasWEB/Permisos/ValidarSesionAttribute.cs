using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB.Permisos
{
	public class ValidarSesionAttribute : ActionFilterAttribute
	{

		public override void OnActionExecuting(ActionExecutingContext filterContext)
		{
			// Deshabilitar cache para que no se pueda acceder a las páginas mediante el botón de atrás
			filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
			filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
			filterContext.HttpContext.Response.Cache.SetNoStore();

			// Verificar si hay sesión activa
			if (HttpContext.Current.Session["Autor"] == null)
			{
				filterContext.Result = new RedirectResult("/Autores/InciarSesion");
			}

			base.OnActionExecuting(filterContext);
		}

	}
}