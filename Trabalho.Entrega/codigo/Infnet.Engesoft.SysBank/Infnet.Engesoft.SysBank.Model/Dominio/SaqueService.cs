using System;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class SaqueService
    {
        private ContaCorrente _conta;
        private decimal _valor;

        public SaqueService(ContaCorrente conta, decimal valor)
        {
            _conta = conta;
            _valor = valor;
        }

        public void  Executar()
        {

            if ((_conta.Saldo > 0) && (_conta.Situacao != ContaCorrenteEstado.Bloqueada))
            {
                Sacar();
            }
            else
            {

                if (_conta.Situacao == ContaCorrenteEstado.Bloqueada)
                    throw new Exception("Conta bloqueada");

                if (_conta.GetType().Name == "ContaCorrenteEspecial") 
                {
                    if ((_conta as ContaCorrenteEspecial).LimiteDeCredito >= _valor)
                        Sacar();
                    else 
                        if (_conta.Saldo <= 0)
                            throw new Exception("Saldo insuficiente");

                } 
                else
                {
                    if (_conta.Saldo <= 0)
                        throw new Exception("Saldo insuficiente");
                }
            }
        }

        private void Sacar()
        {

            var repositoryTransacoesBancarias = new TransacoesBancariasRepository();

            var saque = new Saque(_conta, _valor);

            repositoryTransacoesBancarias.Gravar(saque);

            _conta.Debitar(_valor);
            
        }
    }
}
