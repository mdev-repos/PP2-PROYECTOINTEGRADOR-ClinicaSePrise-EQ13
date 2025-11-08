using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Disponibilidad
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdDisponibilidad { get; set; }
        public DayOfWeek Dia { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }


        public E_Disponibilidad(DayOfWeek day, TimeSpan hrInicio, TimeSpan hrFin) 
        {
            ID_AUTOINCREMENT++;

            IdDisponibilidad = ID_AUTOINCREMENT;
            Dia = day;
            HoraInicio = hrInicio;
            HoraFin = hrFin;
        }
    }
}