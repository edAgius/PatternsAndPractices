namespace Interview
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public partial class CacheRepository<T> : IRepository<T> where T : Storeable
    {
        private List<T> cache;

        public CacheRepository(List<T> cache)
        {
            this.cache = cache;
        }

        public IEnumerable<T> All()
        {
            return this.cache;
        }

        public void Delete(IComparable id)
        {
            this.cache.RemoveAll(this.IdsAreEqual(id));
        }

        public void Save(T item)
        {
            // if overwriting is not desired the following line could be removed
            this.cache.RemoveAll(this.IdsAreEqual(item.Id));
            this.cache.Add(item);
        }

        public T FindById(IComparable id)
        {
            return this.cache.Find(this.IdsAreEqual(id));
        }

        private Predicate<T> IdsAreEqual(IComparable id)
        {
            return x => x.Id.Equals(id);
        }
    }
}
