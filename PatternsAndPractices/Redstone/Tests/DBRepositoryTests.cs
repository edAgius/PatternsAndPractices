namespace Interview
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DBRepositoryTests
    {
        private IDbRepository<Storeable> repo;
        private Storeable item1;
        private Storeable item2;
        private Storeable resultItem;
        private IEnumerable<Storeable> resultItems;

        public DBRepositoryTests(IDbRepository<Storeable> repo)
        {
            this.repo = repo;
        }
        public DBRepositoryTests()
        {
        }

        [TestInitialize]
        public void InitialiseRepository()
        {
            CreateDBRepository();
            this.repo.DeleteAll();
        }

        [TestCleanup]
        private void TearDown()
        {

            this.repo.DeleteAll();
        }

        [TestMethod]
        public void All_ReturnsItems()
        {
            //Arrange
            this.CreateBaseCacheItems();

            //Act
            this.resultItems = this.repo.All();

            //Assert
            Assert.IsNotNull(this.resultItems);
            Assert.AreEqual(2, this.resultItems.Count());
        }

        [TestMethod]
        public void All_ReturnsNullNoException()
        {
            //Act
            this.resultItems = this.repo.All();

            //Assert
            Assert.AreEqual(0, resultItems.Count());
        }

        [TestMethod]
        public void Delete_RemovesItem()
        {
            //Arrange
            this.CreateBaseCacheItems();

            //Act
            this.repo.Delete(1);

            //Assert
            Assert.IsNull(this.repo.FindById(1));
            Assert.IsNotNull(this.repo.FindById(2));
        }

        [TestMethod]
        public void Delete_NoItemToRemove()
        {
            //Arrange
            this.CreateBaseCacheItems();

            //Act
            this.repo.Delete(3);

            //Assert
            Assert.IsNotNull(this.repo.FindById(1));
            Assert.IsNotNull(this.repo.FindById(2));
        }

        [TestMethod]
        public void Save_StoresItem()
        {
            //Arrange

            //Act
            this.SaveItem1();

            //Assert
            Assert.IsNotNull(this.repo.FindById(1));
            Assert.AreEqual(1, this.repo.All().Count());
        }

        [TestMethod]
        public void Save_Overwrites()
        {
            //Arrange
            this.SaveItem1();

            //Act
            this.SaveItem1();

            //Assert
            Assert.IsNotNull(this.repo.FindById(1));
            Assert.AreEqual(1, this.repo.All().Count());
        }

        [TestMethod]
        public void FindById_CorrectItemReturned()
        {
            //Arrange
            this.CreateBaseCacheItems();

            //Act
            this.resultItem = this.repo.FindById(2);

            //Assert
            Assert.IsNotNull(this.resultItem);
            Assert.AreEqual(2, this.resultItem.Id);
            Assert.AreEqual("item2", this.resultItem.Description);
        }

        [TestMethod]
        public void FindById_NoItemToReturn()
        {
            //Arrange
            this.CreateBaseCacheItems();

            //Act
            this.resultItem = this.repo.FindById(3);

            //Assert
            Assert.IsNull(this.resultItem);
        }


        [TestMethod]
        public void Save_ToDB()
        {
            //Act
            this.SaveItem1();

            //Assert
            Assert.IsNotNull(this.repo.FindById(1));
            Assert.AreEqual(1, this.repo.All().Count());
        }


        private void CreateDBRepository()
        {
            this.repo = new DbRepository<Storeable>();
        }
        
        private void SaveItem1()
        {
            this.item1 = new Storeable { Id = 1, Description = "item1", StoreId = 1, StoreKey = 1 };
            this.repo.Save(this.item1);
        }

        private void SaveItem2()
        {
            this.item2 = new Storeable { Id = 2, Description = "item2", StoreId = 2, StoreKey = 2 };
            this.repo.Save(this.item2);
        }

        private void CreateBaseCacheItems()
        {
            this.SaveItem1();
            this.SaveItem2();
        }
    }
}