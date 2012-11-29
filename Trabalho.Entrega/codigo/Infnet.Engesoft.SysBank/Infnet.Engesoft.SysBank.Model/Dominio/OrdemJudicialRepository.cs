using System;
using System.Collections.Generic;
using System.Linq;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Provider;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class OrdemJudicialRepository : IRepository<OrdemJudicial>
    {
        private List<OrdemJudicial> _ordens;

        public OrdemJudicialRepository()
        {

            var oj = new ProviderOrdemJudicial();
            _ordens = oj.ObterTodos();
        }

        public IList<OrdemJudicial> ObterTodos()
        {
            return _ordens;
        }

        public void Gravar(OrdemJudicial ordem)
        {
            _ordens.Add(ordem);
        }

        public OrdemJudicial ObterPorNumeroContaCorrente(string numeroContaCorrente )
        {
            return _ordens.FirstOrDefault(ordemJudicial => ordemJudicial._conta.Numero == numeroContaCorrente);
        }

        public List<OrdemJudicial> ObterPorData(DateTime data)
        {
            return _ordens.Where(ordemJudicial => ordemJudicial._data == data).ToList();
        }
    }
}
