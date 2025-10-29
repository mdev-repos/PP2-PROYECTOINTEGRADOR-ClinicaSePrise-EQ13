using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum EstadoPago
    {
        [Description("Pendiente")]
        PENDIENTE,
        [Description("Realizado")]
        REALIZADO,
        [Description("Rechazado")]
        RECHAZADO
    }
}
