using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    public class ServicoDepositoTeste
    {
        [Test]
        public void TesteDepositoContaNormal()
        {
            var ccN = new ContaCorrenteNormal();
            ccN.Saldo = 850.00m;

            var deposito = new DepositoService(ccN, 150);
            deposito.Executar();

            var expected = 1000.00m;
            var actual = ccN.Saldo;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void TesteDepositoContaExpecial()
        {
            var ccN = new ContaCorrenteEspecial();
            ccN.Saldo = 750.00m;

            var deposito = new DepositoService(ccN, 500);
            deposito.Executar();

            var expected = 1250.00m;
            var actual = ccN.Saldo;

            Assert.AreEqual(expected, actual);
        }

    }
}
