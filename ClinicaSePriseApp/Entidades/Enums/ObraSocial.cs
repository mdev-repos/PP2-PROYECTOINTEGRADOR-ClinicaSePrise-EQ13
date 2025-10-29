using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades.Enums
{
    public enum ObraSocial
    {
        [Description("Particular")]
        PARTICULAR,
        [Description("Swiss Medical")]
        SWISS_MEDICAL,
        [Description("Galeno")]
        GALENO,
        [Description("O.S.D.E.")]
        OSDE,
        [Description("O.S.E.C.A.C.")]
        OSECAC,
        [Description("Salud Total")]
        SALUD_TOTAL,
        [Description("Prevenir Salud")]
        PREVENIR_SALUD,
        [Description("Medicina Activa")]
        MEDICINA_ACTIVA,
        [Description("O.S.P.E.")]
        OSPE,
        [Description("Union Médica")]
        UNION_MEDICA,
        [Description("Plan Integral")]
        PLAN_INTEGRAL,
        [Description("Asegurar Vida")]
        ASEGURAR_VIDA,
        [Description("Cobertura Azul")]
        COBERTURA_AZUL,
        [Description("O.S.M.A.")]
        OSMA,
        [Description("Sancor Salud")]
        SANCOR_SALUD,
        [Description("Prevención Médica")]
        PREVENCION_MEDICA,
        [Description("Consultar Ahora")]
        CONSULTAR_AHORA,
        [Description("Bienestar Total")]
        BIENESTAR_TOTAL,
        [Description("Red de Sanación")]
        RED_SANACION,
        [Description("O.S.P.I.L.")]
        OSPIL,
        [Description("Grupo Médico Sur")]
        GRUPO_MEDICO_SUR,
        [Description("Servicio Superior")]
        SERVICIO_SUPERIOR
    }
}
