using System.Collections.Generic;
using System.Linq;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Provider;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class ContaCorrenteRepository : IRepository<ContaCorrente>
    {

        List<ContaCorrente> contas;

        public ContaCorrenteRepository()
        {
            var providerCC = new ProviderContaCorrente();
            contas = providerCC.ObterTodos();
        }

        public IList<ContaCorrente> ObterTodos()
        {
            return contas;
        }

        public ContaCorrente ObterPorNumero(string Numero)
        {
            return contas.FirstOrDefault(conta => conta.Numero == Numero);
        }

        public void Gravar(ContaCorrente conta)
        {
            contas.Add(conta);
        }

    }
}
