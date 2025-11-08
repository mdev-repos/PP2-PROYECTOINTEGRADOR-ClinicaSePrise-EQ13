using ClinicaSePriseApp.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePriseApp.Entidades
{
    public class E_PedidoInsumo
    {
        private static int ID_AUTOINCREMENT = 0;

        public int IdPedido { get; set; }
        public DateOnly FechaPedido { get; set; }
        public int IdProfesional { get; set; }
        public List<E_InsumoSolicitado> InsumosSolicitados { get; set; }
        public EstadoPedidoInsumo EstadoPedidoInsumo { get; set; }


        public E_PedidoInsumo(int idProfesional, List<E_InsumoSolicitado> insumosSolicitados)
        {
            ID_AUTOINCREMENT++;

            IdPedido = ID_AUTOINCREMENT;
            FechaPedido = DateOnly.FromDateTime(DateTime.Now);
            IdProfesional = idProfesional;
            InsumosSolicitados = insumosSolicitados;
            EstadoPedidoInsumo = EstadoPedidoInsumo.SOLICITADO;
        }
    }
}