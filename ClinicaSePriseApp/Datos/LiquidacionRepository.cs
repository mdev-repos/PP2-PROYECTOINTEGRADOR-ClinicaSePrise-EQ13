using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class LiquidacionRepository
    {
        // CREATE
        public void GuardarLiquidacion(E_Liquidacion liquidacion)
        {
            DDBB_Simulation.LiquidacionesDB.Add(liquidacion);
        }

        // READ
        public List<E_Liquidacion> ObtenerLiquidaciones()
        {
            return DDBB_Simulation.LiquidacionesDB;
        }
        public E_Liquidacion? ObtenerLiquidacionPorId(int idLiquidacion)
        {
            return DDBB_Simulation.LiquidacionesDB
                .FirstOrDefault(l => l.IdLiquidacion == idLiquidacion);
        }
    }
}
