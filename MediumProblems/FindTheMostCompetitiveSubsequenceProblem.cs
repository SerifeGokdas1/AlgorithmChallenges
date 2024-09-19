using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.MediumProblems
{
    public class FindTheMostCompetitiveSubsequenceProblem
    {
        //Given an integer array nums and a positive integer k, return the most competitive subsequence of nums of size k.
        //An array's subsequence is a resulting sequence obtained by erasing some (possibly zero) elements from the array.
        //We define that a subsequence a is more competitive than a subsequence b (of the same length) if in the first position where a and b differ, subsequence a has a number less than the corresponding number in b. For example, [1,3,4] is more competitive than [1,3,5] because the first position they differ is at the final number, and 4 is less than 5.
        public static int[] MostCompetitive(int[] nums, int k)
        {
            int smallest = int.MaxValue;
            int whichIndex = -1;
            int[] result = new int[k];
            if (nums.Length > k)
            {
                for (int i = 0; i <= nums.Length - k; i++)
                {
                    if (nums[i] < smallest)
                    {
                        smallest = nums[i];
                        whichIndex = i;
                    }
                }
                int[] smallNumbers = new int[nums.Length - whichIndex - 1];
                int count = 0;
                for (int y = whichIndex + 1; y < nums.Length; y++)
                {
                    smallNumbers[count] = nums[y];
                    count++;
                }
                result[0] = nums[whichIndex];
                if (nums.Length - whichIndex == k)
                {

                    for (int z = 1; z < k; z++)
                    {
                        if (z - 1 < smallNumbers.Length)
                        {
                            result[z] = smallNumbers[z - 1];
                        }
                    }
                    return result;
                }

                Array.Sort(smallNumbers);

                for (int z = 1; z < k; z++)
                {
                    if (z - 1 < smallNumbers.Length)
                    {
                        result[z] = smallNumbers[z - 1];
                    }
                }
                return result;
            }
            else
            {
                return nums;
            }
        }
    }
}
