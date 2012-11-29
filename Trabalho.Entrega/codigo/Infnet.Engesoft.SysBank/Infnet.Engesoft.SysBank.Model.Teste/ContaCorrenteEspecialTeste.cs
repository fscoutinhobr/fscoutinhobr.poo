using Infnet.Engesoft.SysBank.Model.Dominio;
using System.Collections.Generic;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ContaCorrenteEspecialTeste
    {
        private ContaCorrenteEspecial Conta = new ContaCorrenteEspecial();

        [Test]
        public void Teste_Numero()
        {
            const string expected = "111";
            Conta.Numero = expected;
            var actual = Conta.Numero;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Teste_Saldo()
        {
            const decimal expected = 10.05m;
            Conta.Saldo = expected;
            var actual = Conta.Saldo;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Teste_Pessoa()
        {
            Pessoa expected = new PessoaFisica();
            Conta.Cliente = expected;
            var actual = Conta.Cliente;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Teste_Situacao()
        {
            var expected = ContaCorrenteEstado.Ativa;
            Conta.Situacao = expected;
            var actual = Conta.Situacao;
            Assert.AreEqual(expected, actual);
        }

    }
}
