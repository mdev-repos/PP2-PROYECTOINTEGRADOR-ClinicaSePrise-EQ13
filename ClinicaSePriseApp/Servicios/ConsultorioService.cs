using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class ConsultorioService
    {
        // INYECCION
        private static ConsultorioRepository consultorioRepo = new ConsultorioRepository();
        
        // CREATE
        public static void CrearConsultorio(E_Consultorio consultorio)
        {
            consultorioRepo.GuardarConsultorio(consultorio);
        }

        // READ
        public static List<E_Consultorio> ObtenerConsultorios()
        {
            return consultorioRepo.ObtenerConsultorios();
        }
        public static E_Consultorio? ObtenerConsultorioPorId(int idConsultorio)
        {
            return consultorioRepo.ObtenerConsultorioPorId(idConsultorio);
        }

        public static int ObtenerConsultorioPorProfesional(int idProfesional)
        {
            return consultorioRepo.ObtenerConsultorios().FirstOrDefault(c => c.IdProfesional == idProfesional)?.IdConsultorio ?? -1;
        }
    }
}
