using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

// Necesitas el paquete NuGet Microsoft.Extensions.Configuration si usas .NET moderno para leer appsettings.json

namespace ClinicaSePriseApp.Datos
{
    public class DB_Conexion
    {
        private readonly string _connectionString;

        public DB_Conexion(IConfiguration configuration)
        {
            // Lee la cadena de conexión del archivo FunAccess.json
            _connectionString = configuration.GetConnectionString("FunAccess.json");
        }

        // Método para obtener una conexión abierta
        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(_connectionString);
            // Es buena práctica intentar abrir la conexión inmediatamente
            connection.Open();
            return connection;
        }
    }
}