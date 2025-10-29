using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Entrada
    {
        public string IdEntrada { get; set; }
        public string IdHistoriaClinica { get; set; }
        public string IdProfesional { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}