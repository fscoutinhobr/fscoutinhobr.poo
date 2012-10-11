using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class Fisica : Cliente
    {
        public decimal Renda { set; get; }
        public int CPF { get; set; }

    }
}
