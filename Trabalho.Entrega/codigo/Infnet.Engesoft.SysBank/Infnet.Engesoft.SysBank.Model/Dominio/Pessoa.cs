using Infnet.Engesoft.SysBank.Model.Contratos;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public abstract class Pessoa
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public IEndereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public TipoEstadoCliente EstadoCliente { get; set; }
    }
}
