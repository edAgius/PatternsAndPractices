using System;
using System.Collections.Generic;

namespace Interview
{
    public interface IDbRepository<T> : IRepository<T> where T : Storeable
    {
        void DeleteAll();
    }
}