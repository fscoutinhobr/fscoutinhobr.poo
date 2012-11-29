using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class Deposito : TransacoesBancarias
    {
        public Deposito(ContaCorrente conta, decimal valor)
        {
            _dataOperacao = DateTime.Now;
            _conta = conta;
            _valor = valor;
        }

        public override string GerarComprovante()
        {
            return "Deposito em  " + _dataOperacao.ToShortDateString() + " no valor de R$ " + _valor.ToString();
        }
    }
}
