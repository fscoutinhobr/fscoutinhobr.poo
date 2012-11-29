using System.Collections.Generic;
using System.Linq;
using Infnet.Engesoft.SysBank.Model.Contratos;
using Infnet.Engesoft.SysBank.Model.Provider;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private List<Pessoa> pessoas;

        public PessoaRepository()
        {
            var pes = new ProviderPessoas();
            pessoas = pes.ObterTodos();
        }

        public IList<Pessoa> ObterTodos()
        {
            return pessoas;
        }

        public Pessoa ObterPorId(int id)
        {
            return pessoas.FirstOrDefault(pessoa => pessoa.id == id);
        }

        public Pessoa ObterPorNome(string Nome)
        {
            return pessoas.FirstOrDefault(pessoa => pessoa.Nome == Nome);
        }

        public void Gravar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

    }
}
