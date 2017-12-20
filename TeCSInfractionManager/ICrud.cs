using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace model
{
    interface ICrud<T>
    {
        void Create(T obj);
        T ReadById(Object id);
        List<T> ReadAll();
        void Update(T obj);
        void Delete(Object id);
        List<T> Search(Object pattern);
    }
}
