using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasEN
{
	public class CompraMate
	{
		public int Id { get; set; }
		public int IdMaterial { get; set; }
		public int IdProveedor { get; set; }
		public string CantidadCompra { get; set; }
		public decimal TotalPagar { get; set; }
	}
}
