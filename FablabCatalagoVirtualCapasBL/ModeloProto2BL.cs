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
	public class ModeloProto2BL
	{
		ModeloProto2DAL modeloProto2DAL = new ModeloProto2DAL();
		public ModeloProto2 MostrarPrototi(Prototipo pPrototipo)
		{
			return modeloProto2DAL.MostrarInfo(pPrototipo);
		}
	}
}
