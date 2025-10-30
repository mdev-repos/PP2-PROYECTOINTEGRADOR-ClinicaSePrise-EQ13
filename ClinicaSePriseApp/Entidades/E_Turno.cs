using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Entidades.Enums;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Turno
    {
        public int IdTurno { get; set; }
        public DateTime FechaTurno { get; set; }
        public int IdProfesional { get; set; }
        public int? IdPaciente { get; set; } = null;
        public decimal Monto { get; set; }
        public EstadoTurno Estado { get; set; } = EstadoTurno.DISPONIBLE;


        // CONSTRUCTOR
        public E_Turno(int id, DateTime fecha, int idProf, decimal monto)
        {
            IdTurno = id;
            FechaTurno = fecha;
            IdProfesional = idProf;
            Monto = monto;
        }
    }
}
