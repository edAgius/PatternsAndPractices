namespace Interview
{
    using System;
    using System.Collections.Generic;
    public class BusinessLogicService<T> : IBusinessLogicService<T> where T : Storeable
    {
        private readonly IRepository<T> repoService;

        public BusinessLogicService(IRepository<T> repoService)
        {
            this.repoService = repoService;
        }

        public void Save(T item)
        {
            this.repoService.Save(item);
        }

        public IEnumerable<T> All()
        {
            return this.repoService.All();
        }

        public void Delete(IComparable id)
        {
            this.repoService.Delete(id);
        }

        public T FindById(IComparable id)
        {
            return this.repoService.FindById(id);
        }
    }
}