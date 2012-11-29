using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    class EnderecoTeste
    {
        private Endereco endereco = new Endereco();

        [Test]
        public void Test_TipoDeLogradouro()
        {
            string tipologradouro = @"Rua";
            endereco.TipoDeLogradouro = tipologradouro;
            Assert.AreEqual(tipologradouro, endereco.TipoDeLogradouro);
        }

        [Test]
        public void Test_Logradouro()
        {
            string logradouro = @"Rua Cosme Velho, 35";
            endereco.Logradouro = logradouro;
            //endereco.Logradouro = @"Rua Cosme";
            Assert.AreEqual(logradouro, endereco.Logradouro);
        }

        [Test]
        public void Test_Numero()
        {
            int expected = 285;
            int actual;
            endereco.Numero = expected;
            actual = endereco.Numero;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Bairro()
        {
            string expected = @"Tijuca"; //string.Empty;
            string actual;
            endereco.Bairro = expected;
            actual = endereco.Bairro;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Cidade()
        {
            string expected = @"Rio de Janeiro"; //string.Empty;
            string actual;
            endereco.Cidade = expected;
            actual = endereco.Cidade;
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_UF()
        {
            string expected = @"Rio de Janeiro"; //string.Empty;
            string actual;
            endereco.Uf = expected;
            actual = endereco.Uf;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CEP()
        {
            string expected = @"21.050-000"; //string.Empty;
            string actual;
            endereco.Cep = expected;
            actual = endereco.Cep;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Complemento()
        {
            string expected = @"APTO 1001"; //string.Empty;
            string actual;
            endereco.Complemento = expected;
            actual = endereco.Complemento;
            Assert.AreEqual(expected, actual);
        }



    }
}
