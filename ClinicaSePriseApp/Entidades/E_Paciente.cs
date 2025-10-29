using ClinicaSePriseApp.Entidades.Enums;
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
        public ObraSocial ObraSocial { get; set; }
        public string NumeroAfiliado { get; set; }
        public E_HistoriaClinica HistoriaClinica { get; set; }
        public List<E_Turno> Reservas { get; set; }
        public List<E_Pago> PagosRealizados { get; set; }


        // Métodos

        // Constructor
        public E_Paciente(string idPaciente, string apellido, string nombre, string dni, Genero genero,
                         DateOnly fechaNacimiento, string direccion, string telefono,
                         string email, ObraSocial obraSocial, string numeroAfiliado)
            : base(apellido, nombre, dni, genero, fechaNacimiento, direccion, telefono, email)
        {
            IdPaciente = idPaciente;
            ObraSocial = obraSocial;
            NumeroAfiliado = numeroAfiliado;
            HistoriaClinica = new E_HistoriaClinica();
            Reservas = new List<E_Turno>();
            PagosRealizados = new List<E_Pago>();
        }

        
    }
}
