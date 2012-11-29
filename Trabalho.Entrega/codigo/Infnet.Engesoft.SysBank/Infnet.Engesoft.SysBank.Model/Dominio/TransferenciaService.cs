using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class TransferenciaService
    {
        private ContaCorrente _contaSaque;
        private ContaCorrente _contaDeposito;
        private decimal _valor;

        public TransferenciaService(ContaCorrente contaSaque, ContaCorrente contaDeposito, decimal valor)
        {
            _contaSaque    = contaSaque;
            _contaDeposito = contaDeposito;
            _valor         = valor;
        }

        public void Executar()
        {

            if ((_contaSaque.Saldo >= _valor) && 
                (_contaSaque.Situacao != ContaCorrenteEstado.Bloqueada) &&
                (_contaDeposito.Situacao != ContaCorrenteEstado.Bloqueada))
            {
                var repositorioDeTransacoesBancarias = new TransacoesBancariasRepository();

                Saque saque = new Saque(_contaSaque, _valor);
                
                _contaSaque.Debitar(_valor);

                Deposito deposito = new Deposito(_contaDeposito, _valor);

                repositorioDeTransacoesBancarias.Gravar(saque);

                repositorioDeTransacoesBancarias.Gravar(deposito);
                _contaDeposito.Creditar(_valor);

            }
            else
            {
                if ( _contaSaque.Saldo <= 0 )
                     throw new Exception("Saldo insuficiente para a transferência");
                if ( _contaSaque.Situacao == ContaCorrenteEstado.Bloqueada )
                     throw new Exception("Conta Corrente bloqueada judicialmente, transferência não será possível");
                if ( _contaDeposito.Situacao == ContaCorrenteEstado.Bloqueada )
                     throw new Exception("Conta do favorecido bloqueada judicialmente, transferência não será possível");
            }

        }
    }
}
