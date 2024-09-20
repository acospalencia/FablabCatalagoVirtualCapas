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
	/// Clase que maneja la lógica de negocio relacionada con los materiales.
	/// </summary>
	public class MaterialesBL
	{
		// Instancia de la capa de acceso a datos para los materiales.
		private MaterialesDAL materialesDAL = new MaterialesDAL();

		/// <summary>
		/// Guarda un nuevo material en la base de datos.
		/// </summary>
		/// <param name="pMateriales">Instancia del objeto Materiales a guardar.</param>
		public void guardarMaterial(Materiales pMateriales)
		{
			materialesDAL.guardarMaterial(pMateriales);
		}

		/// <summary>
		/// Actualiza los datos de un material existente en la base de datos.
		/// </summary>
		/// <param name="pMateriales">Instancia del objeto Materiales con los datos actualizados.</param>
		public void actualizarMateriales(Materiales pMateriales)
		{
			materialesDAL.actualizarMaterial(pMateriales);
		}

		/// <summary>
		/// Obtiene la lista completa de materiales desde la base de datos.
		/// </summary>
		/// <returns>Lista de materiales.</returns>
		public List<Materiales> regresarLista()
		{
			return materialesDAL.regresarLista();
		}

		/// <summary>
		/// Elimina un material de la base de datos.
		/// </summary>
		/// <param name="pMateriales">Instancia del objeto Materiales a eliminar.</param>
		public void eliminarMaterial(Materiales pMateriales)
		{
			materialesDAL.eliminarMateriales(pMateriales);
		}

		/// <summary>
		/// Muestra los detalles de un material específico según su identificador.
		/// </summary>
		/// <param name="Id">El identificador del material a mostrar.</param>
		/// <returns>Una instancia del objeto Materiales con los detalles del material solicitado.</returns>
		public Materiales MostrarPorIdMateriales(int Id)
		{
			return materialesDAL.MostrarPorIdMateriales(Id);
		}
	}

}
