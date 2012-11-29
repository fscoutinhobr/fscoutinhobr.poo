using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ServicoExtratoTeste
    {
        [Test]
        public void Teste_ExtratoMensal()
        {

            //var ccN = new ContaCorrenteNormal();
            //ccN.Numero = "123";

            //var ordem = RepositorioOperacoes.ObterListaPorMes(ccN, 10, 2012);

            //var expected = 2;
            //var actual = ordem.Count;
            //Assert.AreEqual(expected, actual);

            var conta = new ContaCorrenteNormal();
            conta.Numero = "123";

            var extrato = new ExtratoService();

            var itens = extrato.ObterExtratoMensal(conta, 10, 2012);

            var expected = 2;
            var actual = itens.Count;

            Assert.AreEqual(expected, actual);

        }
    }
}
