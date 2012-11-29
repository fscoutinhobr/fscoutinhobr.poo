using Infnet.Engesoft.SysBank.Model.Dominio;
using NUnit.Framework;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    public class ServicoSaqueTeste
    {

        [Test]
        public void Teste_Saque_atualiza_Saldo_ContaCorrenteNormal()
        {
            var conta = new ContaCorrenteNormal();
            conta.Creditar(1000);
            conta.Numero = "222";

            SaqueService ss = new SaqueService(conta, 100);
            ss.Executar();

            decimal expected = 900.00m;
            var actual = conta.Saldo;


            //testa atualização do saldo
            Assert.AreEqual(expected, actual);

        }

        [ExpectedException(typeof(System.Exception))]
        [Test]
        public void Teste_Saque_atualiza_saldo_ContaCorrenteEspecial()
        {
            var conta = new ContaCorrenteEspecial();
            conta.Situacao = ContaCorrenteEstado.Bloqueada;
            conta.Creditar(0);
            conta.LimiteDeCredito = 300;
            conta.Numero = "333";

            SaqueService ss = new SaqueService(conta, 100);
            ss.Executar();

            decimal expected = -200.00m;
            var actual = conta.Saldo;

            //testa atualização do saldo
            Assert.AreEqual(expected, actual);
        }
    }
}
