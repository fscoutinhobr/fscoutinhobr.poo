using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.EngSoft.SistemaBancario.Modelo
{
    // diretiva internal: somente visivel p\ outras classs no assemblies (dll)
    // protected: só é visivel numa relação de confiança, herança
    public abstract class Cliente
    {
        public string nome { get; set; }
        public List<Endereco> Enderecos { get; set; }
        public List<Telefone> Telefones { get; set; }
    }
}
