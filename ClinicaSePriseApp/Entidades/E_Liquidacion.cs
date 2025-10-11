using System;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Liquidacion
    {
        public string IdLiquidacion { get; set; }
        public string IdProfesional { get; set; }
        public string Periodo { get; set; }
        public float Monto { get; set; }
    }
}