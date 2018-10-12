namespace Interview
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DbRepository<T> : IRepository<T>, IDbRepository<T> where T : Storeable
    {
        private readonly DbContext context;
        public DbRepository()
        {
            context = new DbContext();
        }

        public IEnumerable<T> All()
        { 
            var results = this.GetAllFromDB();
            
            List<T> listResults = results.ToList<T>();
            return listResults;
        }

        public void Delete(IComparable id)
        {
            this.DeleteFromDb(id);
        }

        public void DeleteAll()
        {
            this.DeleteAllFromDb();
        }

        public void Save(T item)
        {
            //if overwriting is not desired the following line could be removed
            //this.cache.RemoveAll(IdsAreEqual(item.Id));
            this.SaveToDB(item);
        }
        
        public T FindById(IComparable id)
        {
            var idInt = Convert.ToInt64(id);
            var query = from items in this.context.Items
                        where items.StoreKey == idInt
                        orderby items.StoreId
                        select items;

            var item = (T)Convert.ChangeType(query.FirstOrDefault(), typeof(T));

            return item;
            
        }
       
        private Predicate<T> IdsAreEqual(IComparable id)
        {
            return x => x.Id.Equals(id);
        }

        private void SaveToDB(T item)
        {
            var query = from items in this.context.Items
                        where items.StoreKey == item.StoreKey
                        orderby items.StoreId
                        select items;

            if (query.Count() > 0)
            {
                this.context.Items.Remove(query.FirstOrDefault());
            }
            var itemToStore = item as Storeable;
            this.context.Items.Add(itemToStore);
            this.context.SaveChanges();

            
        }

        private IEnumerable<T> GetAllFromDB()
        {
            var query = from items in this.context.Items
                        orderby items.StoreId
                        select items;

            return query as IEnumerable<T>;
        }

        private void DeleteFromDb(IComparable id)
        {
            var query = from items in this.context.Items
                        orderby items.StoreId
                        select items;

            foreach (var result in query)
            {
                if (result.StoreKey == Convert.ToInt64(id))
                {
                    this.context.Items.Remove(result);
                }
            }
            this.context.SaveChanges();
        }

        private void DeleteAllFromDb()
        {
            var query = from items in this.context.Items
                        orderby items.StoreId
                        select items;

            foreach (var result in query)
            {
               
                    this.context.Items.Remove(result);
            }
            this.context.SaveChanges();
        }
    }
}

