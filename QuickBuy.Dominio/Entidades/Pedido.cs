using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        [Display(Name = "Pedido")]
        public int Id { get; set; }

        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        [Display(Name = "Dt prev do Pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataPrevisaoEntrega { get; set; }

        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength = 8)]
        public string CEP { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Informe o estado")]
        public string Estado { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Informe a cidade")]
        public string Cidade { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Informe endereço")]
        [Display(Name = "Endereço")]
        public string EnderecoCompleto { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Informe numero da residência")]
        [Display(Name = "Número")]
        public string EnderecoNumero { get; set; }


        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedido ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido>  ItensPedido { get; set; }
        
        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido");

            if (FormaPagamentoId == 0)
                AdicionarCritica("Crítica - Não foi informado a forma de pagamento");
        }
    }
}
