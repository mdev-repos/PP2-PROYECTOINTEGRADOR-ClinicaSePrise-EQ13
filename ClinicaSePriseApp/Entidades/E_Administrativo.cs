using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Administrativo : E_Persona
    {
        public string IdAdministrativo { get; set; }
        public E_Usuario Usuario { get; set; }
    }
}
