using System;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{

    public class ContaCorrenteDesbloqueioService
    {

        private ContaCorrente _conta;
        private OrdemJudicial _ordemJudicial;

        public ContaCorrenteDesbloqueioService(ContaCorrente conta, string numeroOrdemJudicial)
        {

            _conta = conta;

            _ordemJudicial = new OrdemJudicial(_conta, numeroOrdemJudicial);

        }

        public void Executar()
        {
            var repositorioOrdemJudicial = new OrdemJudicialRepository();

            repositorioOrdemJudicial.Gravar(_ordemJudicial);

            _conta.Desbloquear(_ordemJudicial._numeroOrdem);
        }

    }

}