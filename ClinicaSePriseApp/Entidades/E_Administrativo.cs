using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Administrativo : E_Persona
    {
        public int IdAdministrativo { get; set; }
        public int IdUsuario { get; set; }


        // CONSTRUCTOR
        public E_Administrativo(
            int idAdmin, int userId,

            string apellido, string nombre, string dni, Genero genero, DateOnly fechaNacimiento,
            string direccion, string telefono, string email )

            : base(apellido, nombre, dni, genero, fechaNacimiento, direccion, telefono, email)
        {
            IdAdministrativo = idAdmin;
            IdUsuario = userId;
        }
    }
}
