using System;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Liquidacion
    {
        public int IdLiquidacion { get; set; }
        public int IdProfesional { get; set; }
        public DateOnly FechaLiquidacion { get; set; }
        public string PeriodoLiquidado { get; set; }
        public decimal Monto { get; set; }

        public E_Liquidacion(int id, int profesional, DateOnly fecha, string periodo, decimal monto)
        {
            IdLiquidacion = id;
            IdProfesional = profesional;
            FechaLiquidacion = fecha;
            PeriodoLiquidado = periodo;
            Monto = monto;
        }
    }
}