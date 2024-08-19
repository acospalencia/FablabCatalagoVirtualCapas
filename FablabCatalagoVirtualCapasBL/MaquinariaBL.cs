using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
	public class MaquinariaBL
	{
		MaquinariaDAL maquinariaDAL = new MaquinariaDAL();
		public List<Maquinaria> MaquinariaList()
		{
			return maquinariaDAL.RegresarMaquinaria();
		}
		public Maquinaria MostrarPorIdMaquinaria(int Id)
		{
			return maquinariaDAL.MostrarPorIdMaquinaria(Id);
		}
		public int GuardarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.GuardarMaquinaria(pMaquinaria);
		}
		public int ActualizarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.ActualizarMaquinaria(pMaquinaria);
		}
		public int EliminarMaquinaria(Maquinaria pMaquinaria)
		{
			return maquinariaDAL.EliminarMaquinaria(pMaquinaria);
		}
	}
}
