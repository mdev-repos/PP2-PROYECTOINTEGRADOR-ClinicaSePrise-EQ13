using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class TurnoService
    {
        // GUARDAR TURNO EN BBDD SIMULADA
        public static void GuardarTurno(E_Turno nuevoTurno)
        {
            DDBB_Simulation.TurnosDB.Add(nuevoTurno);
        }

        // CREAR AGENDA MEDICA
        public static List<E_Turno> CrearAgendaMedica(int idProfesional, DateOnly dia)
        {
            List<E_Turno> agendaDia = new List<E_Turno>();

            // Buscar Profesional por ID
            E_Profesional? profesionalEncontrado = ProfesionalService.ObtenerProfesionalPorID(idProfesional);            

            // Obtener horario inicial y final
            DayOfWeek day = dia.DayOfWeek;

            List<E_Disponibilidad> dispo = profesionalEncontrado.Disponibilidades;

            E_Disponibilidad disponible = dispo.FirstOrDefault(d => d.Dia == day);

            TimeSpan inicio = disponible.HoraInicio;

            TimeSpan fin = disponible.HoraFin;

            TimeSpan duracion;

            decimal valorConsulta;

            switch (profesionalEncontrado.Especialidad)
            {
                case Entidades.Enums.EspecialidadMedica.NEUROLOGIA:
                    duracion = new TimeSpan(0, 35, 0);
                    valorConsulta = 5000m;
                    break;

                case Entidades.Enums.EspecialidadMedica.UROLOGIA:
                    duracion = new TimeSpan(0, 25, 0);
                    valorConsulta = 4000m;
                    break;

                default:
                    duracion = new TimeSpan(0, 15, 0);
                    valorConsulta = 3000m;
                    break;
            }

            // Creacion de turnos
            while((inicio + duracion) <= fin)
            {
                TimeOnly horaTurno = TimeOnly.FromTimeSpan(inicio);
                DateTime fechaTurno = dia.ToDateTime(horaTurno);
                
                E_Turno turno = new E_Turno(
                    DDBB_Simulation.TurnosDB.Count + 1,
                    fechaTurno,
                    profesionalEncontrado.IdProfesional,
                    valorConsulta
                    );

                // Guardar turno en la base de datos simulada
                GuardarTurno(turno);

                // Anadir turno a la agenda del dia del profesional
                agendaDia.Add(turno);

                // Actualizar horario de proximo turno
                inicio = inicio + duracion;
            }

            return agendaDia;
        }

        // LEER TURNO O TURNOS
        public static E_Turno? ObtenerTurnoPorID(int id)
        {
            E_Turno? turnoEncontrado = DDBB_Simulation.TurnosDB.FirstOrDefault(t => t.IdTurno == id);
            return turnoEncontrado;
        }

        public static List<E_Turno> ObtenerTodosLosTurnos()
        {
            return DDBB_Simulation.TurnosDB;
        }

        // Update
        // Delete
    }
}
