using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSolucionDescunetos.Controllers
{
    public class logUsuarios
    {
        public int Id { get; set; }
        public string usuario { get; set; }

        public DateTime FechaModificacion { get; set; }
        public string Modificadoproducto { get; set; }

        public string[] Notas { get; set; }
       
    }
}
