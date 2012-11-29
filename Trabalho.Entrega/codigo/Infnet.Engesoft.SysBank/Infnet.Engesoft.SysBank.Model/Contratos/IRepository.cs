using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Linq.Expressions;

namespace Infnet.Engesoft.SysBank.Model.Contratos
{
    public interface IRepository<T>
    {
        IList<T> ObterTodos();
        //void Add(T item);
        //void Delete(T item);
        //T GetById(int id);
    }

}
