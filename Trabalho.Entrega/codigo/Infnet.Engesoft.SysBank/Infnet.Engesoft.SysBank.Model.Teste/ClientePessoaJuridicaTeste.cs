using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ClientePessoaJuridicaTeste
    {

        public PessoaJuridica Cliente = new PessoaJuridica();// TODO: Initialize to an appropriate value

        [Test]
        public void Test_Nome()
        {
            string expected = @"Paulo Vasconcelos"; //string.Empty;
            string actual;
            Cliente.Nome = expected;
            actual = Cliente.Nome;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CNPJ()
        {
            string expected = "30.097.554/0001-10";
            string actual;
            Cliente.Cnpj = expected;
            actual = Cliente.Cnpj;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Receita()
        {
            decimal expected = 10547.99m;
            decimal actual;
            Cliente.Receita = expected;
            actual = Cliente.Receita;
            Assert.AreEqual(expected, actual);
        }



    }
}
