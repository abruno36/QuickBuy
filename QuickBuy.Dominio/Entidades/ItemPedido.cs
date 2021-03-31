using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido
    {
        public int ItemId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
