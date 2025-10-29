using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum EspecialidadMedica
    {
        [Description("Pediatría")]
        PEDIATRIA,
        [Description("Geriatría")]
        GERIATRIA,
        [Description("Ginecología y Obstetricia")]
        GINECOLOGIA_OBSTETRICIA,
        [Description("Cardiología")]
        CARDIOLOGIA,
        [Description("Dermatología")]
        DERMATOLOGIA,
        [Description("Clínica Médica")]
        CLINICA_MEDICA,
        [Description("Traumatología")]
        TRAUMATOLOGIA,
        [Description("Oftalmología")]
        OFTALMOLOGIA,
        [Description("Neurología")]
        NEUROLOGIA,
        [Description("Urología")]
        UROLOGIA 
    }
}
