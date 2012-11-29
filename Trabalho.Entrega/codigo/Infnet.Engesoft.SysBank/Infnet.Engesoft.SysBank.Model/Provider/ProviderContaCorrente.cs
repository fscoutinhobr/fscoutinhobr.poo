using System.Collections.Generic;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model.Provider
{

    public class ProviderContaCorrente : Provider<ContaCorrente>
    {

        public ProviderContaCorrente()
        {
            var repositorioDePessoas = new PessoaRepository();

            var conta1 = new ContaCorrenteNormal();
            conta1.Numero = "111";
            conta1.Cliente = repositorioDePessoas.ObterPorNome("Paulo da Silva");
            conta1.Saldo = 1500.00m;
            conta1.Situacao = ContaCorrenteEstado.Ativa;


            var conta2 = new ContaCorrenteEspecial();
            conta2.Numero = "222";
            conta2.Cliente = repositorioDePessoas.ObterPorNome("RJInfo LTDA");
            conta2.Saldo = 500000.53m;
            conta2.Situacao = ContaCorrenteEstado.Ativa;


            _session = new List<ContaCorrente>();
            _session.Add(conta1);
            _session.Add(conta2);
        }


        public override List<ContaCorrente> ObterTodos()
        {
            return _session;
        }
    }    

}
