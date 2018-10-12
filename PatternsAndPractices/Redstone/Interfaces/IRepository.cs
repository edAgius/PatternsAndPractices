namespace Interview
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public interface IRepository<T> where T : Storeable
    {
        IEnumerable<T> All();

        void Delete(IComparable id);

        void Save(T item);

        T FindById(IComparable id);
    }
}