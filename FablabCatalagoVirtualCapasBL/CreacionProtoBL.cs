using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FablabCatalagoVirtualCapasBL
{
	public class CreacionProtoBL
	{
		CreacionProtoDAL creDAl = new CreacionProtoDAL();
		public int GuardarCrea(CreacionProto pCreac)
		{
			return creDAl.GuardarCreacion(pCreac);
		}
	}
}
