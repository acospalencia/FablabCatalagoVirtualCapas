using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Configuration;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los modelos de prototipos.
	/// </summary>
	public class ModeloProto2BL
	{
		// Instancia de la capa de acceso a datos para los modelos de prototipos.
		ModeloProto2DAL modeloProto2DAL = new ModeloProto2DAL();

		/// <summary>
		/// Muestra la información de un prototipo específico.
		/// </summary>
		/// <param name="pPrototipo">Instancia del objeto Prototipo cuyo modelo se va a mostrar.</param>
		/// <returns>Una instancia del objeto ModeloProto2 con la información del prototipo solicitado.</returns>
		public ModeloProto2 MostrarPrototi(Prototipo pPrototipo)
		{
			return modeloProto2DAL.MostrarInfo(pPrototipo);
		}
	}

}
