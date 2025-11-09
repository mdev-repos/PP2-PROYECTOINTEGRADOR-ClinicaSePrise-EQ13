using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class PagoService
    {
        private static PagoRepository pagoRepo = new PagoRepository();

        // CREATE
        public static void GuardarPago(E_Pago pago)
        { 
            pagoRepo.GuardarPago(pago);    
        }

        // READ
        public static List<E_Pago> ObtenerTodosLosPagos()
        {
            return pagoRepo.ObtenerTodosLosPagos();
        }

        public static E_Pago? ObtenerPagoPorID(int? id)
        {
            return pagoRepo.ObtenerPagoPorID(id);
        }

        public static List<E_Pago> ObtenerPagosPorPaciente(int idPaciente)
        {
            return pagoRepo.ObtenerPagosPorPaciente(idPaciente) ?? new List<E_Pago>();
        }

        // REALIZAR PAGO
        public static void RealizarPago(E_Pago pago, DateOnly fechaPago, MetodoPago metodoPago)
        {
            pago.FechaPago = fechaPago;
            pago.MetodoPago = metodoPago;
            pago.Estado = EstadoPago.REALIZADO;

            GuardarPago(pago); 
        }
    }
}
