using System;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public abstract class TransacoesBancarias
    {
        protected int _numero { get; set; }
        public ContaCorrente _conta { get; set; }
        public DateTime _dataOperacao { get; set; }
        protected decimal _valor { get; set; }

        //public abstract void Executar();
        public abstract String GerarComprovante();
    }
}
