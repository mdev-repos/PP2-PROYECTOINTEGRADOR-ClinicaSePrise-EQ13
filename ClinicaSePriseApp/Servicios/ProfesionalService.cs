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

        public static void AgregarTurnoEnAgenda(E_Profesional profesional, E_Turno turno)
        { 
            profesional.AgendaMedica.Add(turno);
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

        public static E_Profesional? ObtenerProfesionalPorNombreCompleto(string nombreCompleto)
        {
            return profRepo.ObtenerProfesionalPorNombreCompleto(nombreCompleto);
        }

        public static List<DayOfWeek> ObtenerDiasDisponibles(E_Profesional profesional)
        {
            if (profesional?.Disponibilidades == null)
                return new List<DayOfWeek>();

            return profesional.Disponibilidades
                .Select(d => d.Dia)
                .Distinct()
                .ToList();
        }

        // Update

        // Delete
        public static void EliminarTurnoDeAgenda(E_Profesional profesional, E_Turno turno)
        { 
            profesional.AgendaMedica.Remove(turno);
        }
    }
}
