namespace PatternsAndPractices
{
    partial class Program
    {
        public partial class RepositoryService
        {
            public RepositoryService()
            {
                Customer  c = new Customer();
                c.Id = 10;
                
                CustomerRepository cr = new CustomerRepository();

                cr.Create(c);
                cr.Delete(c);

                Repository<Customer> r  = new Repository<Customer>(); 

                r.Create(c);
                r.Delete(c);
            }
        }
    }
}