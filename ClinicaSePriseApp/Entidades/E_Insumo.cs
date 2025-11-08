using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_Insumo
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdInsumo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }


        public E_Insumo(string codigo, string nombre, string descripcion, float cantidad)
        {
            ID_AUTOINCREMENT++;
            IdInsumo = ID_AUTOINCREMENT;
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            Cantidad = cantidad;
        }
    }
}