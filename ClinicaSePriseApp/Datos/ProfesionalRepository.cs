using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class ProfesionalRepository
    {
        // CREATE
        public void GuardarProfesional(E_Profesional nuevoProfesional)
        {
            DDBB_Simulation.ProfesionalesDB.Add(nuevoProfesional);
        }

        // READ
        public List<E_Profesional> TraerTodosLosProfesionales()
        {
            return DDBB_Simulation.ProfesionalesDB;
        }

        public E_Profesional? ObtenerProfesionalPorID(int id)
        {
            E_Profesional? profesionalEncontrado = DDBB_Simulation.ProfesionalesDB.FirstOrDefault(t => t.IdProfesional == id);
            return profesionalEncontrado;
        }
    }
}
