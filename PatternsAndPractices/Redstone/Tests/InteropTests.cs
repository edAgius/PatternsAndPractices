using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Interview
{
    [TestClass]
    public class InteropTests
    {
        public InteropTests()
        {
        }
        [TestMethod]
        public void All_ReturnsItems_FromDB()
        {
            //Arrange
            DbRepository<Storeable> myDbRepository = new DbRepository<Storeable>();
            
            BusinessLogicService<Storeable> myBusinessLogicService = new BusinessLogicService<Storeable>(myDbRepository);

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            myBusinessLogicService.Save((Storeable)Convert.ChangeType(storeable, typeof(Storeable)));

            var resultItems = myBusinessLogicService.All();

            Assert.IsNotNull(resultItems);
            //Assert.AreEqual(1, resultItems.Count());
        }

        [TestMethod]
        public void All_ReturnsItems_FromCache()
        {
            
            //Arrange
            CacheRepository<Storeable> myCacheRepository = new CacheRepository<Storeable>(new List<Storeable>());
            BusinessLogicService<Storeable> myBusinessLogicService = new BusinessLogicService<Storeable>(myCacheRepository);

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            myBusinessLogicService.Save((Storeable)Convert.ChangeType(storeable, typeof(Storeable)));

            var resultItems = myBusinessLogicService.All();

            Assert.IsNotNull(resultItems);
            //Assert.AreEqual(1, resultItems.Count());
        }
    }
}
    
