using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ServicosContaCorrenteTeste
    {
        [Test]
        public void Teste_BloqueioContaCorrente()
        {

            var contaRepository = new ContaCorrenteRepository();
            var conta = contaRepository.ObterPorNumero("222");

            var servicoBloqueio = new ContaCorrenteBloqueioService(conta, "3352");
            servicoBloqueio.Executar();

            var expected = ContaCorrenteEstado.Bloqueada;
            var actual = conta.Situacao;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Teste_DesbloqueioContaCorrente()
        {
            var contaRepository = new ContaCorrenteRepository();
            var conta = contaRepository.ObterPorNumero("111");
            conta.Situacao = ContaCorrenteEstado.Bloqueada;

            var servicoBloqueio = new ContaCorrenteDesbloqueioService(conta, "3352");
            servicoBloqueio.Executar();

            var expected = ContaCorrenteEstado.Ativa;
            var actual = conta.Situacao;

            Assert.AreEqual(expected, actual);
        }

    }
}
