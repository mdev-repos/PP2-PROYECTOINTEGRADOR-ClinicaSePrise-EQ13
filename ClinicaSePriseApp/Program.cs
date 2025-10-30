using ClinicaSePriseApp.Vistas;

namespace ClinicaSePriseApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Utilidades.DDBB_Simulation.InicializarDatosPrueba();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}