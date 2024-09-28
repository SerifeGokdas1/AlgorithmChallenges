using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public  class MergeSortedArrayProblem
    {
        //You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] result = new int[m + n];

            for (int i = 0; i < m; i++)
            {
                result[i] = nums1[i];
            }

            for (int j = 0; j < n; j++)
            {
                result[m + j] = nums2[j];
            }

            Array.Sort(result);

            //for (int k = 0; k < result.Length; k++)
            //{
            //    nums1[k] = result[k];
            //}
            return result;
        }
    }
}
