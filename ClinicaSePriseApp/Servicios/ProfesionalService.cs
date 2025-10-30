using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;

namespace ClinicaSePriseApp.Servicios
{
    public class ProfesionalService
    {
        // Create
        public static void GuardarProfesional(E_Profesional nuevoProfesional)
        {            
            DDBB_Simulation.ProfesionalesDB.Add(nuevoProfesional);
        }


        // Read
        public static E_Profesional? ObtenerProfesionalPorID(int id)
        {
            E_Profesional? profesionalEncontrado = DDBB_Simulation.ProfesionalesDB.FirstOrDefault(p => p.IdProfesional == id);

            return profesionalEncontrado;
        }

        public static List<E_Profesional> ObtenerTodosLosProfesionales()
        {
            return DDBB_Simulation.ProfesionalesDB;
        }

        

        // Update

        // Delete
    }
}
