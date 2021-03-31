using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
