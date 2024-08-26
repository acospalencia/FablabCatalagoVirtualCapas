using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con la creación de prototipos.
	/// </summary>
	public class CreacionProtoBL
	{
		// Instancia de la capa de acceso a datos para la creación de prototipos.
		CreacionProtoDAL creDAl = new CreacionProtoDAL();

		/// <summary>
		/// Guarda una nueva creación de prototipo en la base de datos.
		/// </summary>
		/// <param name="pCreac">Instancia del objeto CreacionProto a guardar.</param>
		/// <returns>El identificador de la creación guardada.</returns>
		public int GuardarCrea(CreacionProto pCreac)
		{
			return creDAl.GuardarCreacion(pCreac);
		}
	}

}
