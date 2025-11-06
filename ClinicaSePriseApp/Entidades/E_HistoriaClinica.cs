using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public int IdPaciente { get; set; }
        public List<E_Entrada> Entradas { get; set; }

        public E_HistoriaClinica(int idPaciente)
        {
            IdHistoriaClinica = idPaciente;
            IdPaciente = idPaciente;
            Entradas = new List<E_Entrada>();
        }
    }
}
