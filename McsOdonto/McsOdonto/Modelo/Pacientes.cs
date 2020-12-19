using System;
using System.Collections.Generic;
using System.Text;

namespace McsOdonto.Modelo
{
    public class Pacientes
    {
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string FechaCita { get; set; }
        public string HoraCita { get; set; }
        public int TotalDinero { get; set; }
        public int Abono { get; set; }
        public Pacientes()
        {
            // constructor

        }
    }
}
