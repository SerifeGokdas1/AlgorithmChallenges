using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class NumberofStepstoReduceaNumbertoZeroProblem
    {
        public static int NumberOfSteps(int num)
        {
            int result = 0;
            while (true)
            {
                if (num != 0)
                {
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                        result++;
                    }
                    else
                    {
                        num -= 1;
                        result++;
                    }
                }
                else
                {
                    break;
                }
            }
            return result;
        }
    }
}
