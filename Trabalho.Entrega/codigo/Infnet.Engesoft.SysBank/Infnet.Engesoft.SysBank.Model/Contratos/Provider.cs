using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infnet.Engesoft.SysBank.Model.Contratos
{
    //função de interface
    public abstract class Provider<T>
    {
        //property
        protected List<T> _session;

        //method
        public abstract List<T> ObterTodos();

    }
}
