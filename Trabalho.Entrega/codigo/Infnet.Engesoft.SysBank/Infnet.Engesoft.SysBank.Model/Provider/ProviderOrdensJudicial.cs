using System;
using System.Collections.Generic;
using Infnet.Engesoft.SysBank.Model.Dominio;
using Infnet.Engesoft.SysBank.Model.Contratos;

namespace Infnet.Engesoft.SysBank.Model.Provider
{
    public class ProviderOrdemJudicial : Provider<OrdemJudicial>
    {
        public ProviderOrdemJudicial()
        {
            var conta1 = new ContaCorrenteEspecial();
            conta1.Numero = "123";
            var ordem1 = new OrdemJudicial(conta1, "1");
            ordem1._data = Convert.ToDateTime("10/10/2012");

            var conta2 = new ContaCorrenteEspecial();
            conta2.Numero = "321";
            var ordem2 = new OrdemJudicial(conta2, "2");
            ordem2._data = Convert.ToDateTime("10/10/2012");

            var conta3 = new ContaCorrenteEspecial();
            conta3.Numero = "258";
            var ordem3 = new OrdemJudicial(conta3, "3");
            ordem3._data = Convert.ToDateTime("11/10/2012");

            _session = new List<OrdemJudicial>();
            _session.Add(ordem1);
            _session.Add(ordem2);
            _session.Add(ordem3);

        }

        public override List<OrdemJudicial> ObterTodos()
        {
            return _session;
        }
    }
}
