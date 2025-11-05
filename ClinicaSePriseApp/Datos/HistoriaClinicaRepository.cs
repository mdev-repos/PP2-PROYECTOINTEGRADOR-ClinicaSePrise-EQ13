using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using ClinicaSePriseApp.Vistas.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class HistoriaClinicaRepository
    {
        public E_HistoriaClinica ObtenerHistoriaClinica(string idHistoriaClinica)
        {
            E_HistoriaClinica? historiaClinica =
                DDBB_Simulation.HistoriasClinicas.FirstOrDefault(t => t.IdHistoriaClinica == idHistoriaClinica);

            return historiaClinica;
        }
    }
}
