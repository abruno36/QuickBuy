using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }
        private List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        
        }
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        public abstract void Validate();
        public bool EhValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
