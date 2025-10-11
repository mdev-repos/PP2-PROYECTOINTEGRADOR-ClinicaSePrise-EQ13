using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Consultorio
    {
        public string IdConsultorio { get; set; }
        public string IdProfesional { get; set; }
        public List<E_Insumo> Insumos { get; set; }
    }
}


