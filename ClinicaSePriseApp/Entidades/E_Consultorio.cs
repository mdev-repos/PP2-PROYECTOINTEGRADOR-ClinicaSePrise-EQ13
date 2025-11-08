using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Consultorio
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdConsultorio { get; set; }
        public int IdProfesional { get; set; }
        public List<E_Insumo> Insumos { get; set; }

        public E_Consultorio()
        {
            ID_AUTOINCREMENT++;

            IdConsultorio = ID_AUTOINCREMENT;
            Insumos = new List<E_Insumo>();
        }
    }
}