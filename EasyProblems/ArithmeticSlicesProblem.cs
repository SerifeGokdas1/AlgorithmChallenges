using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class ArithmeticSlicesProblem
    {

        //An integer array is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.
        //For example, [1,3,5,7,9], [7,7,7,7], and [3,-1,-5,-9] are arithmetic sequences.
        //Given an integer array nums, return the number of arithmetic subarrays of nums.
        //A subarray is a contiguous subsequence of the array.
        public static int NumberOfArithmeticSlices(int[] nums)
        {
            int count = 0;
            int n = nums.Length;

            if (n < 3) return 0;

            int length = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if (nums[i] - nums[i - 1] == nums[i + 1] - nums[i])
                {
                    length++;
                    count += length;
                }
                else
                {
                    length = 0;
                }
            }

            return count;
        }
    }
}
