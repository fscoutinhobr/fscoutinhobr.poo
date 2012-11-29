namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class DepositoService
    {
        private ContaCorrente _conta;
        private decimal _valor;

        public DepositoService(ContaCorrente conta, decimal valor)
        {
            _conta = conta;
            _valor = valor;
        }

        public void Executar()
        {
            var repositorioDeTransacoesBancarias = new TransacoesBancariasRepository();

            var deposito = new Deposito(_conta, _valor);

            repositorioDeTransacoesBancarias.Gravar(deposito);

            _conta.Creditar(_valor);
        }
    }
}
