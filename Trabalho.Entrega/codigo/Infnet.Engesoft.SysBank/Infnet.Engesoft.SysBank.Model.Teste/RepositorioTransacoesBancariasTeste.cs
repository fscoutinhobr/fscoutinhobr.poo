using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class RepositorioTransacoesBancariasTeste
    {
        private TransacoesBancariasRepository RepositorioOperacoes = new  TransacoesBancariasRepository();

        [Test]
        public void Teste_CountOperacoes()
        {
            var operacoes = RepositorioOperacoes.ObterTodos();

            var expected = 4;
            var actual = operacoes.Count;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Teste_Gravar()
        {
            var ccE = new ContaCorrenteEspecial();
            var tra1 = new Deposito(ccE, 100);

            RepositorioOperacoes.Gravar(tra1);

            var operacoes = RepositorioOperacoes.ObterTodos();

            var expected = 5;
            var actual = operacoes.Count;

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Teste_ObterPorMes()
        {
            var ccN  = new ContaCorrenteNormal();
            ccN.Numero = "123";

            var ordem = RepositorioOperacoes.ObterListaPorMes(ccN, 10, 2012);

            var expected = 2;
            var actual = ordem.Count;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Teste_ObterPorContaCorrente()
        {

            var ccN = new ContaCorrenteNormal();
            ccN.Numero = "321";

            var ordem = RepositorioOperacoes.ObterListaPorContaCorrente(ccN);

            var expected = 2;
            var actual = ordem.Count;
            Assert.AreEqual(expected, actual);
            
        }
    }
}
