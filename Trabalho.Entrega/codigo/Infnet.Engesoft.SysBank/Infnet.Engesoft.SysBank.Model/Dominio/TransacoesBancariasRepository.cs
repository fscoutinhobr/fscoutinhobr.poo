using System.Collections.Generic;
using System.Linq;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Provider;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class TransacoesBancariasRepository : IRepository<TransacoesBancarias>
    {

        private List<TransacoesBancarias> _operacoes;

        public TransacoesBancariasRepository()
        {
            var tb = new ProviderTransacoesBancarias();
            _operacoes = tb.ObterTodos();
        }

        public IList<TransacoesBancarias> ObterTodos()
        {
            return _operacoes;
        }

        public List<TransacoesBancarias> ObterListaPorMes(ContaCorrente conta, int mes, int ano)
        {
            return _operacoes.Where(operacao => (operacao._dataOperacao.Month == mes) && (operacao._dataOperacao.Year == ano) && (operacao._conta.Numero == conta.Numero)).ToList();
        }

        public List<TransacoesBancarias> ObterListaPorContaCorrente(ContaCorrente conta)
        {
            //List<TransacoesBancarias> listaOperacoes = new List<TransacoesBancarias>();
            //foreach (TransacoesBancarias operacao in _operacoes)
            //{
            //    if (operacao._conta.Numero == conta.Numero)
            //    {
            //        listaOperacoes.Add(operacao);
            //    }
            //}
            //return listaOperacoes;

            return _operacoes.Where(operacao => operacao._conta.Numero == conta.Numero).ToList();
        }

        public void Gravar(TransacoesBancarias operacao)
        {
            _operacoes.Add(operacao);
        }

    }
}
