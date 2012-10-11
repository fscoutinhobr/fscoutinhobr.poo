using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Infnet.EngSoft.SistemaBancario.Modelo.Repositorios
{
    public class RepositorioDeTransacoesBancarias
    {
        SqlConnection connection = null;
        List<RepositorioDeTransacoesBancarias> TransacoesBancarias = null;

        public RepositorioDeTransacoesBancarias(SqlConnection connection)
        {
            this.connection = connection;
        }
    }
}
