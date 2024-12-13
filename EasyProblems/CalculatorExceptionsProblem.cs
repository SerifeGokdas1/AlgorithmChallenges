using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class CalculatorExceptionsProblem
    {
        //Write a Calculator class with a single method: int power(int,int). The power method takes two integers, n and p,
        //as parameters and returns the integer result of n^p.
        //If either  or  is negative, then the method must throw an exception with the message: n and p should be non-negative.
        public int power(int n, int p)
        {
            if (p < 0 || n < 0)
            {
                throw new Exception("n and p should be non-negative");
            }

            if (p == 0)
            {
                return 1;
            }
            else
            {
                return n * power(n, p - 1);
            }
        }
    }
}
