using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Entidades.Enums;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Pago
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdPago { get; set; }
        public int IdPaciente { get; set; }
        public int IdTurno { get; set; }
        public DateOnly? FechaPago { get; set; } = null;
        public decimal Monto { get; set; }
        public EstadoPago Estado { get; set; } = EstadoPago.PENDIENTE;
        public MetodoPago? MetodoPago { get; set; }


        public E_Pago(int idPaciente, int idTurno, decimal monto)
        {
            ID_AUTOINCREMENT++;

            IdPago = ID_AUTOINCREMENT;
            IdPaciente = idPaciente;
            IdTurno = idTurno;
            Monto = monto;
        }
    }
}