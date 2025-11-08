using ClinicaSePriseApp.Entidades.Enums;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Profesional : E_Persona
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdProfesional { get; set; }
        public int IdUsuario { get; set; }
        public EspecialidadMedica Especialidad { get; set; }
        public string Matricula { get; set; }

        public List<E_Disponibilidad> Disponibilidades { get; set; }

        public List<E_Turno> AgendaMedica { get; set; } = new List<E_Turno>();
        public int ConsultasAtendidas { get; set; } = 0;
        public List<E_Liquidacion> Liquidaciones { get; set; } = new List<E_Liquidacion>();


        public E_Profesional(
            int userId, EspecialidadMedica especialidad, string matricula, 
            List<E_Disponibilidad> disponibilidades,
                             
            string apellido, string nombre, string dni, Genero genero, DateOnly fechaNacimiento, 
            string direccion, string telefono, string email)

            : base(apellido, nombre, dni, genero, fechaNacimiento, direccion, telefono, email)
        {            
            ID_AUTOINCREMENT++;

            IdProfesional = ID_AUTOINCREMENT;
            IdUsuario = userId;
            Especialidad = especialidad;
            Matricula = matricula;
            Disponibilidades = disponibilidades;
        }

        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}