using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using static PatternsAndPractices.Program.DIPService;

namespace PatternsAndPractices.DIP
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void TestDIP()
        {
            Mock<ILogger>loggerMock = new Mock<ILogger>();
            Mock<IStorage> storageMock = new Mock<IStorage>();
            Mock<ICombiner> combinerMock = new Mock<ICombiner>();

            loggerMock.Setup(m => m.log(It.IsAny<string>()));
            combinerMock.Setup(s => s.Combine(It.IsAny<string>(), It.IsAny<string>())).Returns("FakeString");
            PatternsAndPractices.Program.DIPService.WorkService workService = new PatternsAndPractices.Program.DIPService.WorkService(new PatternsAndPractices.Program.DIPService.Logger(), new PatternsAndPractices.Program.DIPService.Storage(), new PatternsAndPractices.Program.DIPService.Combiner());
            workService.DoWork("ED");

            var outPut = Console.ReadLine();
            Assert.IsTrue(outPut.Contains("FakeString"));

        }
    }
}
