using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Disponibilidad
    {
        public string IdDisponibilidad { get; set; }
        public string Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
    }
}