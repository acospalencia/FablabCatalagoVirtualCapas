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
			if (HttpContext.Current.Session["Autor"] == null)
			{
				filterContext.Result = new RedirectResult("/Autores/InciarSesion");
			}

			base.OnActionExecuting(filterContext);
		}

	}
}