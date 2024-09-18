using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class ThirdMaximumNumberProblem
    {

        //Given an integer array nums, return the third distinct maximum number in this array.
        //If the third maximum does not exist, return the maximum number.
        public static int ThirdMax(int[] nums)
        {
            HashSet<int> distinctNumbers = new HashSet<int>(nums);

            List<int> sortedNumbers = distinctNumbers.OrderByDescending(x => x).ToList();

            if (sortedNumbers.Count >= 3)
            {
                return sortedNumbers[2]; 
            }

            return sortedNumbers[0];

        }
    }
}
