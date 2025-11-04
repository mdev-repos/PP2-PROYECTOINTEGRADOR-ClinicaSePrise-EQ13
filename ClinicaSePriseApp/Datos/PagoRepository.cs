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

    }
}
