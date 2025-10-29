using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum MetodoPago
    {
        [Description("Efectivo")]
        EFECTIVO,
        [Description("Tarjeta de Crédito")]
        TARJETA_CREDITO,
        [Description("Tarjeta de Débito")]
        TARJETA_DEBITO,
        [Description("Transferencia")]
        TRANSFERENCIA,
        [Description("Código QR")]
        QR,
        [Description("Otro")]
        OTRO
    }
}
