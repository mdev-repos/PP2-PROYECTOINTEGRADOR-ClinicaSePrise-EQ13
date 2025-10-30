using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class UsuarioService
    {
        // Inyeccion de dependencia simple
        private static UsuarioRepository userRepo = new UsuarioRepository();

        public static E_Usuario? ValidarUsuario(string usuario, string password)
        {
            List<E_Usuario> allUsers = userRepo.TraerTodosLosUsuarios();

            E_Usuario? usuarioRecuperado = null;

            foreach (var user in allUsers)
            {
                if (user.UserName == usuario && user.UserPass == password)
                {
                    usuarioRecuperado = user;
                    break;
                }
            }

            return usuarioRecuperado;
        }
    }
}
