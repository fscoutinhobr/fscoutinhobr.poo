using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class OrdemJudicial
    {
        public string _numeroOrdem { get; set; }
        public DateTime _data { get; set; }
        public ContaCorrente _conta { get; set; }

        public OrdemJudicial(ContaCorrente conta, string numeroOrdem)
        {
            _numeroOrdem = numeroOrdem;
            _data = DateTime.Now;
            _conta = conta;
        }
    }
}