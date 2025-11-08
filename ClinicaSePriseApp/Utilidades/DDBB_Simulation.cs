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
            // LIMPIAR LISTAS
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

            // RESET AUTOINCREMENT
            ResetAutoIncrementCounters();

            // FECHA BASE PARA LA SIMULACIÓN (8/11/2025 - SÁBADO)
            var fechaHoy = new DateOnly(2025, 11, 8);
            var fechaAyer = fechaHoy.AddDays(-1);
            var fechaManana = fechaHoy.AddDays(1);
            var fechaPasado = fechaHoy.AddDays(2);
            var fechaSemanaPasada = fechaHoy.AddDays(-7);
            var fechaMesPasado = fechaHoy.AddMonths(-1);

            // ========== ADMINISTRATIVOS ==========
            var userAdm1 = new E_Usuario("admin", "1234", Rol.ADMINISTRATIVO);
            var administrativo1 = new E_Administrativo(
                userAdm1.IdUsuario,
                "Gonzalez", "Laura", "30123456", Genero.M, new DateOnly(1985, 3, 15),
                "Av. Siempre Viva 742", "1156789012", "l.gonzalez@clinica.com");

            UsuariosDB.Add(userAdm1);
            AdministrativosDB.Add(administrativo1);

            // ========== PROFESIONALES ==========

            // PROFESIONAL 1 (PRINCIPAL - DR. GARCÍA - PARA GRABACIÓN)
            var dispProf1 = new List<E_Disponibilidad>
            {
                new E_Disponibilidad(DayOfWeek.Monday, new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Wednesday, new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Friday, new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Saturday, new TimeSpan(16, 0, 0), new TimeSpan(22, 0, 0)) // DISPONIBILIDAD PARA HOY
            };

            var userProf1 = new E_Usuario("medico", "1234", Rol.PROFESIONAL);
            var profesional1 = new E_Profesional(
                userProf1.IdUsuario, EspecialidadMedica.CARDIOLOGIA, "MP12345", dispProf1,
                "García", "Roberto", "20123456", Genero.H, new DateOnly(1978, 6, 20),
                "Calle Médicos 123", "1167890123", "r.garcia@clinica.com");

            UsuariosDB.Add(userProf1);
            ProfesionalesDB.Add(profesional1);
            DisponibilidadesDB.AddRange(dispProf1);

            // LIQUIDACIONES DEL DR. GARCÍA (5 MESES HACIA ATRÁS)
            var liquidacionesProf1 = new List<E_Liquidacion>
            {
                new E_Liquidacion(profesional1.IdProfesional, new DateOnly(2025, 11, 1), "Octubre 2025", 185000m),
                new E_Liquidacion(profesional1.IdProfesional, new DateOnly(2025, 10, 1), "Septiembre 2025", 172000m),
                new E_Liquidacion(profesional1.IdProfesional, new DateOnly(2025, 9, 1), "Agosto 2025", 168000m),
                new E_Liquidacion(profesional1.IdProfesional, new DateOnly(2025, 8, 1), "Julio 2025", 155000m),
                new E_Liquidacion(profesional1.IdProfesional, new DateOnly(2025, 7, 1), "Junio 2025", 148000m)
            };

            LiquidacionesDB.AddRange(liquidacionesProf1);
            profesional1.Liquidaciones.AddRange(liquidacionesProf1);

            // PROFESIONAL 2
            var dispProf2 = new List<E_Disponibilidad>
            {
                new E_Disponibilidad(DayOfWeek.Tuesday, new TimeSpan(9, 0, 0), new TimeSpan(13, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Thursday, new TimeSpan(9, 0, 0), new TimeSpan(13, 0, 0))
            };

            var userProf2 = new E_Usuario("dramartinez", "1234", Rol.PROFESIONAL);
            var profesional2 = new E_Profesional(
                userProf2.IdUsuario, EspecialidadMedica.PEDIATRIA, "MP54321", dispProf2,
                "Martínez", "Ana", "25123456", Genero.M, new DateOnly(1982, 9, 12),
                "Av. Salud 456", "1178901234", "a.martinez@clinica.com");

            UsuariosDB.Add(userProf2);
            ProfesionalesDB.Add(profesional2);
            DisponibilidadesDB.AddRange(dispProf2);

            // PROFESIONAL 3
            var dispProf3 = new List<E_Disponibilidad>
            {
                new E_Disponibilidad(DayOfWeek.Monday, new TimeSpan(10, 0, 0), new TimeSpan(14, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Wednesday, new TimeSpan(10, 0, 0), new TimeSpan(14, 0, 0)),
                new E_Disponibilidad(DayOfWeek.Friday, new TimeSpan(10, 0, 0), new TimeSpan(14, 0, 0))
            };

            var userProf3 = new E_Usuario("drlopez", "1234", Rol.PROFESIONAL);
            var profesional3 = new E_Profesional(
                userProf3.IdUsuario, EspecialidadMedica.TRAUMATOLOGIA, "MP67890", dispProf3,
                "López", "Carlos", "28123456", Genero.H, new DateOnly(1975, 11, 5),
                "Bv. Especialistas 789", "1189012345", "c.lopez@clinica.com");

            UsuariosDB.Add(userProf3);
            ProfesionalesDB.Add(profesional3);
            DisponibilidadesDB.AddRange(dispProf3);

            // ========== PACIENTES ==========

            // PACIENTE 1 (CON TURNOS ABONADOS - HISTORIA CLÍNICA COMPLETA)
            var paciente1 = new E_Paciente(
                "Pérez", "María", "34123456", Genero.M, new DateOnly(1990, 2, 14),
                "Calle Principal 123", "1156781234", "maria.perez@email.com",
                ObraSocial.OSDE, "OSDE-123456");

            // Historia clínica paciente 1 (MÚLTIPLES ENTRADAS)
            var entrada1a = new E_Entrada(
                paciente1.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Control cardiológico rutinario\n\nDiagnóstico: Estado cardiovascular estable\n\nObservaciones: ECG dentro de parámetros normales.",
                new DateTime(fechaHoy.AddMonths(-6), new TimeOnly(9, 0)));
            
            var entrada1b = new E_Entrada(
                paciente1.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Palpitaciones ocasionales\n\nDiagnóstico: Arritmia benigna\n\nObservaciones: Se indica Holter de 24 horas y reducir consumo de cafeína.",
                new DateTime(fechaHoy.AddMonths(-3), new TimeOnly(10, 30)));

            var entrada1c = new E_Entrada(
                paciente1.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Seguimiento tratamiento\n\nDiagnóstico: Mejoría significativa\n\nObservaciones: Paciente responde bien a medicación, continuar igual.",
                new DateTime(fechaHoy.AddMonths(-1), new TimeOnly(11, 15)));

            paciente1.HistoriaClinica.Entradas.AddRange(new[] { entrada1a, entrada1b, entrada1c });
            EntradasDB.AddRange(new[] { entrada1a, entrada1b, entrada1c });

            // PACIENTE 2 (CON TURNOS ABONADOS - HISTORIA CLÍNICA COMPLETA)
            var paciente2 = new E_Paciente(
                "Gómez", "Juan", "35123456", Genero.H, new DateOnly(1985, 7, 22),
                "Av. Central 456", "1167895678", "juan.gomez@email.com",
                ObraSocial.SWISS_MEDICAL, "SM-789012");

            // Historia clínica paciente 2 (MÚLTIPLES ENTRADAS)
            var entrada2a = new E_Entrada(
                paciente2.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Dolor precordial\n\nDiagnóstico: Angina de pecho estable\n\nObservaciones: Se realiza ergometría con resultado positivo.",
                new DateTime(fechaHoy.AddMonths(-5), new TimeOnly(8, 30)));
            
            var entrada2b = new E_Entrada(
                paciente2.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Control post tratamiento\n\nDiagnóstico: Mejoría del dolor precordial\n\nObservaciones: Paciente refiere mejoría con medicación indicada.",
                new DateTime(fechaHoy.AddMonths(-2), new TimeOnly(10, 0)));

            var entrada2c = new E_Entrada(
                paciente2.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Revisión anual\n\nDiagnóstico: Estabilidad clínica\n\nObservaciones: Mantener tratamiento actual y control en 6 meses.",
                new DateTime(fechaHoy.AddMonths(-1), new TimeOnly(14, 45)));

            paciente2.HistoriaClinica.Entradas.AddRange(new[] { entrada2a, entrada2b, entrada2c });
            EntradasDB.AddRange(new[] { entrada2a, entrada2b, entrada2c });

            // PACIENTE 3 (CON TURNOS ABONADOS - HISTORIA CLÍNICA COMPLETA)
            var paciente3 = new E_Paciente(
                "Rodríguez", "Lucía", "29123456", Genero.M, new DateOnly(1995, 12, 3),
                "Calle Secundaria 789", "1178906789", "lucia.rodriguez@email.com",
                ObraSocial.PARTICULAR, "PART-001");

            // Historia clínica paciente 3 (MÚLTIPLES ENTRADAS)
            var entrada3a = new E_Entrada(
                paciente3.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Soplo cardíaco\n\nDiagnóstico: Soplo inocente\n\nObservaciones: Ecocardiograma normal, no requiere tratamiento.",
                new DateTime(fechaHoy.AddMonths(-4), new TimeOnly(9, 45)));
            
            var entrada3b = new E_Entrada(
                paciente3.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Mareos ocasionales\n\nDiagnóstico: Hipotensión ortostática\n\nObservaciones: Recomendado aumentar hidratación y levantarse lentamente.",
                new DateTime(fechaHoy.AddMonths(-2), new TimeOnly(11, 30)));

            var entrada3c = new E_Entrada(
                paciente3.HistoriaClinica.IdHistoriaClinica, profesional1.IdProfesional,
                "Motivo: Control rutinario\n\nDiagnóstico: Estabilidad del soplo\n\nObservaciones: Paciente asintomática, continuar seguimiento anual.",
                new DateTime(fechaHoy.AddMonths(-1), new TimeOnly(15, 20)));

            paciente3.HistoriaClinica.Entradas.AddRange(new[] { entrada3a, entrada3b, entrada3c });
            EntradasDB.AddRange(new[] { entrada3a, entrada3b, entrada3c });

            // PACIENTE 4
            var paciente4 = new E_Paciente(
                "Fernández", "Pedro", "32123456", Genero.H, new DateOnly(1978, 4, 18),
                "Bv. Norte 321", "1189017890", "pedro.fernandez@email.com",
                ObraSocial.GALENO, "GAL-456789");

            // PACIENTE 5
            var paciente5 = new E_Paciente(
                "Díaz", "Ana", "27123456", Genero.M, new DateOnly(1988, 9, 30),
                "Av. Sur 654", "1190128901", "ana.diaz@email.com",
                ObraSocial.OMINT, "OMI-987654");

            // PACIENTES ORIGINALES ADAPTADOS
            var pacienteJuan = new E_Paciente(
                "Perez", "Juan", "11222333", Genero.H, new DateOnly(1956, 12, 16),
                "Calle Falsa 321", "46759922", "juan.perez@email.com",
                ObraSocial.PARTICULAR, "PART-112233");

            var pacienteFlorinda = new E_Paciente(
                "Mesa", "Florinda", "22333444", Genero.M, new DateOnly(1976, 7, 29),
                "Calle Falsa 123", "47582948", "florinda.mesa@email.com",
                ObraSocial.SANCOR_SALUD, "SANCOR-600123");

            PacientesDB.AddRange(new[] { paciente1, paciente2, paciente3, paciente4, paciente5, pacienteJuan, pacienteFlorinda });

            // ========== TURNOS DEL DR. GARCÍA PARA HOY (16:00 - 22:00) ==========

            var turnosHoyProf1 = new List<E_Turno>();
            var horaInicio = new TimeSpan(16, 0, 0);

            // GENERAR TURNOS CADA 15 MINUTOS DE 16:00 A 22:00
            for (int i = 0; i < 24; i++) // 6 horas * 4 turnos por hora = 24 turnos
            {
                int totalMinutos = 16 * 60 + (i * 15); // 16:00 en minutos + incremento
                int horas = totalMinutos / 60;
                int minutos = totalMinutos % 60;

                var turno = new E_Turno(
                    new DateTime(fechaHoy.Year, fechaHoy.Month, fechaHoy.Day, horas, minutos, 0),
                    profesional1.IdProfesional,
                    5000m
                );
                turnosHoyProf1.Add(turno);
            }

            // ASIGNAR ESTADOS SEGÚN REQUISITOS
            for (int i = 0; i < turnosHoyProf1.Count; i++)
            {
                var turno = turnosHoyProf1[i];
                
                // Turnos 16:00 - 19:00 (primeros 12 turnos): FINALIZADO
                if (i < 12)
                {
                    turno.Estado = EstadoTurno.FINALIZADO;
                    // Asignar pacientes aleatorios a algunos turnos finalizados
                    if (i % 2 == 0)
                    {
                        turno.IdPaciente = paciente1.IdPaciente;
                        paciente1.Reservas.Add(turno);
                    }
                    else if (i % 3 == 0)
                    {
                        turno.IdPaciente = paciente2.IdPaciente;
                        paciente2.Reservas.Add(turno);
                    }
                }
                // Siguientes 5 turnos (19:00 - 20:00): ABONADO
                else if (i < 17)
                {
                    turno.Estado = EstadoTurno.ABONADO;
                    // Asignar pacientes con historia clínica completa
                    if (i == 12) { turno.IdPaciente = paciente1.IdPaciente; paciente1.Reservas.Add(turno); }
                    else if (i == 13) { turno.IdPaciente = paciente2.IdPaciente; paciente2.Reservas.Add(turno); }
                    else if (i == 14) { turno.IdPaciente = paciente3.IdPaciente; paciente3.Reservas.Add(turno); }
                    else if (i == 15) { turno.IdPaciente = paciente1.IdPaciente; paciente1.Reservas.Add(turno); }
                    else if (i == 16) { turno.IdPaciente = paciente2.IdPaciente; paciente2.Reservas.Add(turno); }
                }
                // Resto de turnos (20:00 - 22:00): VARIOS ESTADOS
                else
                {
                    if (i % 2 == 0)
                    {
                        turno.Estado = EstadoTurno.ASIGNADO;
                        // Asignar algunos pacientes
                        if (i == 18) { turno.IdPaciente = paciente4.IdPaciente; paciente4.Reservas.Add(turno); }
                        else if (i == 20) { turno.IdPaciente = paciente5.IdPaciente; paciente5.Reservas.Add(turno); }
                    }
                    else
                    {
                        turno.Estado = EstadoTurno.DISPONIBLE;
                    }
                }
            }

            // AGREGAR TURNOS A LA BASE DE DATOS
            foreach (var turno in turnosHoyProf1)
            {
                TurnosDB.Add(turno);
                profesional1.AgendaMedica.Add(turno);
            }

            // ========== PAGOS ==========

            // Pagos para turnos ABONADOS
            var pagosAbonados = new List<E_Pago>
            {
                new E_Pago(paciente1.IdPaciente, turnosHoyProf1[12].IdTurno, 5000m)
                {
                    Estado = EstadoPago.REALIZADO,
                    MetodoPago = MetodoPago.TARJETA_CREDITO,
                    FechaPago = fechaHoy
                },
                new E_Pago(paciente2.IdPaciente, turnosHoyProf1[13].IdTurno, 5000m)
                {
                    Estado = EstadoPago.REALIZADO,
                    MetodoPago = MetodoPago.EFECTIVO,
                    FechaPago = fechaHoy
                },
                new E_Pago(paciente3.IdPaciente, turnosHoyProf1[14].IdTurno, 5000m)
                {
                    Estado = EstadoPago.REALIZADO,
                    MetodoPago = MetodoPago.TRANSFERENCIA,
                    FechaPago = fechaHoy
                },
                new E_Pago(paciente1.IdPaciente, turnosHoyProf1[15].IdTurno, 5000m)
                {
                    Estado = EstadoPago.REALIZADO,
                    MetodoPago = MetodoPago.TARJETA_DEBITO,
                    FechaPago = fechaHoy
                },
                new E_Pago(paciente2.IdPaciente, turnosHoyProf1[16].IdTurno, 5000m)
                {
                    Estado = EstadoPago.REALIZADO,
                    MetodoPago = MetodoPago.EFECTIVO,
                    FechaPago = fechaHoy
                }
            };

            PagosDB.AddRange(pagosAbonados);
            paciente1.PagosRealizados.Add(pagosAbonados[0]);
            paciente1.PagosRealizados.Add(pagosAbonados[3]);
            paciente2.PagosRealizados.Add(pagosAbonados[1]);
            paciente2.PagosRealizados.Add(pagosAbonados[4]);
            paciente3.PagosRealizados.Add(pagosAbonados[2]);

            // ========== INSUMOS ==========
            var insumos = new List<E_Insumo>
            {
                new E_Insumo("JER-001", "Jeringa 10ml", "Jeringa descartable 10ml", 200),
                new E_Insumo("GNT-M", "Guantes M", "Guantes de latex talla M", 500),
                new E_Insumo("ALG-500", "Alcohol gel", "Alcohol en gel 500ml", 50),
                new E_Insumo("CUB-B", "Cubrebocas", "Cubrebocas quirúrgico", 300),
                new E_Insumo("AGA-100", "Gasas", "Gasas estériles 10x10", 150)
            };

            InsumosDB.AddRange(insumos);

            // ========== PEDIDOS DE INSUMOS ==========
            var insumosSolicitados = new List<E_InsumoSolicitado>
            {
                new E_InsumoSolicitado(insumos[0], 50),
                new E_InsumoSolicitado(insumos[1], 100),
                new E_InsumoSolicitado(insumos[2], 10)
            };

            var pedidoInsumo = new E_PedidoInsumo(profesional1.IdProfesional, insumosSolicitados);
            PedidosInsumos.Add(pedidoInsumo);

            // ========== CONSULTORIOS ==========
            var consultorio1 = new E_Consultorio();
            consultorio1.IdProfesional = profesional1.IdProfesional;
            consultorio1.Insumos.AddRange(insumos.Take(3));

            var consultorio2 = new E_Consultorio();
            consultorio2.IdProfesional = profesional2.IdProfesional;
            consultorio2.Insumos.AddRange(insumos.Skip(2).Take(2));

            ConsultoriosDB.AddRange(new[] { consultorio1, consultorio2 });

            // ACTUALIZAR CONTADORES
            profesional1.ConsultasAtendidas = 12; // Todos los turnos finalizados
        }

        private static void ResetAutoIncrementCounters()
        {
            // Usar reflexión para resetear todos los contadores static
            var fields = typeof(DDBB_Simulation).Assembly.GetTypes()
                .SelectMany(t => t.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic))
                .Where(f => f.Name == "ID_AUTOINCREMENT");

            foreach (var field in fields)
            {
                field.SetValue(null, 0);
            }
        }
    }
}