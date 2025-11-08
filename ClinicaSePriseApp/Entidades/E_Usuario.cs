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
        private static int ID_AUTOINCREMENT = 0;

        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public Rol rol { get; set; }


        // CONSTRUCTOR
        public E_Usuario(string name, string pass, Rol rol)
        {
            ID_AUTOINCREMENT++;

            this.IdUsuario = ID_AUTOINCREMENT;
            this.UserName = name;
            this.UserPass = pass;
            this.rol = rol;
        }
    }
}