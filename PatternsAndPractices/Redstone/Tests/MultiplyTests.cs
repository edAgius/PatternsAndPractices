using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatternsAndPractices.Tests.Multiply;

namespace Interview.Tests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void CheckSums()
        {
            MultiplyService MultiplyService = new MultiplyService();

            TestLoop(MultiplyService);
        }

        private void TestLoop( MultiplyService svc)
        {
            Random randomA = new Random();
            for (int i = 0; i < 50000; i++)
            {
                
                var a = randomA.Next(-5000, 5000);
                var b = randomA.Next(-5000, 5000);

                var result = svc.Multiply(a,b);

                var expected = a * b;
                Assert.AreEqual(expected, result);
                Console.WriteLine($"{a}x{b} = {result}, Should be {expected}");
            }

        }
    }
}
