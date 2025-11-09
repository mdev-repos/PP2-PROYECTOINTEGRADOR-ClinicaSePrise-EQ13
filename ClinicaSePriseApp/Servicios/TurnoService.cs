using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class TurnoService
    {
        // INYECCION
        private static TurnoRepository turnoRepo = new TurnoRepository();


        // CREATE
        public static void GuardarTurno(E_Turno nuevoTurno)
        {
            turnoRepo.GuardarTurno(nuevoTurno);
        }

        public static E_Turno CrearTurno(DateTime fecha, E_Profesional profesional, E_Paciente paciente)
        {
            // Monto
            decimal monto = CalcularMontoTurno(profesional);

            E_Turno turno = new E_Turno(
                fecha,
                profesional.IdProfesional,
                paciente.IdPaciente,
                monto,
                Entidades.Enums.EstadoTurno.ASIGNADO
                );

            GuardarTurno(turno);

            return turno;
        }

        public static void CrearAgendaMedica(E_Profesional profesional, DateOnly dia)
        {
            DayOfWeek day = dia.DayOfWeek;

            E_Disponibilidad disponibilidad = profesional.Disponibilidades.FirstOrDefault(d => d.Dia == day);

            TimeSpan inicio = disponibilidad.HoraInicio;

            TimeSpan fin = disponibilidad.HoraFin;

            TimeSpan duracion;

            decimal valorConsulta;

            switch (profesional.Especialidad)
            {
                case Entidades.Enums.EspecialidadMedica.NEUROLOGIA:
                    duracion = new TimeSpan(0, 45, 0);
                    valorConsulta = 5000m;
                    break;

                case Entidades.Enums.EspecialidadMedica.UROLOGIA:
                    duracion = new TimeSpan(0, 30, 0);
                    valorConsulta = 4000m;
                    break;

                default:
                    duracion = new TimeSpan(0, 15, 0);
                    valorConsulta = 3000m;
                    break;
            }

            while((inicio + duracion) <= fin)
            {
                TimeOnly horaTurno = TimeOnly.FromTimeSpan(inicio);
                DateTime fechaTurno = dia.ToDateTime(horaTurno);
                
                E_Turno turno = new E_Turno(
                    fechaTurno,
                    profesional.IdProfesional,
                    valorConsulta
                    );

                GuardarTurno(turno);

                ProfesionalService.AgregarTurnoEnAgenda(profesional, turno);

                inicio = inicio + duracion;
            }
        }

        // DEFINIR VALORES DE MONTO SEGUN ESPECIALIDAD
        private static decimal CalcularMontoTurno(E_Profesional profesional)
        {
            decimal monto;
            switch (profesional.Especialidad)
            {
                case Entidades.Enums.EspecialidadMedica.NEUROLOGIA:
                    monto = 15000m;
                    break;
                case Entidades.Enums.EspecialidadMedica.CARDIOLOGIA:
                    monto = 13500m;
                    break;
                default:
                    monto = 10000m;
                    break;
            }
            return monto;
        }
        
        // READ
        public static E_Turno? ObtenerTurnoPorID(int id)
        {
            return turnoRepo.ObtenerTurnoPorID(id);
        }

        public static List<E_Turno> ObtenerTodosLosTurnos()
        {
            return turnoRepo.TraerTodosLosTurnos();
        }

        public static List<E_Turno> ObtenerTurnosDelDia(E_Profesional profesional, DateOnly fecha)
        {
            return profesional.AgendaMedica
                .Where(t => DateOnly.FromDateTime(t.FechaTurno) == fecha)
                .OrderBy(t => t.FechaTurno)
                .ToList();
        }


        // UPDATE (CAMBIOS DE ESTADO)
        public static void AsignarTurno(E_Turno turno, E_Paciente paciente)
        {
            turno.IdPaciente = paciente.IdPaciente;
            turno.Estado = Entidades.Enums.EstadoTurno.ASIGNADO;

            paciente.Reservas.Add(turno);            
        }

        public static void CancelarTurno(E_Turno turno)
        { 
            var paciente = PacienteService.ObtenerPacientePorID(turno.IdPaciente);

            if (paciente != null) 
            {
                paciente.Reservas.Remove(turno);
            }

            turno.IdPaciente = null;

            turno.Estado = Entidades.Enums.EstadoTurno.DISPONIBLE;
        }


        // DELETE (SOLO SIMULACION - LUEGO IMPLEMENTAR BOOLEANO DE BORRADO LOGICO)
        public static void EliminarTurno(E_Turno turno)
        {
            turnoRepo.EliminarTurno(turno);
        }
    }
}