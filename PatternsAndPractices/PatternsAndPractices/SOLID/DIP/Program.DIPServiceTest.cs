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
            var loggerMock = new Mock<ILogger>();
            Mock<IStorage> storageMock = new Mock<IStorage>();
            Mock<ICombiner> combinerMock = new Mock<ICombiner>();

            loggerMock.Setup(m => m.log(It.IsAny<string>()));
            combinerMock.Setup(s => s.Combine(It.IsAny<string>(), It.IsAny<string>())).Returns("FakeString");
            WorkService workService = new WorkService(loggerMock.Object, new Storage(), new Combiner());
            workService.DoWork("ED");

            loggerMock.Verify(x=>x.log(It.IsAny<string>()),Times.Exactly(3));

        }
    }
}
