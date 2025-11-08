using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Entrada
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdEntrada { get; set; }
        public int IdHistoriaClinica { get; set; }
        public int IdProfesional { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaEntrada { get; set; }

        public E_Entrada(int idHistoria, int idProfesional, string observaciones, DateTime fecha)
        {
            ID_AUTOINCREMENT++;

            IdEntrada = ID_AUTOINCREMENT;
            IdHistoriaClinica = idHistoria;
            IdProfesional = idProfesional;
            Observaciones = observaciones;
            FechaEntrada = fecha;
        }
    }
}