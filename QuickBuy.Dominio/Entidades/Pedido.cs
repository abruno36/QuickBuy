using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// Pedido deve ter pelo menos um pedido ou muitos pedidos
        /// </summary>
        public ICollection<ItemPedido>  ItensPedido { get; set; }
    }
}
