using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los modelos de prototipos.
	/// </summary>
	public class ModeloPrototipoBL
	{
		// Instancia de la capa de acceso a datos para los modelos de prototipos.
		ModeloPrototipoDAL modelo = new ModeloPrototipoDAL();

		/// <summary>
		/// Obtiene la lista completa de modelos de prototipos desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos ModeloPrototipo.</returns>
		public List<ModeloPrototipo> RegresarListaModelo()
		{
			return modelo.RegresarListaModelo();
		}
	}

}
