using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
using ClinicaSePriseApp.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Utilidades
{
    public static class DDBB_Simulation
    {
        public static List<E_Usuario> UsuariosDB { get; set; } = new List<E_Usuario>();

        public static List<E_Administrativo> AdministrativosDB { get; set; } = new List<E_Administrativo>();

        public static List<E_Profesional> ProfesionalesDB { get; set; } = new List<E_Profesional>();
        public static List<E_Disponibilidad> DisponibilidadesDB { get; set; } = new List<E_Disponibilidad>();
        public static List<E_Liquidacion> LiquidacionesDB { get; set; } = new List<E_Liquidacion>();


        public static List<E_Turno> TurnosDB { get; set; } = new List<E_Turno>();


        public static List<E_Paciente> PacientesDB { get; set; } = new List<E_Paciente>();
        public static List<E_HistoriaClinica> HistoriasClinicas { get; set; } = new List<E_HistoriaClinica>();
        public static List<E_Entrada> EntradasDB { get; set; } = new List<E_Entrada>();
        public static List<E_Pago> PagosDB { get; set; } = new List<E_Pago>();

        public static List<E_Consultorio> ConsultoriosDB { get; set; } = new List<E_Consultorio>();
        public static List<E_Insumo> InsumosDB { get; set; } = new List<E_Insumo>();
        public static List<E_PedidoInsumo> PedidosInsumos { get; set; } = new List<E_PedidoInsumo>();



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
            var useradm1 = new E_Usuario(1, "admin", "1234", Rol.ADMINISTRATIVO);
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

            UsuariosDB.Add(useradm1);
            AdministrativosDB.Add(administrativo1);

            UsuariosDB.Add(useradm2);
            AdministrativosDB.Add(administrativo2);


            // PROFESIONALES

            // Profesional 1
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
            E_Usuario userprof1 = new E_Usuario(3, "medico1", "1234", Rol.PROFESIONAL);

            var profesional1 = new E_Profesional(
                1,
                3,
                EspecialidadMedica.CLINICA_MEDICA,
                "123765",
                prof1disp,
                "Alvarez",
                "Ignacio",
                "11222333",
                Genero.H,
                new DateOnly(1993, 6, 18),
                "Casa di galeno",
                "1177558844",
                "profesional1@seprise.com");

            UsuariosDB.Add(userprof1);
            ProfesionalesDB.Add(profesional1);

            // Profesional 2
            // Disponibilidad
            var disponibilidad2b = new E_Disponibilidad(
                3,
                DayOfWeek.Wednesday,
                new TimeSpan(12, 0, 0),
                new TimeSpan(18, 0, 0));

            var disponibilidad2a = new E_Disponibilidad(
                4,
                DayOfWeek.Friday,
                new TimeSpan(9, 0, 0),
                new TimeSpan(15, 0, 0));

            List<E_Disponibilidad> prof2disp = new List<E_Disponibilidad>();
            prof2disp.Add(disponibilidad2a);
            prof2disp.Add(disponibilidad2b);

            // Usuario
            E_Usuario userprof2 = new E_Usuario(4, "medico2", "1234", Rol.PROFESIONAL);

            var profesional2 = new E_Profesional(
                2,
                4,
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

            // Profesional 3
            // Variables para pruebas
            var fecha = DateOnly.FromDateTime(DateTime.Now);

            // Disponibilidad
            var disponibilidad3a = new E_Disponibilidad(
                    5,
                    fecha.DayOfWeek,
                    new TimeSpan(7, 0, 0),
                    new TimeSpan(23, 0, 0));

            var disponibilidad3b = new E_Disponibilidad(
                6,
                fecha.AddDays(1).DayOfWeek,
                new TimeSpan(7, 0, 0),
                new TimeSpan(15, 0, 0));

            var disponibilidad3c = new E_Disponibilidad(
                6,
                fecha.AddDays(3).DayOfWeek,
                new TimeSpan(7, 0, 0),
                new TimeSpan(15, 0, 0));

            List<E_Disponibilidad> prof3disp = new List<E_Disponibilidad>();
            prof3disp.Add(disponibilidad3a);
            prof3disp.Add(disponibilidad3b);
            prof3disp.Add(disponibilidad3b);

            // Usuario
            E_Usuario userprof3 = new E_Usuario(5, "medico", "1234", Rol.PROFESIONAL);

            var profesional3 = new E_Profesional(
                3,
                5,
                EspecialidadMedica.NEUROLOGIA,
                "345678",
                prof3disp,
                "Mazzitelli",
                "Matias",
                "33444555",
                Genero.H,
                new DateOnly(1993, 6, 18),
                "Casa di galeno",
                "1177558844",
                "profesional3@seprise.com");

            // Liquidaciones
            E_Liquidacion liquidacion3a = new E_Liquidacion(
                1,
                profesional3.IdProfesional,
                new DateOnly(2025, 8, 1),
                "Julio",
                15000m);
            profesional3.Liquidaciones.Add(liquidacion3a);
            LiquidacionesDB.Add(liquidacion3a);

            E_Liquidacion liquidacion3b = new E_Liquidacion(
                2,
                profesional3.IdProfesional,
                new DateOnly(2025, 9, 1),
                "Agosto",
                20000m);
            profesional3.Liquidaciones.Add(liquidacion3b);
            LiquidacionesDB.Add(liquidacion3b);

            E_Liquidacion liquidacion3c = new E_Liquidacion(
                3,
                profesional3.IdProfesional,
                new DateOnly(2025, 10, 1),
                "Septiembre",
                18000m);
            profesional3.Liquidaciones.Add(liquidacion3c);
            LiquidacionesDB.Add(liquidacion3c);

            E_Liquidacion liquidacion3d = new E_Liquidacion(
                4,
                profesional3.IdProfesional,
                new DateOnly(2025, 11, 1),
                "Octubre",
                22000m);
            profesional3.Liquidaciones.Add(liquidacion3d);
            LiquidacionesDB.Add(liquidacion3d);


            UsuariosDB.Add(userprof3);
            ProfesionalesDB.Add(profesional3);


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

            var historia1 = paciente1.HistoriaClinica;

            // Entradas
            E_Entrada entrada1a = new E_Entrada(
                1,
                historia1.IdHistoriaClinica,
                profesional3.IdProfesional,
                "Motivo: Dolor de cabeza recurrente\n\nDiagnóstico: La mujer lo gorrea.\n\nObservaciones: Se le receta al paciente reposo e Ibuprofeno 600 cada 5 minutos.",
                new DateTime(new DateOnly(2025, 7, 6), new TimeOnly(7, 45)));

            historia1.Entradas.Add(entrada1a);

            E_Entrada entrada1b = new E_Entrada(
                2,
                historia1.IdHistoriaClinica,
                profesional1.IdProfesional,
                "Motivo: Dolor de ojos\n\nDiagnóstico: El paciente pasa mucho tiempo frente a pantallas.\n\nObservaciones: Se le recomienda al paciente dejar de jugar al LOL.",
                new DateTime(new DateOnly(2025, 9, 16), new TimeOnly(9, 15)));

            historia1.Entradas.Add(entrada1b);


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

            var historia2 = paciente2.HistoriaClinica;

            // Entradas
            E_Entrada entrada2a = new E_Entrada(
                3,
                historia1.IdHistoriaClinica,
                profesional2.IdProfesional,
                "Motivo: Dolor de cabeza recurrente\n\nDiagnóstico: La mujer lo gorrea.\n\nObservaciones: Se le receta al paciente reposo e Ibuprofeno 600 cada 5 minutos.",
                new DateTime(new DateOnly(2025, 10, 12), new TimeOnly(7, 45)));

            historia2.Entradas.Add(entrada2a);

            E_Entrada entrada2b = new E_Entrada(
                4,
                historia1.IdHistoriaClinica,
                profesional1.IdProfesional,
                "Motivo: Dolor de ojos\n\nDiagnóstico: El paciente pasa mucho tiempo frente a pantallas.\n\nObservaciones: Se le recomienda al paciente dejar de jugar al LOL.",
                new DateTime(new DateOnly(2025, 11, 4), new TimeOnly(9, 15)));

            historia2.Entradas.Add(entrada2b);


            PacientesDB.Add(paciente1);
            PacientesDB.Add(paciente2);



            // TURNOS

            // Turnos Profesional 1
            var turno1 = new E_Turno(
                1,
                new DateTime(2025, 11, 10, 7, 0, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno1);
            profesional1.AgendaMedica.Add(turno1);

            var turno2 = new E_Turno(
                2,
                new DateTime(2025, 11, 10, 7, 15, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno2);
            profesional1.AgendaMedica.Add(turno2);

            var turno3 = new E_Turno(
                3,
                new DateTime(2025, 11, 10, 7, 30, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno3);
            profesional1.AgendaMedica.Add(turno3);

            var turno4 = new E_Turno(
                4,
                new DateTime(2025, 11, 10, 7, 45, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno4);
            profesional1.AgendaMedica.Add(turno4);

            var turno5 = new E_Turno(
                5,
                new DateTime(2025, 11, 10, 8, 0, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno5);
            profesional1.AgendaMedica.Add(turno5);

            var turno6 = new E_Turno(
                6,
                new DateTime(2025, 11, 10, 8, 15, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno6);
            profesional1.AgendaMedica.Add(turno6);

            var turno7 = new E_Turno(
                7,
                new DateTime(2025, 11, 10, 8, 30, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno7);
            profesional1.AgendaMedica.Add(turno7);

            var turno8 = new E_Turno(
                8,
                new DateTime(2025, 11, 10, 8, 45, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno8);
            profesional1.AgendaMedica.Add(turno8);

            var turno9 = new E_Turno(
                9,
                new DateTime(2025, 11, 10, 9, 0, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno9);
            profesional1.AgendaMedica.Add(turno9);

            var turno10 = new E_Turno(
                10,
                new DateTime(2025, 11, 10, 9, 15, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno10);
            profesional1.AgendaMedica.Add(turno10);

            var turno11 = new E_Turno(
                11,
                new DateTime(2025, 11, 10, 9, 30, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno11);
            profesional1.AgendaMedica.Add(turno11);

            var turno12 = new E_Turno(
                12,
                new DateTime(2025, 11, 10, 9, 45, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno12);
            profesional1.AgendaMedica.Add(turno12);

            var turno13 = new E_Turno(
                13,
                new DateTime(2025, 11, 10, 10, 0, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno13);
            profesional1.AgendaMedica.Add(turno13);

            var turno14 = new E_Turno(
                14,
                new DateTime(2025, 11, 10, 10, 15, 0),
                profesional1.IdProfesional,
                3000m);
            TurnosDB.Add(turno14);
            profesional1.AgendaMedica.Add(turno14);


            // Turnos Profesional 3
            var turno15 = new E_Turno(
                15,
                new DateTime(2025, fecha.Month, fecha.Day, 7, 0, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno15);
            profesional3.AgendaMedica.Add(turno15);
            TurnoService.AsignarTurno(turno15, paciente1);


            var turno16 = new E_Turno(
                16,
                new DateTime(2025, fecha.Month, fecha.Day, 7, 45, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno16);
            profesional3.AgendaMedica.Add(turno16);

            var turno17 = new E_Turno(
                17,
                new DateTime(2025, fecha.Month, fecha.Day, 8, 30, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno17);
            profesional3.AgendaMedica.Add(turno17);
            TurnoService.AsignarTurno(turno17, paciente2);

            var turno18 = new E_Turno(
                18,
                new DateTime(2025, fecha.Month, fecha.Day, 9, 15, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno18);
            profesional3.AgendaMedica.Add(turno18);
            TurnoService.AsignarTurno(turno18, paciente1);

            var turno19 = new E_Turno(
                19,
                new DateTime(2025, fecha.Month, fecha.Day, 10, 0, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno19);
            profesional3.AgendaMedica.Add(turno19);
            TurnoService.AsignarTurno(turno19, paciente2);
            turno19.Estado = EstadoTurno.ABONADO; // HARDCORE PARA PRUEBA

            var turno20 = new E_Turno(
                20,
                new DateTime(2025, fecha.Month, fecha.Day, 10, 45, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno20);
            profesional3.AgendaMedica.Add(turno20);
            TurnoService.AsignarTurno(turno20, paciente1);
            turno20.Estado = EstadoTurno.ABONADO; // HARDCORE PARA PRUEBA

            var turno21 = new E_Turno(
                21,
                new DateTime(2025, fecha.Month, fecha.Day, 11, 30, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno21);
            profesional3.AgendaMedica.Add(turno21);

            var turno22 = new E_Turno(
                22,
                new DateTime(2025, fecha.Month, fecha.Day, 12, 15, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno22);
            profesional3.AgendaMedica.Add(turno22);

            var turno23 = new E_Turno(
                23,
                new DateTime(2025, fecha.Month, fecha.Day, 13, 0, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno23);
            profesional3.AgendaMedica.Add(turno23);

            var turno24 = new E_Turno(
                24,
                new DateTime(2025, fecha.Month, fecha.Day, 13, 45, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno24);
            profesional3.AgendaMedica.Add(turno24);

            var turno25 = new E_Turno(
                25,
                new DateTime(2025, fecha.Month, fecha.Day, 14, 30, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno25);
            profesional3.AgendaMedica.Add(turno25);

            var turno26 = new E_Turno(
                26,
                new DateTime(2025, fecha.Month, fecha.Day, 15, 15, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno26);
            profesional3.AgendaMedica.Add(turno26);

            var turno27 = new E_Turno(
                27,
                new DateTime(2025, fecha.Month, fecha.Day, 16, 0, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno27);
            profesional3.AgendaMedica.Add(turno27);

            var turno28 = new E_Turno(
                28,
                new DateTime(2025, fecha.Month, fecha.Day, 16, 45, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno28);
            profesional3.AgendaMedica.Add(turno28);

            var turno29 = new E_Turno(
                29,
                new DateTime(2025, fecha.Month, fecha.Day, 17, 30, 0),
                profesional3.IdProfesional,
                5000m);
            TurnosDB.Add(turno29);
            profesional3.AgendaMedica.Add(turno29);


            // INSUMOS
            var insumo1 = new E_Insumo(
                "COD/11",
                "Jeringa Porter",
                "Jeringa descartable para uso unico, con capacidad para 300mm de solucion, marca Porter.",
                400);
            InsumosDB.Add(insumo1);

            var insumo2 = new E_Insumo(
                "COD/22",
                "Guantes de Nitrilo",
                "Guantes de nitrilo sin polvo, talla M, caja con 100 unidades.",
                150);
            InsumosDB.Add(insumo2);

            var insumo3 = new E_Insumo(
                "COD/33",
                "Barbijo Quirurgico",
                "Barbijo quirurgico tricapa con elásticos para las orejas, caja con 50 unidades.",
                200);
            InsumosDB.Add(insumo3);

            var insumo4 = new E_Insumo(
                "COD/44",
                "Termometro Digital",
                "Termometro digital infrarrojo para uso oral, auricular o en frente, con pantalla LCD.",
                75);
            InsumosDB.Add(insumo4);

            var insumo5 = new E_Insumo(
                "COD/55",
                "Alcohol en Gel",
                "Alcohol en gel al 70% para desinfeccion de manos y superficies, envase de 500ml.",
                120);
            InsumosDB.Add(insumo5);

            var insumo6 = new E_Insumo(
                "COD/66",
                "Venda Elastica",
                "Venda elastica autoadhesiva para soporte y compresion, rollo de 5cm x 4.5m.",
                90);
            InsumosDB.Add(insumo6);

            var insumo7 = new E_Insumo(
                "COD/77",
                "Termometro Digital",
                "Termometro digital infrarrojo para uso oral, auricular o en frente, con pantalla LCD.",
                75);
            InsumosDB.Add(insumo7);

            var insumo8 = new E_Insumo(
                "COD/88",
                "Alcohol en Gel",
                "Alcohol en gel al 70% para desinfeccion de manos y superficies, envase de 500ml.",
                120);
            InsumosDB.Add(insumo8);

            var insumo9 = new E_Insumo(
                "COD/99",
                "Venda Elastica",
                "Venda elastica autoadhesiva para soporte y compresion, rollo de 5cm x 4.5m.",
                90);
            InsumosDB.Add(insumo9);

            var insumo10 = new E_Insumo(
                "COD/100",
                "Guantes de Nitrilo",
                "Guantes de nitrilo sin polvo, talla M, caja con 100 unidades.",
                150);
            InsumosDB.Add(insumo10);

            var insumo11 = new E_Insumo(
                "COD/110",
                "Barbijo Quirurgico",
                "Barbijo quirurgico tricapa con elásticos para las orejas, caja con 50 unidades.",
                200);
            InsumosDB.Add(insumo11);


            // SOLICITUD DE INSUMOS
            var insumoSolicitado1a = new E_InsumoSolicitado(insumo1, 10);
            var insumoSolicitado1b = new E_InsumoSolicitado(insumo4, 30);
            var insumoSolicitado1c = new E_InsumoSolicitado(insumo6, 20);

            var listaInsumosSolicitados1 = new List<E_InsumoSolicitado>();
            listaInsumosSolicitados1.Add(insumoSolicitado1a);
            listaInsumosSolicitados1.Add(insumoSolicitado1b);
            listaInsumosSolicitados1.Add(insumoSolicitado1c);

            var pedido1 = new E_PedidoInsumo(
                profesional1.IdProfesional,
                listaInsumosSolicitados1
                );
        }
    }
}