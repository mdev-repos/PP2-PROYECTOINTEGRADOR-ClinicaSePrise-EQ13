using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_HistoriaClinica
    {
        public string IdHistoriaClinica { get; set; }
        public string IdPaciente { get; set; }
        public List<E_Entrada> Entradas { get; set; }
    }
}
