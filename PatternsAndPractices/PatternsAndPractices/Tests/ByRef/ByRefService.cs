using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAndPractices.Tests.ByRef
{
    class ByRefService
    {
        //
        public ByRefService()
        {
            var left = 1;
            var right = 2;

            AddByReference(ref left,right);
            Console.WriteLine("AddByReference left =" + left);

            left = 1;
            right = 2;
            AddByvalue(left, right);
            Console.WriteLine("AddByvalue left =" + left);

            left = 1;
            right = 2;
            Console.WriteLine("Non ref =" + AddRefactored(left, right).ToString());
        }

        public void AddByReference(ref int left, int right)
        {
            left = left + right;

        }

        public void AddByvalue(int left, int right)
        {
            left = left + right;

        }

        public int AddRefactored(int left, int right)
        {
            var result = left + right;
            return result;
        }
    }
}
