using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Repositorios
{
    public class RepositorioDeClientes
    {
        SqlConnection connection = null;
        List<Cliente> clientes = null;

        public RepositorioDeClientes(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
