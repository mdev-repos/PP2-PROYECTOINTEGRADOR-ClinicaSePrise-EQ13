using ClinicaSePriseApp.Entidades;
using ClinicaSePriseApp.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Datos
{
    public class PedidoInsumoRepository
    {
        // CREATE
        public void GuardarPedidoInsumo(E_PedidoInsumo pedido)
        {
            DDBB_Simulation.PedidosInsumos.Add(pedido);
        }


        // READ
        public List<E_PedidoInsumo> ObtenerPedidosInsumos()
        {
            return DDBB_Simulation.PedidosInsumos;
        }

        public E_PedidoInsumo? ObtenerPedidoInsumoPorId(int idPedido)
        {
            return DDBB_Simulation.PedidosInsumos.FirstOrDefault(i => i.IdPedido == idPedido);
        }

        // DELETE
        public void EliminarPedidoInsumo(E_PedidoInsumo pedido)
        {
            DDBB_Simulation.PedidosInsumos.Remove(pedido);
        }
    }
}
