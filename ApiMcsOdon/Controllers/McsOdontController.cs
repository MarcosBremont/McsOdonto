using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMcsOdon.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class McsOdontController : ControllerBase
    {
        [HttpGet("ConsultarListadoDePagos/{tiposervicio}/{id_tecnico}/{progreso_orden}")]
        public ActionResult<IEnumerable<EPagoHistorial>> ConsultarListadoDePagos(int tiposervicio, int id_tecnico, string progreso_orden)
        {
            EPagoHistorial epagoHistorial = new EPagoHistorial();

            List<EPagoHistorial> lista_de_ordenes_por_tecnico = EPagoHistorial.ListadoDeOrdenes(tiposervicio, id_tecnico, progreso_orden);

            return lista_de_ordenes_por_tecnico;
        }
    }
}
