using System;
using System.Collections.Generic;

namespace Infnet.Engesoft.SysBank.Model.Dominio
{
    public abstract class ContaCorrente
    {
        public string Numero { get; set; }
        public Pessoa Cliente  { get; set; }
        public decimal Saldo { get; set; }
        public ContaCorrenteEstado Situacao { get; set; }
        //public List<TransacoesBancarias> Operacoes { get; set; }

        public void Debitar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Creditar(decimal valor)
        {
            Saldo += valor;
        }

        public void Bloquear(string numeroOrdemBloqueio)
        {
            if (numeroOrdemBloqueio != null)
            {
                Situacao = ContaCorrenteEstado.Bloqueada;
            }
            else
            {
                throw new Exception("Conta não pode ser bloqueada sem Ordem Judicial");
            }
            
        }

        public void Desbloquear(string numeroOrdemDesbloqueio)
        {
            if (numeroOrdemDesbloqueio != null)
            {
                Situacao = ContaCorrenteEstado.Ativa;
            }
            else
            {
                throw new Exception("Conta não pode ser desbloqueada sem ordem judicial.");
            }
            
        }
    }
}