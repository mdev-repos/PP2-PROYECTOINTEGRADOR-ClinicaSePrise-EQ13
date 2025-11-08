using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_InsumoSolicitado
    {
        public E_Insumo Insumo { get; set; }
        public float CantidadSolicitada { get; set; }

        public E_InsumoSolicitado(E_Insumo insumo, float cantidadSolicitada)
        {
            Insumo = insumo;
            CantidadSolicitada = cantidadSolicitada;
        }
    }
}
