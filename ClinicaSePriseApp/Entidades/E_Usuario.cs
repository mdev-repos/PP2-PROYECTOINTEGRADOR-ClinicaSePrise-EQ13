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
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public Rol rol { get; set; }
    }
}
