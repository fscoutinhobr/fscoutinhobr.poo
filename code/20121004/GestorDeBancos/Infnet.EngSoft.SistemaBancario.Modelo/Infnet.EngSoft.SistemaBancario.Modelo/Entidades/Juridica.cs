using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    public class Juridica : Cliente
    {
        public decimal Receita { set; get; }
        public int cnpj { set; get; }
    }
}
