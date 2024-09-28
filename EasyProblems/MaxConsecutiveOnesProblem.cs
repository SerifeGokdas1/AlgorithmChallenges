using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class MaxConsecutiveOnesProblem
    {
        //Given a binary array nums, return the maximum number of consecutive 1's in the array.
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            if(nums.Length== 1 && nums[0] == 0) { return 0; }
            int count = 0;

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    result.Add(count);
                    count = 0;
                }
                if (i == (nums.Length - 1))
                {
                    result.Add(count);
                }
            }

            int max = result[0];
            foreach(var item in result)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
