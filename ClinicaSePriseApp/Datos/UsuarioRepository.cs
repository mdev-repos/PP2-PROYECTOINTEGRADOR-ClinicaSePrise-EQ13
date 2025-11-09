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
        // CREATE
        public void AgregarUsuario(E_Usuario nuevoUsuario)
        {
            DDBB_Simulation.UsuariosDB.Add(nuevoUsuario);
        }

        // READ
        public List<E_Usuario> TraerTodosLosUsuarios()
        {
            return DDBB_Simulation.UsuariosDB;
        }

        public E_Usuario? ObtenerUsuarioPorCredenciales(string nombreUsuario, string contrasena)
        {
            return DDBB_Simulation.UsuariosDB
                .FirstOrDefault(u => u.UserName == nombreUsuario && u.UserPass == contrasena);
        }
    }
}
