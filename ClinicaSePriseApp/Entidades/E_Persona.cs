using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public abstract class E_Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public Genero Genero { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


        // CONSTRUCTOR
        protected E_Persona(string apellido, string nombre, string dni, Genero genero, DateOnly fechaNacimiento,
                           string direccion, string telefono, string email)
        {
            Apellido = apellido;
            Nombre = nombre;
            Dni = dni;
            Genero = genero;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

    }
}
