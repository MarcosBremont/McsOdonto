using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMcsOdon
{
    public class PagoHistorial
    {
        public List<EPagoHistorial> ListadoDeOrdenes(int tiposervicio, int tecnico, string progreso_orden)
        {
            List<EPagoHistorial> lista_orden_servi = new List<EPagoHistorial>();

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("API_SlistaOrden", GetCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("prm_tiposervicio", MySqlDbType.Int32).Value = tiposervicio;
            cmd.Parameters.Add("prm_tecnico", MySqlDbType.Int32).Value = tecnico;
            cmd.Parameters.Add("prm_progreso_orden", MySqlDbType.VarChar).Value = progreso_orden;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                var result = JsonConvert.SerializeObject(dt, Formatting.Indented);
                lista_orden_servi = JsonConvert.DeserializeObject<List<EPagoHistorial>>(result, new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
            }

            return lista_orden_servi;
        }
    }
}
