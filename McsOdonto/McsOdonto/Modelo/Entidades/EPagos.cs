using System;
using System.Collections.Generic;
using System.Text;

namespace McsOdonto.Entidades
{
    public class EPagos
    {
        public int idt_citapaciente { get; set; }
        public string nombre_Completo { get; set; }
        public int fecha_nacimiento { get; set; }
        public int totaldinero { get; set; }
        public int abono { get; set; }
        public string estado { get; set; }

    }
}
