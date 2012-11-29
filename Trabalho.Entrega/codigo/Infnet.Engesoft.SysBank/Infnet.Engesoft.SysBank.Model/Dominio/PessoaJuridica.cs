using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public decimal Receita { get; set; }
    }
}
