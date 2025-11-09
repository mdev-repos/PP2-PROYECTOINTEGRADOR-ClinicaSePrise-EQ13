using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class ConsultorioRepository
    {
        // CREATE
        public void GuardarConsultorio(Entidades.E_Consultorio consultorio)
        {
            DDBB_Simulation.ConsultoriosDB.Add(consultorio);
        }

        // READ
        public List<Entidades.E_Consultorio> ObtenerConsultorios()
        {
            return DDBB_Simulation.ConsultoriosDB;
        }
        public Entidades.E_Consultorio? ObtenerConsultorioPorId(int idConsultorio)
        {
            return DDBB_Simulation.ConsultoriosDB.FirstOrDefault(c => c.IdConsultorio == idConsultorio);
        }
    }
}
