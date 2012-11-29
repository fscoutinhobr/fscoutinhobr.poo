using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model
{
    public class ContaCorrenteEspecial : ContaCorrente
    {
        public decimal LimiteDeCredito { get; set; }
    }
}
