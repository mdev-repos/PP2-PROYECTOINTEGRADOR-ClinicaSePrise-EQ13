using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class PacienteService
    {
        // INYECCION
        public static PacienteRepository pacienteRepo = new PacienteRepository();

        // CREATE
        public static void GuardarPaciente(E_Paciente nuevoPaciente)
        {
            pacienteRepo.GuardarPaciente(nuevoPaciente);
        }


        // READ
        public static E_Paciente? ObtenerPacientePorID(int? id)
        {
            return pacienteRepo.ObtenerPacientePorID(id);
        }

        public static E_Paciente? ObtenerPacientePorDNI(string dni)
        {
            return pacienteRepo.ObtenerPacientePorDNI(dni);
        }

        public static List<E_Paciente> ObtenerTodosLosPacientes()
        {
            return pacienteRepo.ObtenerTodosLosPacientes();
        }


        // UPDATE
        public static void AgregarPago(E_Paciente paciente, E_Pago pago)
        { 
            paciente.PagosRealizados.Add(pago);
        }
    }
}
