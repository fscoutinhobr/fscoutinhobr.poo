using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;
using Infnet.Engesoft.SysBank.Model;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    public class ContaCorrenteNormalTeste
    {
        ContaCorrenteNormal conta = new ContaCorrenteNormal();

        [Test]
        public void Test_NumeroConta()
        {
            var expected = @"23450-1";
            conta.Numero = expected;
            var actual = conta.Numero;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Cliente()
        {
            var expected = new PessoaFisica();
            conta.Cliente = expected;
            var actual = conta.Cliente;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Saldo()
        {
            var expected = 10538.00m;
            conta.Saldo = expected;
            var actual = conta.Saldo;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Situacao()
        {
            var expected = ContaCorrenteEstado.Ativa;
            conta.Situacao = expected;
            var actual = conta.Situacao;
            Assert.AreEqual(expected, actual);
        }

    }
}
