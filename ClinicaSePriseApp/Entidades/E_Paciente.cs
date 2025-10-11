using ClinicaSePrise.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Paciente : E_Persona
    {
        public string IdPaciente { get; set; }
        public string ObraSocial { get; set; }
        public string NumeroAfiliado { get; set; }
        public E_HistoriaClinica HistoriaClinica { get; set; }
        public List<E_Turno> Reservas { get; set; }
        public List<E_Pago> PagosRealizados { get; set; }
    }
}
