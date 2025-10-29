using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum EstadoTurno
    {
        [Description("Disponible")]
        DISPONIBLE,
        [Description("Asignado")]
        ASIGNADO,
        [Description("En Atención")]
        EN_ATENCION,
        [Description("Finalizado")]
        FINALIZADO
    }
}
