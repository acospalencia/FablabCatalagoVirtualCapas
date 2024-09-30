using System;
using System.Web;
using System.Web.Mvc;

namespace FablabCatalagoVirtualCapasWEB
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			// Filtros ya existentes
			filters.Add(new HandleErrorAttribute());

			// Agregar el filtro de NoCache
			filters.Add(new NoCacheAttribute());
		}
	}

	// Filtro para deshabilitar la cache del navegador
	public class NoCacheAttribute : ActionFilterAttribute
	{
		public override void OnResultExecuting(ResultExecutingContext filterContext)
		{
			filterContext.HttpContext.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
			filterContext.HttpContext.Response.Cache.SetCacheability(HttpCacheability.NoCache);
			filterContext.HttpContext.Response.Cache.SetNoStore();

			base.OnResultExecuting(filterContext);
		}
	}
}
