using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class DuplicateZerosProblem
    {

        //Given a fixed-length integer array arr, duplicate each occurrence of zero, shifting the remaining elements to the right.
        public static int[] DuplicateZeros(int[] arr)
        {
            List<int> newList = new List<int>();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    newList.Add(arr[i]);
                    count++;

                }
                else if (arr[i] == 0)
                {
                    newList.Add(0); count++;
                    newList.Add(0); count++;
                }

            }
            int[] result = new int[count];
            for (int y = 0; y < count; y++)
            {
                result[y] = newList[y];
            }

            return result;

        }
    }
}
