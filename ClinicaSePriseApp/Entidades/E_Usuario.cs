using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Usuario
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public Rol rol { get; set; }


        // CONSTRUCTOR
        public E_Usuario(int id, string name, string pass, Rol rol)
        {
            this.IdUsuario = id;
            this.UserName = name;
            this.UserPass = pass;
            this.rol = rol;
        }

    }
}
