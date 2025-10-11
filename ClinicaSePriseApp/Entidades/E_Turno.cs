using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Entidades.Enums;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Turno
    {
        public string IdTurno { get; set; }
        public DateTime FechaTurno { get; set; }
        public string IdProfesional { get; set; }
        public string IdPaciente { get; set; }
        public float Monto { get; set; }
        public EstadoTurno Estado { get; set; }
    }
}
