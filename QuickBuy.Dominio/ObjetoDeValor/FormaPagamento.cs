using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int FormaId { get; set; }
        public string Nome { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return FormaId == (int)TipoFormaPagamentoEnum.Boleto; } 
        }
        public bool EhCartaoCredito
        {
            get { return FormaId == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return FormaId == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool NaoFoiDefinido
        {
            get { return FormaId == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
