using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ClientePessoaFisicaTeste
    {
        PessoaFisica Cliente = new PessoaFisica();// TODO: Initialize to an appropriate value

        [Test]
        public void Test_Nome()
        {
            const string expected = @"Paulo Vasconcelos"; //string.Empty;
            Cliente.Nome = expected;
            //actual = string.Empty;
            var actual = Cliente.Nome;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CPF()
        {
            const string expected = "987.678.876-46";
            Cliente.Cpf = expected;
            var actual = Cliente.Cpf;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Renda()
        {
            const decimal expected = 10547.99m;
            Cliente.Renda = expected;
            var actual = Cliente.Renda;
            Assert.AreEqual(expected, actual);
        }
    }
}
