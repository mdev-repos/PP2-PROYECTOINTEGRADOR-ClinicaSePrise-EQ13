using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class PacienteRepository
    {
        // CREATE
        public void GuardarPaciente(E_Paciente nuevoPaciente)
        {
            DDBB_Simulation.PacientesDB.Add(nuevoPaciente);
        }

        // READ
        public List<E_Paciente> ObtenerTodosLosPacientes()
        {
            return DDBB_Simulation.PacientesDB;
        }

        public E_Paciente? ObtenerPacientePorID(int? id)
        {
            E_Paciente? pacienteEncontrado = 
                DDBB_Simulation.PacientesDB.FirstOrDefault(t => t.IdPaciente == id);
            
            return pacienteEncontrado;
        }

        public E_Paciente? ObtenerPacientePorDNI(string dni)
        {
            E_Paciente? pacienteEncontrado =
                DDBB_Simulation.PacientesDB.FirstOrDefault(p => p.Dni == dni);
            return pacienteEncontrado;
        }
    }
}
