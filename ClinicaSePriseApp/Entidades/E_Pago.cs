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
        public string IdPago { get; set; }
        public string IdPaciente { get; set; }
        public string IdTurno { get; set; }
        public string FechaPago { get; set; }
        public float Monto { get; set; }
        public EstadoPago Estado { get; set; }
        public MetodoPago MetodoPago { get; set; }
    }
}
