using ClinicaSePriseApp.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class InsumoService
    {
        // INYECCION
        private static InsumoRepository insumoRepo = new InsumoRepository();

        // CREATE
        public static void CrearInsumo(Entidades.E_Insumo insumo)
        {
            insumoRepo.GuardarInsumo(insumo);
        }

        // READ
        public static List<Entidades.E_Insumo> ObtenerInsumos()
        {
            return insumoRepo.ObtenerInsumos();
        }

        public static Entidades.E_Insumo? ObtenerInsumoPorId(int idInsumo)
        {
            return insumoRepo.ObtenerInsumoPorId(idInsumo);
        }

    }
}