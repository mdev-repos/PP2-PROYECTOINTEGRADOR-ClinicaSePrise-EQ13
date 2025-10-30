using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaSePriseApp.Entidades.Enums;


namespace ClinicaSePriseApp.Entidades
{
    public class E_Pago
    {
        public int IdPago { get; set; }
        public int IdPaciente { get; set; }
        public int IdTurno { get; set; }
        public DateOnly? FechaPago { get; set; } = null;
        public decimal Monto { get; set; }
        public EstadoPago Estado { get; set; } = EstadoPago.PENDIENTE;
        public MetodoPago? MetodoPago { get; set; }


        // CONSTRUCTOR
        public E_Pago(int idPago, int idPaciente, int idTurno, decimal monto)
        {
            IdPago = idPago;
            IdPaciente = idPaciente;
            IdTurno = idTurno;
            Monto = monto;
        }


        // Metodo PAGAR
        public void RealizarPago(int idPago, DateOnly fechaPago, MetodoPago metodoPago)
        {
            FechaPago = fechaPago;
            MetodoPago = metodoPago;
            Estado = EstadoPago.REALIZADO;

            // Agregar pago a lista de pagos del paciente
            E_Paciente? paciente = E_Paciente.ObtenerPacientePorId(this.IdPaciente);
            if (paciente != null)
            {
                paciente.PagosRealizados.Add(this);
            }            
        }
    }
}
