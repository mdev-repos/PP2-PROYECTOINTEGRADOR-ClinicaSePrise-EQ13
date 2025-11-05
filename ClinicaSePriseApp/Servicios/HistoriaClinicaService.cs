using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class HistoriaClinicaService
    {
        private static HistoriaClinicaRepository historiaRepo = new HistoriaClinicaRepository();

        // Read
        public static E_HistoriaClinica ObtenerHistoriaClinica(string idHistoriaClinica)
        {
            return historiaRepo.ObtenerHistoriaClinica(idHistoriaClinica);
        }
    }
}
