using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class InsumoRepository
    {
        // CREATE
        public void GuardarInsumo(E_Insumo insumo)
        {
            DDBB_Simulation.InsumosDB.Add(insumo);
        }


        // READ
        public List<E_Insumo> ObtenerInsumos()
        {
            return DDBB_Simulation.InsumosDB;
        }

        public E_Insumo? ObtenerInsumoPorId(int idInsumo)
        {
            return DDBB_Simulation.InsumosDB.FirstOrDefault(i => i.IdInsumo == idInsumo);
        }
    }
}