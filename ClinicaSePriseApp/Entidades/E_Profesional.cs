using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class Profesional : E_Persona
    {
        public string IdProfesional { get; set; }
        public E_Usuario Usuario { get; set; }
        public EspecialidadMedica especialidad { get; set; }
        public string Matricula { get; set; }

    }
}
