using System;
using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class RepositorioOrdemJudicialTeste
    {
        private OrdemJudicialRepository repositorioOrdemJudicial = new OrdemJudicialRepository();

        [Test]
        public void Teste_CountOrdens()
        {
            var ordem = repositorioOrdemJudicial.ObterTodos();

            int expected = 3;
            int actual   = ordem.Count;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Teste_Gravar()
        {
            var ordem4 = new OrdemJudicial(new ContaCorrenteEspecial(), "4");

            repositorioOrdemJudicial.Gravar(ordem4);

            var ordem = repositorioOrdemJudicial.ObterTodos();

            Assert.True(ordem.Contains(ordem4));

        }


        [Test]
        public void Teste_ObterPorNumero()
        {
            var ordem = repositorioOrdemJudicial.ObterPorNumeroContaCorrente("123");

            var expected = "1";
            var actual = ordem._numeroOrdem;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Teste_ObterPorData()
        {
            var ordem = repositorioOrdemJudicial.ObterPorData(Convert.ToDateTime("10/10/2012"));

            var expected = 2;
            var actual = ordem.Count;
            Assert.AreEqual(expected, actual);

            var ordem2 = repositorioOrdemJudicial.ObterPorNumeroContaCorrente("321");
            Assert.True(ordem.Contains(ordem2));

        }

    }
}
