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

        public static void InicializarDatosPrueba()
        {
            AdministrativosDB.Clear();
            ProfesionalesDB.Clear();
            UsuariosDB.Clear();
            PacientesDB.Clear();
            TurnosDB.Clear();
            InsumosDB.Clear();
            ConsultoriosDB.Clear();
            PagosDB.Clear();
            LiquidacionesDB.Clear();
            PedidosInsumos.Clear();
            EntradasDB.Clear();
            HistoriasClinicas.Clear();
            DisponibilidadesDB.Clear();

            ResetAutoIncrementCounters();

            var fechaHoy = DateOnly.FromDateTime(DateTime.Now);
            var fechaAyer = fechaHoy.AddDays(-1);
            var fechaManana = fechaHoy.AddDays(1);
            var fechaPasado = fechaHoy.AddDays(2);
            var fechaSemanaPasada = fechaHoy.AddDays(-7);
            var fechaMesPasado = fechaHoy.AddMonths(-1);
            var fechaHace2Meses = fechaHoy.AddMonths(-2);

            CrearUsuarios();
            CrearAdministrativo();
            CrearProfesionalesDinamicos(fechaHoy);
            CrearConsultorios();
            CrearInsumos();
            CrearPacientes();
            CrearTurnosYAgendasDinamicos(fechaHoy, fechaAyer, fechaManana, fechaPasado, fechaSemanaPasada, fechaMesPasado, fechaHace2Meses);
            CrearHistoriasClinicasYEntradas(fechaHoy, fechaAyer, fechaSemanaPasada, fechaMesPasado, fechaHace2Meses);
            CrearPagos(fechaHoy, fechaAyer, fechaSemanaPasada, fechaMesPasado);
            CrearLiquidaciones(fechaHoy, fechaMesPasado);
            CrearSolicitudesInsumos();

            Console.WriteLine("✅ Base de datos simulada inicializada correctamente");
            Console.WriteLine($"📊 Resumen: {UsuariosDB.Count} usuarios, {ProfesionalesDB.Count} profesionales, {PacientesDB.Count} pacientes");
            Console.WriteLine($"📊 {TurnosDB.Count} turnos, {PagosDB.Count} pagos, {InsumosDB.Count} insumos");
        }

        private static void ResetAutoIncrementCounters()
        {
            var assembly = typeof(E_Usuario).Assembly;
            var types = assembly.GetTypes().Where(t => t.IsClass && t.Name.StartsWith("E_"));

            foreach (var type in types)
            {
                var field = type.GetField("ID_AUTOINCREMENT",
                    System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

                if (field != null && field.FieldType == typeof(int))
                {
                    field.SetValue(null, 0);
                }
            }
        }

        private static void CrearUsuarios()
        {
            var usuarioAdmin = new E_Usuario("admin", "1234", Rol.ADMINISTRATIVO);
            UsuariosDB.Add(usuarioAdmin);

            var usuarioMedico1 = new E_Usuario("medico", "1234", Rol.PROFESIONAL);
            var usuarioMedico2 = new E_Usuario("drgomez", "1234", Rol.PROFESIONAL);
            var usuarioMedico3 = new E_Usuario("drafernandez", "1234", Rol.PROFESIONAL);

            UsuariosDB.Add(usuarioMedico1);
            UsuariosDB.Add(usuarioMedico2);
            UsuariosDB.Add(usuarioMedico3);
        }

        private static void CrearAdministrativo()
        {
            var usuarioAdmin = UsuariosDB.First(u => u.UserName == "admin");
            var administrativo = new E_Administrativo(
                usuarioAdmin.IdUsuario,
                "García", "María", "30123456", Genero.M,
                new DateOnly(1985, 5, 15),
                "Av. Siempre Viva 123", "11-2345-6789", "mgarcia@clinicaseprise.com"
            );
            AdministrativosDB.Add(administrativo);
        }

        private static void CrearProfesionalesDinamicos(DateOnly fechaHoy)
        {
            var usuarioMedico1 = UsuariosDB.First(u => u.UserName == "medico");
            var usuarioMedico2 = UsuariosDB.First(u => u.UserName == "drgomez");
            var usuarioMedico3 = UsuariosDB.First(u => u.UserName == "drafernandez");

            var diasDisponibles1 = new List<DateOnly> {
                fechaHoy.AddDays(-1),
                fechaHoy,
                fechaHoy.AddDays(1),
                fechaHoy.AddDays(3)
            };

            var diasDisponibles2 = new List<DateOnly> {
                fechaHoy.AddDays(-2),
                fechaHoy,
                fechaHoy.AddDays(2),
                fechaHoy.AddDays(4)
            };

            var diasDisponibles3 = new List<DateOnly> {
                fechaHoy.AddDays(-1),
                fechaHoy.AddDays(1),
                fechaHoy.AddDays(2),
                fechaHoy.AddDays(5)
            };

            var disponibilidades1 = diasDisponibles1.Select(fecha =>
                new E_Disponibilidad(fecha.DayOfWeek, new TimeSpan(9, 0, 0), new TimeSpan(13, 0, 0))).ToList();

            var disponibilidades2 = diasDisponibles2.Select(fecha =>
                new E_Disponibilidad(fecha.DayOfWeek, new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0))).ToList();

            var disponibilidades3 = diasDisponibles3.Select(fecha =>
                new E_Disponibilidad(fecha.DayOfWeek, new TimeSpan(14, 0, 0), new TimeSpan(18, 0, 0))).ToList();

            var profesional1 = new E_Profesional(
                usuarioMedico1.IdUsuario, EspecialidadMedica.CARDIOLOGIA, "MP-12345", disponibilidades1,
                "López", "Carlos", "20123456", Genero.H, new DateOnly(1978, 3, 20),
                "Calle Falsa 123", "11-3456-7890", "clopez@clinicaseprise.com"
            );

            var profesional2 = new E_Profesional(
                usuarioMedico2.IdUsuario, EspecialidadMedica.NEUROLOGIA, "MP-23456", disponibilidades2,
                "Gómez", "Roberto", "20234567", Genero.H, new DateOnly(1980, 7, 12),
                "Av. Corrientes 456", "11-4567-8901", "rgomez@clinicaseprise.com"
            );

            var profesional3 = new E_Profesional(
                usuarioMedico3.IdUsuario, EspecialidadMedica.CLINICA_MEDICA, "MP-34567", disponibilidades3,
                "Fernández", "Ana", "20345678", Genero.M, new DateOnly(1975, 11, 5),
                "Pte. Perón 789", "11-5678-9012", "afernandez@clinicaseprise.com"
            );

            ProfesionalesDB.Add(profesional1);
            ProfesionalesDB.Add(profesional2);
            ProfesionalesDB.Add(profesional3);

            DisponibilidadesDB.AddRange(disponibilidades1);
            DisponibilidadesDB.AddRange(disponibilidades2);
            DisponibilidadesDB.AddRange(disponibilidades3);
        }

        private static void CrearConsultorios()
        {
            var consultorio1 = new E_Consultorio();
            consultorio1.IdProfesional = ProfesionalesDB[0].IdProfesional;

            var consultorio2 = new E_Consultorio();
            consultorio2.IdProfesional = ProfesionalesDB[1].IdProfesional;

            var consultorio3 = new E_Consultorio();
            consultorio3.IdProfesional = ProfesionalesDB[2].IdProfesional;

            ConsultoriosDB.Add(consultorio1);
            ConsultoriosDB.Add(consultorio2);
            ConsultoriosDB.Add(consultorio3);
        }

        private static void CrearInsumos()
        {
            var insumos = new List<E_Insumo>
            {
                new E_Insumo("CAR-001", "Electrocardiógrafo", "Equipo para ECG", 2),
                new E_Insumo("CAR-005", "Desfibrilador", "Equipo de emergencia cardíaca", 1),
                new E_Insumo("NEU-002", "Agujas para EMG", "Agujas para electromiografía", 2),
                new E_Insumo("CLI-001", "Estetoscopio", "Estetoscopio profesional", 5),
                new E_Insumo("NEU-001", "Martillo Reflejo Neurológico", "Martillo especializado", 3),
                new E_Insumo("CLI-004", "Termómetro Digital", "Medidor de temperatura", 4),
                new E_Insumo("GEN-001", "Guantes Estériles", "Guantes de uso general", 25),
                new E_Insumo("CLI-008", "Guantes de Latex", "Guantes de examen", 30),
                new E_Insumo("CLI-009", "Jeringas Descartables", "Jeringas 5-10ml", 20),
                new E_Insumo("CLI-010", "Agujas Estériles", "Agujas diversas", 25),
                new E_Insumo("NEU-003", "Electrodos EEG", "Electrodos para electroencefalograma", 45),
                new E_Insumo("CAR-008", "Guantes Estériles", "Guantes quirúrgicos", 35),
                new E_Insumo("CAR-002", "Monitor Cardiaco", "Monitor de signos vitales", 8),
                new E_Insumo("CAR-003", "Estetoscopio Cardiológico", "Estetoscopio especializado", 12),
                new E_Insumo("CLI-002", "Otoscopio", "Equipo para examen auditivo", 7),
                new E_Insumo("CLI-003", "Oftalmoscopio", "Equipo para examen ocular", 6)
            };

            InsumosDB.AddRange(insumos);
        }

        private static void CrearPacientes()
        {
            var pacientes = new List<E_Paciente>
            {
                new E_Paciente("González", "Laura", "35123456", Genero.M,
                    new DateOnly(1990, 8, 12), "Av. Libertador 1234", "11-1234-5678",
                    "lgonzalez@gmail.com", ObraSocial.OSDE, "OSDE-123456"),

                new E_Paciente("Rodríguez", "Martín", "35234567", Genero.H,
                    new DateOnly(1985, 3, 25), "Calle 56 #789", "11-2345-6789",
                    "mrodriguez@hotmail.com", ObraSocial.SWISS_MEDICAL, "SM-789012"),

                new E_Paciente("Martínez", "Carolina", "35345678", Genero.M,
                    new DateOnly(1978, 11, 8), "Pte. Perón 567", "11-3456-7890",
                    "cmartinez@gmail.com", ObraSocial.GALENO, "GAL-456789"),

                new E_Paciente("Pérez", "Diego", "35456789", Genero.H,
                    new DateOnly(1995, 6, 30), "Av. Rivadavia 2345", "11-4567-8901",
                    "dperez@yahoo.com", ObraSocial.OSDE, "OSDE-789123"),

                new E_Paciente("Silva", "Andrea", "35567890", Genero.M,
                    new DateOnly(1982, 2, 14), "Córdoba 876", "11-5678-9012",
                    "asilva@gmail.com", ObraSocial.PARTICULAR, "")
            };

            PacientesDB.AddRange(pacientes);

            foreach (var paciente in pacientes)
            {
                HistoriasClinicas.Add(paciente.HistoriaClinica);
            }
        }

        private static void CrearTurnosYAgendasDinamicos(DateOnly hoy, DateOnly ayer, DateOnly manana, DateOnly pasado,
                                                       DateOnly semanaPasada, DateOnly mesPasado, DateOnly hace2Meses)
        {
            var todasFechas = new List<DateOnly> { hace2Meses, mesPasado, semanaPasada, ayer, hoy, manana, pasado };

            foreach (var profesional in ProfesionalesDB)
            {
                var diasDisponiblesProfesional = profesional.Disponibilidades.Select(d => d.Dia).ToList();
                var fechasConDisponibilidad = todasFechas.Where(f => diasDisponiblesProfesional.Contains(f.DayOfWeek)).ToList();

                foreach (var fecha in fechasConDisponibilidad)
                {
                    var disponibilidad = profesional.Disponibilidades.FirstOrDefault(d => d.Dia == fecha.DayOfWeek);
                    if (disponibilidad != null)
                    {
                        try
                        {
                            TurnoService.CrearAgendaMedica(profesional, fecha);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error creando agenda para {profesional.NombreCompleto} en {fecha}: {ex.Message}");
                        }
                    }
                }
            }

            var turnosDisponibles = TurnoDB.Where(t => t.Estado == EstadoTurno.DISPONIBLE).ToList();

            if (turnosDisponibles.Count == 0)
            {
                Console.WriteLine("No hay turnos disponibles para asignar a pacientes");
                return;
            }

            AsignarTurnosBasicos(hoy, ayer, manana, pasado, semanaPasada, mesPasado, hace2Meses);
            ConfigurarEstadosMedicoPrincipal(hoy);

            foreach (var turno in TurnoDB)
            {
                var fechaTurno = DateOnly.FromDateTime(turno.FechaTurno);

                if (fechaTurno < hoy && turno.IdPaciente.HasValue)
                {
                    turno.Estado = EstadoTurno.FINALIZADO;
                }
                else if (fechaTurno > hoy && turno.IdPaciente.HasValue)
                {
                    turno.Estado = EstadoTurno.ASIGNADO;
                }
            }
        }

        private static void AsignarTurnosBasicos(DateOnly hoy, DateOnly ayer, DateOnly manana, DateOnly pasado,
                                               DateOnly semanaPasada, DateOnly mesPasado, DateOnly hace2Meses)
        {
            var turnosDisponibles = TurnoDB.Where(t => t.Estado == EstadoTurno.DISPONIBLE).ToList();

            AsignarTurnosPacienteDinamico(PacientesDB[0], ProfesionalesDB[0],
                new List<DateOnly> { mesPasado, semanaPasada, manana }, turnosDisponibles);

            AsignarTurnosPacienteDinamico(PacientesDB[1], ProfesionalesDB[1],
                new List<DateOnly> { hace2Meses, ayer, pasado }, turnosDisponibles);
            AsignarTurnosPacienteDinamico(PacientesDB[1], ProfesionalesDB[2],
                new List<DateOnly> { semanaPasada }, turnosDisponibles);

            AsignarTurnosPacienteDinamico(PacientesDB[2], ProfesionalesDB[0],
                new List<DateOnly> { ayer, manana }, turnosDisponibles);

            AsignarTurnosPacienteDinamico(PacientesDB[3], ProfesionalesDB[2],
                new List<DateOnly> { mesPasado, semanaPasada }, turnosDisponibles);

            AsignarTurnosPacienteDinamico(PacientesDB[4], ProfesionalesDB[1],
                new List<DateOnly> { manana, pasado }, turnosDisponibles);
        }

        private static void ConfigurarEstadosMedicoPrincipal(DateOnly hoy)
        {
            var medicoPrincipal = ProfesionalesDB[0];

            var turnosHoyMedicoPrincipal = TurnoDB
                .Where(t => t.IdProfesional == medicoPrincipal.IdProfesional &&
                           DateOnly.FromDateTime(t.FechaTurno) == hoy)
                .OrderBy(t => t.FechaTurno)
                .ToList();

            if (turnosHoyMedicoPrincipal.Count >= 8)
            {
                for (int i = 0; i < 3; i++)
                {
                    turnosHoyMedicoPrincipal[i].Estado = EstadoTurno.DISPONIBLE;
                    turnosHoyMedicoPrincipal[i].IdPaciente = null;
                }

                var pacientesParaHoy = new List<E_Paciente>
                {
                    PacientesDB[0],
                    PacientesDB[1],
                    PacientesDB[2],
                    PacientesDB[3],
                    PacientesDB[4]
                };

                for (int i = 3; i < 8; i++)
                {
                    var pacienteIndex = i - 3;
                    if (pacienteIndex < pacientesParaHoy.Count)
                    {
                        turnosHoyMedicoPrincipal[i].Estado = EstadoTurno.ASIGNADO;
                        turnosHoyMedicoPrincipal[i].IdPaciente = pacientesParaHoy[pacienteIndex].IdPaciente;

                        pacientesParaHoy[pacienteIndex].Reservas ??= new List<E_Turno>();
                        pacientesParaHoy[pacienteIndex].Reservas.Add(turnosHoyMedicoPrincipal[i]);
                    }
                }

                for (int i = 3; i < 6; i++)
                {
                    turnosHoyMedicoPrincipal[i].Estado = EstadoTurno.FINALIZADO;

                    var paciente = PacientesDB.FirstOrDefault(p => p.IdPaciente == turnosHoyMedicoPrincipal[i].IdPaciente);
                    if (paciente != null)
                    {
                        CrearEntradaHistoriaParaTurno(paciente, medicoPrincipal, hoy, turnosHoyMedicoPrincipal[i]);
                    }
                }

                for (int i = 6; i < 8; i++)
                {
                    turnosHoyMedicoPrincipal[i].Estado = EstadoTurno.ABONADO;

                    var paciente = PacientesDB.FirstOrDefault(p => p.IdPaciente == turnosHoyMedicoPrincipal[i].IdPaciente);
                    if (paciente != null)
                    {
                        CrearPagoParaTurno(paciente, turnosHoyMedicoPrincipal[i], hoy);
                    }
                }
            }
            else
            {
                Console.WriteLine($"No hay suficientes turnos para configurar estados específicos. Turnos encontrados: {turnosHoyMedicoPrincipal.Count}");
            }
        }

        private static void CrearEntradaHistoriaParaTurno(E_Paciente paciente, E_Profesional profesional, DateOnly fecha, E_Turno turno)
        {
            var observaciones = $"Consulta de {EnumHelper.GetDescription(profesional.Especialidad).ToLower()}. Turno #{turno.IdTurno}. Paciente atendido correctamente.";

            var entrada = new E_Entrada(
                paciente.HistoriaClinica.IdHistoriaClinica,
                profesional.IdProfesional,
                observaciones,
                turno.FechaTurno
            );

            EntradasDB.Add(entrada);
            paciente.HistoriaClinica.Entradas.Add(entrada);
        }

        private static void CrearPagoParaTurno(E_Paciente paciente, E_Turno turno, DateOnly fechaHoy)
        {
            var pago = new E_Pago(paciente.IdPaciente, turno.IdTurno, turno.Monto);
            pago.Estado = EstadoPago.REALIZADO;
            pago.FechaPago = fechaHoy;
            pago.MetodoPago = MetodoPago.EFECTIVO;

            PagosDB.Add(pago);

            paciente.PagosRealizados ??= new List<E_Pago>();
            paciente.PagosRealizados.Add(pago);
        }

        private static void AsignarTurnosPacienteDinamico(E_Paciente paciente, E_Profesional profesional,
                                                         List<DateOnly> fechas, List<E_Turno> turnosDisponibles)
        {
            foreach (var fecha in fechas)
            {
                var tieneDisponibilidad = profesional.Disponibilidades.Any(d => d.Dia == fecha.DayOfWeek);
                if (!tieneDisponibilidad) continue;

                var turno = turnosDisponibles
                    .FirstOrDefault(t => DateOnly.FromDateTime(t.FechaTurno) == fecha &&
                                       t.IdProfesional == profesional.IdProfesional &&
                                       t.Estado == EstadoTurno.DISPONIBLE);

                if (turno != null)
                {
                    try
                    {
                        TurnoService.AsignarTurno(turno, paciente);
                        turnosDisponibles.Remove(turno);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error asignando turno a {paciente.NombreCompleto}: {ex.Message}");
                    }
                }
            }
        }

        private static void CrearHistoriasClinicasYEntradas(DateOnly hoy, DateOnly ayer, DateOnly semanaPasada,
                                                          DateOnly mesPasado, DateOnly hace2Meses)
        {
            var cardiologo = ProfesionalesDB[0];
            var neurologo = ProfesionalesDB[1];
            var clinico = ProfesionalesDB[2];

            CrearEntradaHistoriaClinica(PacientesDB[0], cardiologo, hace2Meses, "Paciente consulta por palpitaciones ocasionales. Se realiza ECG que muestra ritmo sinusal normal. Se indica monitoreo y control en 30 días.");
            CrearEntradaHistoriaClinica(PacientesDB[0], cardiologo, mesPasado, "Control de palpitaciones. Paciente refiere mejoría. ECG sin cambios. Se ajusta medicación y se solicita nuevo control.");
            CrearEntradaHistoriaClinica(PacientesDB[0], cardiologo, semanaPasada, "Control rutinario. Paciente asintomática. Presión arterial 120/80 mmHg. Se mantiene tratamiento actual.");
            CrearEntradaHistoriaClinica(PacientesDB[1], neurologo, hace2Meses, "Paciente consulta por cefaleas recurrentes. Se solicita resonancia magnética cerebral.");
            CrearEntradaHistoriaClinica(PacientesDB[1], neurologo, semanaPasada, "Control de cefaleas. Resonancia informa hallazgos dentro de lo normal. Se ajusta medicación preventiva.");
            CrearEntradaHistoriaClinica(PacientesDB[1], clinico, ayer, "Consulta por dolor lumbar. Se indica kinesiología y antiinflamatorios.");
            CrearEntradaHistoriaClinica(PacientesDB[2], cardiologo, mesPasado, "Primera consulta por hipertensión arterial. Se inicia tratamiento con enalapril 10 mg diarios.");
            CrearEntradaHistoriaClinica(PacientesDB[2], cardiologo, ayer, "Control de hipertensión. Presión arterial 135/85 mmHg. Se ajusta dosis a 20 mg diarios.");
            CrearEntradaHistoriaClinica(PacientesDB[3], clinico, hace2Meses, "Control anual. Paciente asintomático. Estudios de laboratorio dentro de parámetros normales.");
            CrearEntradaHistoriaClinica(PacientesDB[3], clinico, semanaPasada, "Consulta por infección respiratoria alta. Se indica antibioterapia y sintomáticos.");
            CrearEntradaHistoriaClinica(PacientesDB[4], neurologo, mesPasado, "Primera consulta por parestesias en miembros superiores. Se solicita EMG y estudios complementarios.");
        }

        private static void CrearEntradaHistoriaClinica(E_Paciente paciente, E_Profesional profesional,
                                                       DateOnly fecha, string observaciones)
        {
            var entrada = new E_Entrada(
                paciente.HistoriaClinica.IdHistoriaClinica,
                profesional.IdProfesional,
                observaciones,
                fecha.ToDateTime(new TimeOnly(9, 0))
            );

            EntradasDB.Add(entrada);
            paciente.HistoriaClinica.Entradas.Add(entrada);
        }

        private static void CrearPagos(DateOnly hoy, DateOnly ayer, DateOnly semanaPasada, DateOnly mesPasado)
        {
            var turnosFinalizados = TurnoDB
                .Where(t => t.Estado == EstadoTurno.FINALIZADO && t.IdPaciente.HasValue)
                .ToList();

            foreach (var turno in turnosFinalizados)
            {
                var pago = new E_Pago(turno.IdPaciente.Value, turno.IdTurno, turno.Monto);

                if (DateOnly.FromDateTime(turno.FechaTurno) <= semanaPasada)
                {
                    pago.Estado = EstadoPago.REALIZADO;
                    pago.FechaPago = DateOnly.FromDateTime(turno.FechaTurno).AddDays(1);
                    pago.MetodoPago = MetodoPago.EFECTIVO;
                }
                else if (DateOnly.FromDateTime(turno.FechaTurno) == ayer)
                {
                    pago.Estado = EstadoPago.PENDIENTE;
                }

                PagosDB.Add(pago);

                var paciente = PacientesDB.FirstOrDefault(p => p.IdPaciente == turno.IdPaciente);
                if (paciente != null)
                {
                    paciente.PagosRealizados ??= new List<E_Pago>();
                    paciente.PagosRealizados.Add(pago);
                }
            }

            var turnosFuturos = TurnoDB
                .Where(t => t.Estado == EstadoTurno.ASIGNADO && t.IdPaciente.HasValue &&
                           DateOnly.FromDateTime(t.FechaTurno) > hoy)
                .Take(3)
                .ToList();

            foreach (var turno in turnosFuturos)
            {
                var pago = new E_Pago(turno.IdPaciente.Value, turno.IdTurno, turno.Monto);
                pago.Estado = EstadoPago.PENDIENTE;
                PagosDB.Add(pago);

                var paciente = PacientesDB.FirstOrDefault(p => p.IdPaciente == turno.IdPaciente);
                if (paciente != null)
                {
                    paciente.PagosRealizados ??= new List<E_Pago>();
                    paciente.PagosRealizados.Add(pago);
                }
            }
        }

        private static void CrearLiquidaciones(DateOnly hoy, DateOnly mesPasado)
        {
            var liquidacion1 = new E_Liquidacion(ProfesionalesDB[0].IdProfesional, mesPasado, $"{mesPasado:MMMM yyyy}", 85000m);
            LiquidacionesDB.Add(liquidacion1);
            ProfesionalesDB[0].Liquidaciones.Add(liquidacion1);

            var liquidacion2 = new E_Liquidacion(ProfesionalesDB[1].IdProfesional, mesPasado, $"{mesPasado:MMMM yyyy}", 72000m);
            LiquidacionesDB.Add(liquidacion2);
            ProfesionalesDB[1].Liquidaciones.Add(liquidacion2);

            var liquidacion3 = new E_Liquidacion(ProfesionalesDB[2].IdProfesional, hoy, $"{hoy:MMMM yyyy}", 68000m);
            LiquidacionesDB.Add(liquidacion3);
            ProfesionalesDB[2].Liquidaciones.Add(liquidacion3);
        }

        private static void CrearSolicitudesInsumos()
        {
            var cardiologo = ProfesionalesDB[0];
            var neurologo = ProfesionalesDB[1];

            var insumosSolicitados1 = new List<E_InsumoSolicitado>
            {
                new E_InsumoSolicitado(InsumosDB[0], 2),
                new E_InsumoSolicitado(InsumosDB[12], 5),
                new E_InsumoSolicitado(InsumosDB[10], 20)
            };

            var solicitud1 = new E_PedidoInsumo(cardiologo.IdProfesional, insumosSolicitados1);
            PedidosInsumos.Add(solicitud1);

            var insumosSolicitados2 = new List<E_InsumoSolicitado>
            {
                new E_InsumoSolicitado(InsumosDB[2], 10),
                new E_InsumoSolicitado(InsumosDB[4], 2),
                new E_InsumoSolicitado(InsumosDB[11], 15)
            };

            var solicitud2 = new E_PedidoInsumo(neurologo.IdProfesional, insumosSolicitados2);
            PedidosInsumos.Add(solicitud2);

            var insumosSolicitados3 = new List<E_InsumoSolicitado>
            {
                new E_InsumoSolicitado(InsumosDB[7], 10),
                new E_InsumoSolicitado(InsumosDB[8], 15)
            };

            var solicitud3 = new E_PedidoInsumo(cardiologo.IdProfesional, insumosSolicitados3);
            solicitud3.EstadoPedidoInsumo = EstadoPedidoInsumo.ENTREGADO;
            PedidosInsumos.Add(solicitud3);
        }

        public static List<E_Turno> TurnoDB => TurnosDB;
    }
}