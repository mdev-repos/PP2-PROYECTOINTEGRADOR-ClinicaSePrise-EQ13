using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Utilidades
{
    public static class DDBB_Simulation
    {
        public static List<E_Administrativo> AdministrativosDB { get; set; } = new List<E_Administrativo>();
        public static List<E_Profesional> ProfesionalesDB { get; set; } = new List<E_Profesional>();
        public static List<E_Usuario> UsuariosDB { get; set; } = new List<E_Usuario>();
        public static List<E_Paciente> PacientesDB { get; set; } = new List<E_Paciente>();
        public static List<E_Turno> TurnosDB { get; set; } = new List<E_Turno>();
        public static List<E_Insumo> InsumosDB { get; set; } = new List<E_Insumo>();
        public static List<E_Consultorio> ConsultoriosDB { get; set; } = new List<E_Consultorio>();

        // CARGA DE DATOS DE PRUEBAS
        public static void InicializarDatosPrueba()
        {
            // LIMPIAR LISTAS
            AdministrativosDB.Clear();
            ProfesionalesDB.Clear();
            UsuariosDB.Clear();
            PacientesDB.Clear();
            TurnosDB.Clear();
            InsumosDB.Clear();
            ConsultoriosDB.Clear();


            // CARGA DE DATOS SIMULADOS

            // ADMINISTRATIVOS
                // Usuario
                var useradm1 = new E_Usuario(1, "mazzitelli", "1234", Rol.ADMINISTRATIVO);
            var administrativo1 = new E_Administrativo(
                1, 
                1,
                "Mazzitelli",
                "Matias",
                "22333555",
                Genero.H,
                new DateOnly(1989, 10, 2),
                "Calle Falsa 123",
                "1155579992",
                "admin1@seprise.com");
                
                // Usuario
                var useradm2 = new E_Usuario(2, "benitez", "1234", Rol.ADMINISTRATIVO);
            var administrativo2 = new E_Administrativo(
                2,
                2,
                "Benitez",
                "Guillermo",
                "33111555",
                Genero.H,
                new DateOnly(1992, 7, 12),
                "Calle Falsa 345",
                "1155577662",
                "admin2@seprise.com");

                // Usuario
                var useradm3 = new E_Usuario(3, "sposto", "1234", Rol.ADMINISTRATIVO);
            var administrativo3 = new E_Administrativo(
                3,
                3,
                "Sposto",
                "Orlando",
                "22111444",
                Genero.H,
                new DateOnly(1972, 2, 13),
                "Calle Falsa 567",
                "1166677662",
                "admin3@seprise.com");

                // Usuario
                var useradm4 = new E_Usuario(4, "dooren", "1234", Rol.ADMINISTRATIVO);
            var administrativo4 = new E_Administrativo(
                4,
                4,
                "Van Den Dooren",
                "Adriana",
                "33555663",
                Genero.M,
                new DateOnly(1982, 2, 13),
                "Calle Falsa 789",
                "1166677662",
                "admin4@seprise.com");

            UsuariosDB.Add(useradm1);
            AdministrativosDB.Add(administrativo1);

            UsuariosDB.Add(useradm2);
            AdministrativosDB.Add(administrativo2);

            UsuariosDB.Add(useradm3);
            AdministrativosDB.Add(administrativo3);

            UsuariosDB.Add(useradm4);
            AdministrativosDB.Add(administrativo4);



            // PROFESIONALES
                // Disponibilidad
                var disponibilidad1a = new E_Disponibilidad(
                        1,
                        DayOfWeek.Monday,
                        new TimeSpan(7, 0, 0),
                        new TimeSpan(13, 0, 0));

                var disponibilidad1b = new E_Disponibilidad(
                    2,
                    DayOfWeek.Tuesday,
                    new TimeSpan(10, 0, 0),
                    new TimeSpan(16, 0, 0));

                List<E_Disponibilidad> prof1disp = new List<E_Disponibilidad>();
                prof1disp.Add(disponibilidad1a);
                prof1disp.Add(disponibilidad1b);

                // Usuario
                E_Usuario userprof1 = new E_Usuario(5, "medico1", "1234", Rol.PROFESIONAL);

            var profesional1 = new E_Profesional(
                1,
                5,
                EspecialidadMedica.CLINICA_MEDICA,
                "123765",
                prof1disp,
                "Alvarez",
                "Ignacio",
                "22555444",
                Genero.X,
                new DateOnly(1993, 6, 18),
                "Casa di galeno",
                "1177558844",
                "profesional1@seprise.com");

            UsuariosDB.Add(userprof1);
            ProfesionalesDB.Add(profesional1);


            // Disponibilidad
            var disponibilidad2a = new E_Disponibilidad(
                    1,
                    DayOfWeek.Friday,
                    new TimeSpan(9, 0, 0),
                    new TimeSpan(15, 0, 0));

            var disponibilidad2b = new E_Disponibilidad(
                2,
                DayOfWeek.Wednesday,
                new TimeSpan(14, 0, 0),
                new TimeSpan(18, 0, 0));

            List<E_Disponibilidad> prof2disp = new List<E_Disponibilidad>();
            prof1disp.Add(disponibilidad2a);
            prof1disp.Add(disponibilidad2b);

            // Usuario
            E_Usuario userprof2 = new E_Usuario(6, "medico2", "1234", Rol.PROFESIONAL);

            var profesional2 = new E_Profesional(
                2,
                6,
                EspecialidadMedica.UROLOGIA,
                "9876543",
                prof2disp,
                "Galeno",
                "Julieta",
                "33772885",
                Genero.M,
                new DateOnly(2003, 4, 23),
                "Casa di galeno",
                "1177558844",
                "profesional2@seprise.com");

            UsuariosDB.Add(userprof2);
            ProfesionalesDB.Add(profesional2);



            // PACIENTES
            var paciente1 = new E_Paciente(
                1,
                "Perez",
                "Juan",
                "12988123",
                Genero.H,
                new DateOnly(1956, 12, 16),
                "Casa 321",
                "46759922",
                "correo1@prueba.com",
                ObraSocial.PARTICULAR,
                "1");


            var paciente2 = new E_Paciente(
                2,
                "Mesa",
                "Florinda",
                "16988123",
                Genero.M,
                new DateOnly(1976, 7, 29),
                "Casa 123",
                "47582948",
                "correo2@prueba.com",
                ObraSocial.SANCOR_SALUD,
                "600/123");

            PacientesDB.Add(paciente1);
            PacientesDB.Add(paciente2);



            // TURNOS
            var turno1 = new E_Turno(
                1,
                new DateTime(2025, 11, 3, 7, 0, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno1);
            profesional1.AgendaMedica.Add(turno1);

            var turno2 = new E_Turno(
                2,
                new DateTime(2025, 11, 3, 7, 15, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno2);
            profesional1.AgendaMedica.Add(turno2);

            var turno3 = new E_Turno(
                3,
                new DateTime(2025, 11, 3, 7, 30, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno3);
            profesional1.AgendaMedica.Add(turno3);

            var turno4 = new E_Turno(
                4,
                new DateTime(2025, 11, 3, 7, 45, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno4);
            profesional1.AgendaMedica.Add(turno4);

            var turno5 = new E_Turno(
                5,
                new DateTime(2025, 11, 3, 8, 0, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno5);
            profesional1.AgendaMedica.Add(turno5);

            var turno6 = new E_Turno(
                6,
                new DateTime(2025, 11, 3, 8, 15, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno6);
            profesional1.AgendaMedica.Add(turno6);

            var turno7 = new E_Turno(
                7,
                new DateTime(2025, 11, 3, 8, 30, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno7);
            profesional1.AgendaMedica.Add(turno7);

            var turno8 = new E_Turno(
                8,
                new DateTime(2025, 11, 3, 8, 45, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno8);
            profesional1.AgendaMedica.Add(turno8);

            var turno9 = new E_Turno(
                9,
                new DateTime(2025, 11, 3, 9, 0, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno9);
            profesional1.AgendaMedica.Add(turno9);

            var turno10 = new E_Turno(
                10,
                new DateTime(2025, 11, 3, 9, 15, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno10);
            profesional1.AgendaMedica.Add(turno10);

            var turno11 = new E_Turno(
                11,
                new DateTime(2025, 11, 3, 9, 30, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno11);
            profesional1.AgendaMedica.Add(turno11);

            var turno12 = new E_Turno(
                12,
                new DateTime(2025, 11, 3, 9, 45, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno12);
            profesional1.AgendaMedica.Add(turno12);

            var turno13 = new E_Turno(
                13,
                new DateTime(2025, 11, 3, 10, 0, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno13);
            profesional1.AgendaMedica.Add(turno13);

            var turno14 = new E_Turno(
                14,
                new DateTime(2025, 11, 3, 10, 15, 0),
                profesional1.IdProfesional,
                3000m);

            TurnosDB.Add(turno14);
            profesional1.AgendaMedica.Add(turno14);
        }
    }
}