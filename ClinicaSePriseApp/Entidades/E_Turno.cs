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
        private static int ID_AUTOINCREMENT = 0;

        public int IdTurno { get; set; }
        public DateTime FechaTurno { get; set; }
        public int IdProfesional { get; set; }
        public int? IdPaciente { get; set; } = null;
        public decimal Monto { get; set; }
        public EstadoTurno Estado { get; set; } = EstadoTurno.DISPONIBLE;


        // CONSTRUCTOR
        public E_Turno(DateTime fecha, int idProf, decimal monto)
        {
            ID_AUTOINCREMENT++;

            IdTurno = ID_AUTOINCREMENT;
            FechaTurno = fecha;
            IdProfesional = idProf;
            Monto = monto;
        }

        public E_Turno(DateTime fecha, int idProf, int? idPac, decimal monto, EstadoTurno estado)
        {
            ID_AUTOINCREMENT++;

            IdTurno = ID_AUTOINCREMENT;
            FechaTurno = fecha;
            IdProfesional = idProf;
            IdPaciente = idPac;
            Monto = monto;
            Estado = estado;
        }
    }
}