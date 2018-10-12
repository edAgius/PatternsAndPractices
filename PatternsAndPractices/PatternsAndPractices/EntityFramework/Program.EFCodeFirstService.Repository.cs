using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class EFCodeFirstService
        {
            public class Repository<T> where T : EntityBase
            {
                public void Create(T entity)

                {

                    Console.WriteLine($"Create {entity.Id}");

                }

                public void Delete(T entity)

                {

                    Console.WriteLine($"Delete {entity.Id}");

                }

                public virtual T GetById(long id)

                {

                    Console.WriteLine($"Find {id}");
                    throw new NotImplementedException();

                }

                public void Update(T entity)

                {
                    Console.WriteLine($"Update {entity.Id}");
                }

            }
        }
    }
}