using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class PagoRepository
    {
        // CREATE
        public void GuardarPago(E_Pago pago)
        { 
            DDBB_Simulation.PagosDB.Add(pago);
        }

        // READ
        public List<E_Pago> ObtenerTodosLosPagos()
        {
            return DDBB_Simulation.PagosDB;
        }

        public E_Pago? ObtenerPagoPorID(int? id)
        {
            return DDBB_Simulation.PagosDB
                .FirstOrDefault(p => p.IdPago == id);
        }

        public List<E_Pago> ObtenerPagosPorPaciente(int idPaciente)
        {
            return DDBB_Simulation.PagosDB
                .Where(p => p.IdPaciente == idPaciente)
                .ToList();
        }

    }
}
