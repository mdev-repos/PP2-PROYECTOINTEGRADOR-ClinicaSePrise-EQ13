using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_HistoriaClinica
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdHistoriaClinica { get; set; }
        public int IdPaciente { get; set; }
        public List<E_Entrada> Entradas { get; set; }

        public E_HistoriaClinica(int idPaciente)
        {
            ID_AUTOINCREMENT++;

            IdHistoriaClinica = ID_AUTOINCREMENT;
            IdPaciente = idPaciente;
            Entradas = new List<E_Entrada>();
        }
    }
}