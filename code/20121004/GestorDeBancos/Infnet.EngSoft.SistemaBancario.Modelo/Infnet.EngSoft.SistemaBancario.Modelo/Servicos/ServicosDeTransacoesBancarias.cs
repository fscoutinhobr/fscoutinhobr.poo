using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class ServicosDeTransacoesBancarias
    {
        // método para realizar Deposito Bancario
        public decimal DepositoBancario(ContaCorrente conta, Decimal Valor)
        {
            return Valor;
        }

        // méodo para realizar Saque
        public decimal SaqueBancario(ContaCorrente conta, Decimal Valor)
        {
            return Valor;
        }

        // método para realizar Transferência Bancária
        public decimal TransferenciaBancaria(ContaCorrente conta, Decimal Valor)
        {
            return Valor;
        }

        // método para Emissão de Comprovante
        public bool EmissaoDeComprovante(ContaCorrente conta, DateTime DataAtual)
        {
            return true;
        }

        // método para Encerrar Conta Corrente
        public bool EncerrarContaCorrente(ContaCorrente conta)
        {
            return true;
        }
    }
}
