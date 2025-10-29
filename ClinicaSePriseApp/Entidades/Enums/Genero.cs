using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum Genero
    {
        [Description("Mujer")]
        M,
        [Description("Hombre")]
        H,
        [Description("No Binario")]
        X,
    }
}
