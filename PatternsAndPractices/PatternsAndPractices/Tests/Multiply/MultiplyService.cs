using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsAndPractices.Tests.Multiply
{
    public class MultiplyService
    {
        public MultiplyService()
        {
            Calculate(2, 2);
            Calculate(-2, -2);
            Calculate(-2, 2);
            Calculate(2, -2);
        }

        public void Calculate(int a, int b)
        {
            var result = Multiply(a, b);

            Console.WriteLine($"{a}x{b} = {result}, Should be {a*b}");
        }
        
        public int Multiply(int a, int b)
        {
            var result = 0;
            if (!BothPositiveSignum(a,b))
            {
                var BothNagative = BothNegativeSignum(a, b);
                if (BothNagative)
                {
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                    result = CalculateMultiplyLoop(a, b);
                }
                else
                {
                    if (IsNegativeSignum(a))
                    {
                        a = Math.Abs(a);
                        var res = CalculateMultiplyLoop(a, b);
                        result = -Math.Abs(res);
                    }
                    else
                    {
                        b = Math.Abs(b);
                        var res = CalculateMultiplyLoop(a, b);
                        result = -Math.Abs(res);
                    }
                }
            }
            else
            {
                return CalculateMultiplyLoop(a, b);
            }

            return result;
        }

        private int CalculateMultiplyLoop(int a, int b)
        {
            var largest = GetLargest(a, b);
            var smallest = GetSmallest(a, b);
            var result = 0;
            for (int i = 0; i < smallest; i++)
            {
                result = result + largest;
            }

            return result;
        }

        private int GetSmallest(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return b;
        }


        private int GetLargest(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        private bool BothPositiveSignum(int a, int b)
        {
            if (a > 0 && b > 0)
            {
                return true;
            }

            return false;
        }

        private bool BothNegativeSignum(int a, int b)
        {
            if (a < 0 && b < 0)
            {
                return true;
            }

            return false;
        }

        private bool IsNegativeSignum(int x)
        {
            if (x < 0)
            {
                return true;
            }

            return false;
        }

    }
}
