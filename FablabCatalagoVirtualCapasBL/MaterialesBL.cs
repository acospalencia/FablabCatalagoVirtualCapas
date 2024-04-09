using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FablabCatalagoVirtualCapasDAL;
using FablabCatalagoVirtualCapasEN;

namespace FablabCatalagoVirtualCapasBL
{
    public class MaterialesBL
    {
        private MaterialesDAL materialesDAL = new MaterialesDAL();

        public void guardarMaterial(Materiales pMateriales)
        {
            materialesDAL.guardarMaterial(pMateriales);
        }
        public void actualizarMateriales(Materiales pMateriales)
        {
            materialesDAL.actualizarMaterial(pMateriales);
        }
           public List<Materiales> regresarLista ()
        {
            return materialesDAL.regresarLista();        
        }
    }
}
