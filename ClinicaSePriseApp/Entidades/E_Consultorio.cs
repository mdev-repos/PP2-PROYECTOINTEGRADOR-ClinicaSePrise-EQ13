using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Consultorio
    {
        public int IdConsultorio { get; set; }
        public int IdProfesional { get; set; }
        public List<E_Insumo> Insumos { get; set; }
    }
}


