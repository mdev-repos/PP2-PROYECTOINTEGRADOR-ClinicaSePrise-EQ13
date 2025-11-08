using ClinicaSePriseApp.Entidades.Enums;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClinicaSePriseApp.Utilidades.DDBB_Simulation;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Paciente : E_Persona
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdPaciente { get; set; }
        public ObraSocial ObraSocial { get; set; }
        public string NumeroAfiliado { get; set; }
        public E_HistoriaClinica HistoriaClinica { get; set; }
        public List<E_Turno> Reservas { get; set; }
        public List<E_Pago> PagosRealizados { get; set; }


        public E_Paciente(string apellido, string nombre, string dni, Genero genero,
                         DateOnly fechaNacimiento, string direccion, string telefono,
                         string email, ObraSocial obraSocial, string numeroAfiliado)
            : base(apellido, nombre, dni, genero, fechaNacimiento, direccion, telefono, email)
        {
            ID_AUTOINCREMENT++;

            IdPaciente = ID_AUTOINCREMENT;
            ObraSocial = obraSocial;
            NumeroAfiliado = numeroAfiliado;
            HistoriaClinica = new E_HistoriaClinica(IdPaciente);
            Reservas = new List<E_Turno>();
            PagosRealizados = new List<E_Pago>();
        }

        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}