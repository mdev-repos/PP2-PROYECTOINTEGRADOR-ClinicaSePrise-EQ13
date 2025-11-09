using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
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
        public static void CrearInsumo(E_Insumo insumo)
        {
            insumoRepo.GuardarInsumo(insumo);
        }

        // READ
        public static List<E_Insumo> ObtenerInsumos()
        {
            return insumoRepo.ObtenerInsumos();
        }

        public static E_Insumo? ObtenerInsumoPorId(int idInsumo)
        {
            return insumoRepo.ObtenerInsumoPorId(idInsumo);
        }

    }
}