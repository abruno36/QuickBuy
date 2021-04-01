using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        [Display(Name = "Produto")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do Produto")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do Produto")]
        [Display(Name = "Descrição")]
        [StringLength(100)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preço do Produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Descrição não foi informado");

        }
    }
}
