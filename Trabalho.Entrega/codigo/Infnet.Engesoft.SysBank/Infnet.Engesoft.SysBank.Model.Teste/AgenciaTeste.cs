using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Infnet.Engesoft.SysBank.Model;

namespace Infnet.Engesoft.SysBank.Model.Teste
{
    [TestFixture]
    class AgenciaTeste
    {
        Agencia agencia = new Agencia();

        [Test]
        public void Test_Nome()
        {
            string expected = @"Largo Riachuelo"; //string.Empty;
            agencia.Nome = expected;
            //actual = string.Empty;
            var actual = agencia.Nome;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Numero()
        {
            string expected = "1591-0";
            agencia.Numero = expected;
            var actual = agencia.Numero;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CodigoBanco()
        {
            int expected = 237;
            agencia.CodigoBanco = expected;
            var actual = agencia.CodigoBanco;
            Assert.AreEqual(expected, actual);
        }

        //public string Nome     { get; set; }
        //public string Numero   { get; set; }
        //public int CodigoBanco { get; set; }

    }
}
