using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    public class RepositorioContaCorrenteTeste
    {
        private ContaCorrenteRepository repositorioContaCorrente = new ContaCorrenteRepository();

        [Test]
        public void Teste_CountContas()
        {
            var contas = repositorioContaCorrente.ObterTodos();

            int expected = 2;
            int actual = contas.Count;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Teste_ObterPorNumero()
        {
            var conta = repositorioContaCorrente.ObterPorNumero("222");

            var expected = "RJInfo LTDA";
            var actual = conta.Cliente.Nome;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Teste_Gravar()
        {
            var conta = new ContaCorrenteNormal();
            conta.Numero = "333";
            conta.Cliente = new PessoaFisica();
            conta.Cliente.Nome = "Lucas da Silva";
            conta.Saldo = 1500.00m;
            conta.Situacao = ContaCorrenteEstado.Ativa;
            
            repositorioContaCorrente.Gravar(conta);

            var contas = repositorioContaCorrente.ObterTodos();

            Assert.True(contas.Contains(conta));

        }

    }
}
