using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSolucionDescunetos.Modelos
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public string nombreProducto{get;set;}
        public double precio { get; set; }
        public double descuento { get; set; }
    }
}
