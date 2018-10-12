namespace Interview
{
    using System.Data.Entity;
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<Storeable> Items { get; set; }
    }
}
