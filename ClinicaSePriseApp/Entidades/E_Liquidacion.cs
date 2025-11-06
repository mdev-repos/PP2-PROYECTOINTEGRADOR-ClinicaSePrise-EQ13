using System;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Liquidacion
    {
        public int IdLiquidacion { get; set; }
        public int IdProfesional { get; set; }
        public string Periodo { get; set; }
        public float Monto { get; set; }
    }
}