using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	/// <summary>
	/// Representa una compra de materiales.
	/// </summary>
	public class CompraMate
	{
		/// <summary>
		/// Identificador único de la compra.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Identificador del material comprado.
		/// </summary>
		public int IdMaterial { get; set; }

		/// <summary>
		/// Identificador del proveedor que suministra el material.
		/// </summary>
		public int IdProveedor { get; set; }

		/// <summary>
		/// Cantidad de material comprada.
		/// </summary>
		public string CantidadCompra { get; set; }

		/// <summary>
		/// Total a pagar por la compra.
		/// </summary>
		public decimal TotalPagar { get; set; }
	}

}
