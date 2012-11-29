using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class ServicoTransferenciaTeste
    {

        [Test]
        public void Test_Transferencia()
        {
            var contaSaque = new ContaCorrenteNormal();
            contaSaque.Situacao = ContaCorrenteEstado.Ativa;
            contaSaque.Saldo = 750.00m;

            var contaDeposito = new ContaCorrenteNormal();
            contaDeposito.Situacao = ContaCorrenteEstado.Ativa;
            contaDeposito.Saldo = 1000.00m;


            var deposito = new TransferenciaService(contaSaque, contaDeposito, 200.00m);
            deposito.Executar();

            var expectedSaque = 550.00m;
            var actualSaque   = contaSaque.Saldo;

            var expectedDeposito = 1200.00m;
            var actualDeposito = contaDeposito.Saldo;

            Assert.AreEqual(expectedSaque, actualSaque, "Saque");
            Assert.AreEqual(expectedDeposito, actualDeposito, "Deposito");

        }

    }
}
