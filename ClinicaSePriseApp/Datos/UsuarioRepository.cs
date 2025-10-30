using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class UsuarioRepository
    {
        public List<E_Usuario> TraerTodosLosUsuarios()
        {
            return DDBB_Simulation.UsuariosDB;
        }
    }
}
