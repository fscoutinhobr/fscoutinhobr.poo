namespace Infnet.Engesoft.SysBank.Model.Contratos
{
    public interface ITelefone
    {
        string Ddd { get; set; }
        string Numero { get; set; }
        TipoTelefone TipoTelefone { get; set; }
    }
}
