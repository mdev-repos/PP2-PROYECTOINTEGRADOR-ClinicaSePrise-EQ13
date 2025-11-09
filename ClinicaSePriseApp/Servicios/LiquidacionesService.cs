using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class LiquidacionesService
    {
        // INYECCION
        private static LiquidacionRepository liquidacionRepo = new LiquidacionRepository();

        // CREATE
        public static void GuardarLiquidacion(E_Liquidacion nuevaLiquidacion)
        {
            liquidacionRepo.GuardarLiquidacion(nuevaLiquidacion);
        }

        // READ
        public static List<E_Liquidacion> ObtenerLiquidaciones()
        {
            return liquidacionRepo.ObtenerLiquidaciones();
        }
        public static E_Liquidacion? ObtenerLiquidacionPorId(int idLiquidacion)
        {
            return liquidacionRepo.ObtenerLiquidacionPorId(idLiquidacion);
        }
    }
}
