using ClinicaSePriseApp.Datos;
using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Servicios
{
    public class PedidoInsumoService
    {
        // INYECCION
        private static PedidoInsumoRepository pedidoRepo = new PedidoInsumoRepository();

        // CREATE
        public static void CrearPedidoInsumo(E_PedidoInsumo pedido)
        {
            pedidoRepo.GuardarPedidoInsumo(pedido);
        }

        // READ
        public static List<E_PedidoInsumo> ObtenerPedidosInsumos()
        {
            return pedidoRepo.ObtenerPedidosInsumos();
        }

        public static E_PedidoInsumo? ObtenerPedidoInsumoPorId(int idPedidoInsumo)
        {
            return pedidoRepo.ObtenerPedidoInsumoPorId(idPedidoInsumo);
        }
    }
}
