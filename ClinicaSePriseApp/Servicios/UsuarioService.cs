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
        // INYECCION
        private static UsuarioRepository userRepo = new UsuarioRepository();

        // CREATE
        public static void AgregarUsuario(E_Usuario nuevoUsuario)
        {
            userRepo.AgregarUsuario(nuevoUsuario);
        }

        // READ
        public static List<E_Usuario> TraerTodosLosUsuarios()
        {
            return userRepo.TraerTodosLosUsuarios();
        }

        public static E_Usuario? ObtenerUsuarioPorCredenciales(string nombreUsuario, string contrasena)
        {
            return userRepo.ObtenerUsuarioPorCredenciales(nombreUsuario, contrasena);
        }
    }
}
