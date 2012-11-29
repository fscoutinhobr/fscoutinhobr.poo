using Infnet.Engesoft.SysBank.Model.Contratos;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class Telefone : ITelefone
    {
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; } 
    }
}
