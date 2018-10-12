using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Tests
{
    [TestClass]
    public class Interop<T> where T : Storeable
    {
        [TestMethod]
        public void All_ReturnsItems_FromDB()
        {
            //Arrange
            DbRepository<T> myDbRepository = new DbRepository<T>();

            BusinessLogicService<T> myBusinessLogicService = new BusinessLogicService<T>(myDbRepository);

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            myBusinessLogicService.Save((T)Convert.ChangeType(storeable, typeof(T)));

            var resultItems = myBusinessLogicService.All();

            Assert.IsNotNull(resultItems);
            //Assert.AreEqual(1, resultItems.Count());
        }

        [TestMethod]
        public void All_ReturnsItems_FromCache()
        {

            //Arrange
            CacheRepository<T> myCacheRepository = new CacheRepository<T>(new List<T>());
            BusinessLogicService<T> myBusinessLogicService = new BusinessLogicService<T>(myCacheRepository);

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            myBusinessLogicService.Save((T)Convert.ChangeType(storeable, typeof(T)));

            var resultItems = myBusinessLogicService.All();

            Assert.IsNotNull(resultItems);
            //Assert.AreEqual(1, resultItems.Count());
        }
    }
}
