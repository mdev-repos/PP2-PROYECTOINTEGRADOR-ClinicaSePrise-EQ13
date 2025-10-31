using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class TurnoRepository
    {
        // CREATE
        public void GuardarTurno(E_Turno nuevoTurno)
        {
            DDBB_Simulation.TurnosDB.Add(nuevoTurno);
        }

        // READ
        public List<E_Turno> TraerTodosLosTurnos()
        {
            return DDBB_Simulation.TurnosDB;
        }

        public E_Turno? ObtenerTurnoPorID(int id)
        {
            E_Turno? turnoEncontrado = DDBB_Simulation.TurnosDB.FirstOrDefault(t => t.IdTurno == id);
            return turnoEncontrado;
        }

        // UPDATE
        public void ActualizarTurno(E_Turno turnoActualizado)
        {

        }
    }
}
