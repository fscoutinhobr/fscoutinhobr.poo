using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Infnet.Engesoft.SysBank.Model.Dominio;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public class ExtratoService
    {
      
        public List<TransacoesBancarias> ObterExtratoMensal(ContaCorrente conta, int mes, int ano)
        {
            
            var repositorioTransacoesBancarias = new TransacoesBancariasRepository();

            //se for da politica do dominio cobrar pela emissao do extrato entao 
            //devera existir uma classe extrato herdada de transacoes bancarias que
            //fara um débito na conta corrente que será emitida o extrato. Isso após recuperar os itens do extrato.

            return repositorioTransacoesBancarias.ObterListaPorMes(conta, mes, ano);

        } 
    }
}
