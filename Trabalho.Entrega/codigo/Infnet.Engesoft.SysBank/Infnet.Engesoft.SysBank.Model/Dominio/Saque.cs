using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class Saque : TransacoesBancarias
    {

        public Saque(ContaCorrente conta, decimal valor)
        {
            _dataOperacao = DateTime.Now;
            _conta = conta;
            _valor = valor;
        }

        //public override void Executar()
        //{
        //    throw new NotImplementedException();            
        //}

        public override string GerarComprovante()
        {
            throw new NotImplementedException();
        }

    }
}
