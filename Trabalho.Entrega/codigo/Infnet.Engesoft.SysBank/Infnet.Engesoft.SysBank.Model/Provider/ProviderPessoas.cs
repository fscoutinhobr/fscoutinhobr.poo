using System.Collections.Generic;
using Infnet.Engesoft.SysBank.Model.Dominio;
using Infnet.Engesoft.SysBank.Model.Contratos;

namespace Infnet.Engesoft.SysBank.Model.Provider
{
    public class ProviderPessoas : Provider<Pessoa>
    {
        public ProviderPessoas()  //constructor
        {
            var pessoa1 = new PessoaFisica();
            pessoa1.id = 1;
            pessoa1.Nome = @"Paulo da Silva";
            pessoa1.Renda = 2100.56m;
            pessoa1.Cpf = "111.111.111-11";
            pessoa1.Endereco = new Endereco();
            pessoa1.Telefone = new Telefone();
            pessoa1.Telefone.Ddd = "021";
            pessoa1.Telefone.Numero = "8807-7657";
            pessoa1.Telefone.TipoTelefone = TipoTelefone.Celular;
            pessoa1.EstadoCliente = TipoEstadoCliente.Ativo;


            var pessoa2 = new PessoaFisica();
            pessoa2.id = 2;
            pessoa2.Nome = @"Joel da Silva";
            pessoa2.Renda = 5340.00m;
            pessoa2.Cpf = "222.222.222-22";
            pessoa2.Endereco = new Endereco();
            pessoa2.Telefone = new Telefone();
            pessoa2.Telefone.Ddd = "032";
            pessoa2.Telefone.Numero = "3234-1254";
            pessoa2.Telefone.TipoTelefone = TipoTelefone.Residencial;
            pessoa2.EstadoCliente = TipoEstadoCliente.Ativo;


            var pessoa3 = new PessoaJuridica();
            pessoa3.id = 3;
            pessoa3.Nome = @"RJInfo LTDA";
            pessoa3.Receita = 10000000.00m;
            pessoa3.Cnpj = "10.101.010\0001-01";
            pessoa3.Endereco = new Endereco();
            pessoa3.Telefone = new Telefone();
            pessoa3.Telefone.Ddd = "041";
            pessoa3.Telefone.Numero = "232-4323";
            pessoa3.Telefone.TipoTelefone = TipoTelefone.Comercial;
            pessoa3.EstadoCliente = TipoEstadoCliente.Ativo;


            var pessoa4 = new PessoaJuridica();
            pessoa4.id = 4;
            pessoa4.Nome = @"RI Assistência Técnica";
            pessoa4.Receita = 250000000.00m;
            pessoa4.Cnpj = "20.202.020\0002-02";
            pessoa4.Endereco = new Endereco();
            pessoa4.Telefone = new Telefone();
            pessoa4.Telefone.Ddd = "021";
            pessoa4.Telefone.Numero = "0234-9876";
            pessoa4.Telefone.TipoTelefone = TipoTelefone.Comercial;
            pessoa4.EstadoCliente = TipoEstadoCliente.Ativo;


            var pessoa5 = new PessoaFisica();
            pessoa5.id = 5;
            pessoa5.Nome = @"Jose Carlos";
            pessoa5.Renda = 100.00m;
            pessoa5.Cpf = "333.333.333-33";
            pessoa5.Endereco = new Endereco();
            pessoa5.Telefone = new Telefone();
            pessoa5.Telefone.Ddd = "021";
            pessoa5.Telefone.Numero = "9987-0987";
            pessoa5.Telefone.TipoTelefone = TipoTelefone.Celular;
            pessoa5.EstadoCliente = TipoEstadoCliente.Potencial;

            _session = new List<Pessoa>();
            _session.Add(pessoa1);
            _session.Add(pessoa2);
            _session.Add(pessoa3);
            _session.Add(pessoa4);
            _session.Add(pessoa5);
        }

        public override List<Pessoa> ObterTodos()
        {
            return _session;
        }
    }
}
