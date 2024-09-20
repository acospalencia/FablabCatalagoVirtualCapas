using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasEN;
using FablabCatalagoVirtualCapasDAL;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con los prototipos.
	/// </summary>
	public class PrototipoBL
	{
		// Instancia de la capa de acceso a datos para los prototipos.
		PrototipoDAL PrototiposDAL = new PrototipoDAL();

		/// <summary>
		/// Guarda un nuevo prototipo en la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Instancia del objeto Prototipo a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int Guardar(Prototipo pPrototipo)
		{
			return PrototiposDAL.guardarNuevoPrototipo(pPrototipo);
		}

		/// <summary>
		/// Modifica un prototipo existente en la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Instancia del objeto Prototipo con los datos modificados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int Modificar(Prototipo pPrototipo)
		{
			return PrototiposDAL.ModificarPrototipo(pPrototipo);
		}

		/// <summary>
		/// Elimina un prototipo de la base de datos.
		/// </summary>
		/// <param name="pPrototipo">Instancia del objeto Prototipo a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int Eliminar(Prototipo pPrototipo)
		{
			return PrototiposDAL.EliminarPrototipo(pPrototipo);
		}

		/// <summary>
		/// Obtiene la lista completa de prototipos desde la base de datos.
		/// </summary>
		/// <returns>Lista de objetos Prototipo.</returns>
		public List<Prototipo> regresarlista()
		{
			return PrototiposDAL.RegresarLista();
		}

		/// <summary>
		/// Obtiene el identificador del último prototipo insertado en la base de datos.
		/// </summary>
		/// <returns>El identificador del último prototipo insertado.</returns>
		public int RegresarIdProto()
		{
			return PrototiposDAL.RegresarIdProto();
		}
	}

}
