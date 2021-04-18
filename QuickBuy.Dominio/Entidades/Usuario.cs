using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o email")]
        [StringLength(50)]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "O email não possui um formato correto")]
        public string Email{ get; set; }

        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        public bool EhAdministrador { get; set; }

        /// <summary>
        /// Um usuário pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Senha não foi informado");
        }
    }
}
