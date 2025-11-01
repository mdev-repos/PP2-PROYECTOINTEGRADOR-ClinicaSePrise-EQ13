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
        // Inyeccion de dependencia simple
        public static PacienteRepository pacienteRepo = new PacienteRepository();

        // Create
        public static void GuardarPaciente(E_Paciente nuevoPaciente)
        {
            pacienteRepo.GuardarPaciente(nuevoPaciente);
        }


        // Read
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
    }
}
