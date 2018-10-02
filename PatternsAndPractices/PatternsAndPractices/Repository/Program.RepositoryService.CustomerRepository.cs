using System;

namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class RepositoryService
        {
            public class CustomerRepository : IRepository<Customer>
            {
                public void Create(Customer entity)

                {

                    Console.WriteLine($"Create customer {entity.Id}");

                }

                public void Delete(Customer entity)

                {

                    Console.WriteLine($"Delete customer {entity.Id}");

                }
                public Customer GetById(long id)

                {

                    Console.WriteLine($"Find {id}");
                    return new Customer{Id = id};
                }

                public void Update(Customer entity)

                {
                    Console.WriteLine($"Update {entity.Id}");
                }

            }
        }
    }
}