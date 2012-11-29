using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class Endereco : IEndereco
    {
        public string TipoDeLogradouro;
        public string Logradouro;
        public int Numero;
        public string Bairro;
        public string Cidade;
        public string Uf;
        public string Cep;
        public string Complemento;
    }
}
