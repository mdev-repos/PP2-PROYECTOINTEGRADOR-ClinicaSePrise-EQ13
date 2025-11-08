using System;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Liquidacion
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdLiquidacion { get; set; }
        public int IdProfesional { get; set; }
        public DateOnly FechaLiquidacion { get; set; }
        public string PeriodoLiquidado { get; set; }
        public decimal Monto { get; set; }

        public E_Liquidacion(int profesional, DateOnly fecha, string periodo, decimal monto)
        {
            ID_AUTOINCREMENT++;

            IdLiquidacion = ID_AUTOINCREMENT;
            IdProfesional = profesional;
            FechaLiquidacion = fecha;
            PeriodoLiquidado = periodo;
            Monto = monto;
        }
    }
}