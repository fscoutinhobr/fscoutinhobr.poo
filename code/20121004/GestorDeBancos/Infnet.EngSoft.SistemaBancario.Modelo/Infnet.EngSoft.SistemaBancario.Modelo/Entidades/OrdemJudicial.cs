using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class OrdemJudicial
    {
        public string ContaCorrente { set; get; }
        
        // método para bloquear conta corrente
        public bool BloquearContaCorrente()
        {
            return true;
        }

        // método para desbloquear conta corrente
        public bool DesbloquearContaCorrente()
        {
            return true;
        }
    }
}
