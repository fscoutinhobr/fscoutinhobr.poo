using System;
using System.Collections.Generic;
using System.Linq;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Dominio;


namespace Infnet.Engesoft.SysBank.Model.Provider
{

    public class ProviderTransacoesBancarias : Provider<TransacoesBancarias>
    {

        public ProviderTransacoesBancarias()
        {

            var ccN  = new ContaCorrenteNormal();
            ccN.Numero = "123";
            var ccE  = new ContaCorrenteEspecial();
            ccE.Numero = "321";
            var tra1 = new Deposito(ccN, 100);
            tra1._dataOperacao = Convert.ToDateTime("10/10/2012");
            var tra2 = new Deposito(ccE, 150);
            tra2._dataOperacao = Convert.ToDateTime("10/10/2012");
            var tra3 = new Saque(ccN, 250);
            tra3._dataOperacao = Convert.ToDateTime("10/10/2012");
            var tra4 = new Saque(ccE, 250);
            tra4._dataOperacao = Convert.ToDateTime("10/10/2012");

            _session = new List<TransacoesBancarias>();
            _session.Add(tra1);
            _session.Add(tra2);
            _session.Add(tra3);
            _session.Add(tra4);
            
        }


        public override List<TransacoesBancarias> ObterTodos()
        {
            return _session;
        }
    }
}
