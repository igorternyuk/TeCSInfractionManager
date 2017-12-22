using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    interface ICrud<T>
    {
        bool Create(T obj);
        bool Update(T obj);
        bool Delete(Object id);
        T ReadById(Object id);
        List<T> ReadAll();
        List<T> Search(Object pattern);
    }
}
