using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;

namespace ClinicaSePriseApp.Servicios
{
    public class ProfesionalService
    {
        // Inyeccion de dependencia simple
        public static ProfesionalRepository profRepo = new ProfesionalRepository();

        // Create
        public static void GuardarProfesional(E_Profesional nuevoProfesional)
        {
            profRepo.GuardarProfesional(nuevoProfesional);
        }


        // Read
        public static E_Profesional? ObtenerProfesionalPorID(int id)
        {
            return profRepo.ObtenerProfesionalPorID(id);
        }

        public static List<E_Profesional> ObtenerTodosLosProfesionales()
        {
            return profRepo.TraerTodosLosProfesionales();
        }

        

        // Update

        // Delete
    }
}
