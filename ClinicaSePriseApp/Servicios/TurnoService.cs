using ClinicaSePriseApp.Datos;
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
        // Inyeccion de dependencia simple
        private static TurnoRepository turnoRepo = new TurnoRepository();


        // CREATE
        public static void GuardarTurno(E_Turno nuevoTurno)
        {
            turnoRepo.GuardarTurno(nuevoTurno);
        }              

        /*
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
        */

        // READ
        public static E_Turno? ObtenerTurnoPorID(int id)
        {
            return turnoRepo.ObtenerTurnoPorID(id);
        }

        public static List<E_Turno> ObtenerTodosLosTurnos()
        {
            return turnoRepo.TraerTodosLosTurnos();
        }


        // UPDATE
        public static void AsignarTurno(E_Turno turno, E_Paciente paciente)
        {
            turno.IdPaciente = paciente.IdPaciente;
            turno.Estado = Entidades.Enums.EstadoTurno.ASIGNADO;
            
            // Actualizar en la base de datos simulada
            // turnoRepo.ActualizarTurno(turno);

            paciente.Reservas.Add(turno);

            // Actualizar en la base de datos simulada
            // pacienteRepo.ActualizarPaciente(paciente);

        }
    }
}