using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Interview
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void All_ReturnsItems()
        {
            //Arrange
            var myDbRepositoryMock = new Mock<IDbRepository<Storeable>>();

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            List<Storeable> list = new List<Storeable>();
            list.Add(storeable);

            myDbRepositoryMock.Setup(x => x.All()).Returns(() => new List<Storeable>(list));
            
            BusinessLogicService<Storeable> myBusinessLogicService = new BusinessLogicService<Storeable>(myDbRepositoryMock.Object);
            var returned = myBusinessLogicService.All();

            Assert.AreEqual(1, returned.Count());
        }

        [TestMethod]
        public void FindById_ReturnsItems()
        {
            //Arrange
            var myDbRepositoryMock = new Mock<IRepository<Storeable>>();
            myDbRepositoryMock.Setup(x => x.FindById(1)).Returns(() => new Storeable { Description = "i1", Id = 1, StoreId = 1 });

            BusinessLogicService<Storeable> myBusinessLogicService = new BusinessLogicService<Storeable>(myDbRepositoryMock.Object);
            var returned = myBusinessLogicService.FindById(1);

            Assert.AreEqual(1, returned.Id);
        }


        [TestMethod]
        public void SaveCalledOnce()
        {
            //Arrange
            var myDbRepository = new Mock<IDbRepository<Storeable>>();

            var storeable = new Storeable { Description = "i1", Id = 1, StoreId = 1 };
            myDbRepository.Setup(x => x.Save(storeable)).Verifiable();
            BusinessLogicService<Storeable> myBusinessLogicService = new BusinessLogicService<Storeable>(myDbRepository.Object);


            myBusinessLogicService.Save(storeable);

            myDbRepository.Verify(x => x.Save(storeable), Times.Once());
        }

    }
}
