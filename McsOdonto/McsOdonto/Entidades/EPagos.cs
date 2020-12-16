using System;
using System.Collections.Generic;
using System.Text;

namespace McsOdonto.Entidades
{
    public class EPagos
    {
        public int cod_prod { get; set; }
        public string nombre_prod { get; set; }
        public int cantidad { get; set; }
        public int id_producto { get; set; }
        public int numero_orden_general { get; set; }
        public string tipo { get; set; }
        public string resultado { get; set; }
        public int id_factura_temporal { get; set; }

    }
}
