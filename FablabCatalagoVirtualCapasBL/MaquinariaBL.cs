using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
	/// <summary>
	/// Clase que maneja la lógica de negocio relacionada con la maquinaria.
	/// </summary>
	public class MaquinariaBL
	{
		// Instancia de la capa de acceso a datos para la maquinaria.
		MaquinariaDAL maquinariaDAL = new MaquinariaDAL();

		/// <summary>
		/// Obtiene la lista completa de maquinarias desde la base de datos.
		/// </summary>
		/// <returns>Lista de maquinarias.</returns>
		public List<Maquinaria> MaquinariaList()
		{
			return maquinariaDAL.RegresarMaquinaria();
		}

		/// <summary>
		/// Muestra los detalles de una maquinaria específica según su identificador.
		/// </summary>
		/// <param name="Id">El identificador de la maquinaria a mostrar.</param>
		/// <returns>Una instancia del objeto Maquinaria con los detalles de la maquinaria solicitada.</returns>
		public Maquinaria MostrarPorIdMaquinaria(int Id)
		{
			return maquinariaDAL.MostrarPorIdMaquinaria(Id);
		}

		/// <summary>
		/// Guarda una nueva maquinaria en la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Instancia del objeto Maquinaria a guardar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int GuardarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.GuardarMaquinaria(pMaquinaria);
		}

		/// <summary>
		/// Actualiza los datos de una maquinaria existente en la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Instancia del objeto Maquinaria con los datos actualizados.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int ActualizarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.ActualizarMaquinaria(pMaquinaria);
		}

		/// <summary>
		/// Elimina una maquinaria de la base de datos.
		/// </summary>
		/// <param name="pMaquinaria">Instancia del objeto Maquinaria a eliminar.</param>
		/// <returns>El número de filas afectadas en la base de datos.</returns>
		public int EliminarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.EliminarMaquinaria(pMaquinaria);
		}
	}

}
