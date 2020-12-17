using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMcsOdon
{
    public class EPagoHistorial
    {
        public int idt_citapaciente { get; set; }
        public string nombre_Completo { get; set; }
        public int fecha_nacimiento { get; set; }
        public int totaldinero { get; set; }
        public int abono { get; set; }
        public string estado { get; set; }
    }
}
