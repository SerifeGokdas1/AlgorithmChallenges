using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class FindNumberswithEvenNumbefofDigitsProblem
    {
        public static int FindNumbers(int[] nums)
        {
            int result = 0;
            string number;
            int count = 0;
            foreach (var item in nums)
            {

                number = item.ToString();
                count = number.Length;
                if (count % 2 == 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
