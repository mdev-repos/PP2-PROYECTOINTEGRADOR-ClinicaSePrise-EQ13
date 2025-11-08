using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum EstadoPedidoInsumo
    {
        [Description("Solicitado")]
        SOLICITADO,
        [Description("Entregado")]
        ENTREGADO,
        [Description("Rechazado")]
        RECHAZADO
    }
}
