using System;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class ContaCorrenteBloqueioService
    {
        private ContaCorrente _conta { get; set; }
        private OrdemJudicial _ordem;

        public ContaCorrenteBloqueioService(ContaCorrente conta, string numeroOrdem)
        {

            _conta = conta;

            _ordem = new OrdemJudicial(_conta, numeroOrdem);

        }

        public void Executar()
        {

            var repositorioOrdemJudicial = new OrdemJudicialRepository();

            repositorioOrdemJudicial.Gravar(_ordem);

            _conta.Bloquear(_ordem._numeroOrdem);

        }
    }
}
