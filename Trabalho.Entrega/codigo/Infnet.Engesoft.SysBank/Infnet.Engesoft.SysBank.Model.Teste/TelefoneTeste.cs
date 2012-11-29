using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    public class TelefoneTeste
    {
        Telefone fone = new Telefone();

        [Test]
        public void Teste_DDD()
        {
            var expected = "021";
            fone.Ddd = expected;
            var actual = fone.Ddd;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Teste_Numero()
        {
            var expected = "3025-7859";
            fone.Numero = expected;
            var actual = fone.Numero;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void Teste_TipoTelefone()
        {
            var expected = TipoTelefone.Celular;
            fone.TipoTelefone = expected;
            var actual = fone.TipoTelefone;
            Assert.AreEqual(expected, actual);
        }

    }
}
