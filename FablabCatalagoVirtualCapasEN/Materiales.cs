using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace FablabCatalagoVirtualCapasEN
{
    public class Materiales
    {
        public int Id {  get; set; }
        public string nombreMaterial {  get; set; }
        public string tipoMaterial { get; set; }
        public double precio { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }
        public string proveedor { get; set; }

    }
}
