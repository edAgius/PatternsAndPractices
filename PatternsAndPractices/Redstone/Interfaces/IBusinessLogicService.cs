using System;
using System.Collections.Generic;

namespace Interview
{
    public interface IBusinessLogicService<T> where T : Storeable
    {
        IEnumerable<T> All();

        void Delete(IComparable id);

        void Save(T item);

        T FindById(IComparable id);
    }
}