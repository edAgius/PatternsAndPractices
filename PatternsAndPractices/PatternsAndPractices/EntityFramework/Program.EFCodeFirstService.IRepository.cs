using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public interface IRepository<T> where T : EntityBase
            {
                T GetById(Int64 id);

                void Create(T entity);

                void Delete(T entity);

                void Update(T entity);
            }
        }
    }
}