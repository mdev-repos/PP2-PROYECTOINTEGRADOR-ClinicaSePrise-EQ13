using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Disponibilidad
    {
        public int IdDisponibilidad { get; set; }
        public DayOfWeek Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }


        // CONSTRUCTOR
        public E_Disponibilidad(int id, DayOfWeek day, TimeSpan hrInicio, TimeSpan hrFin) 
        {
            IdDisponibilidad = id;
            Dia = day;
            HoraInicio = hrInicio;
            HoraFin = hrFin;
        }
    }
}