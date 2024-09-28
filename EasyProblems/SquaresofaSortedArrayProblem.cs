using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class SquaresofaSortedArrayProblem
    {
        //Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.

        public static int[] SortedSquares(int[] nums)
        {
            int count = nums.Length;
            List<int> numbers = new List<int>();
            int squareNumber = 0;

            foreach (var item in nums)
            {
                squareNumber = item * item;
                if (squareNumber < 0) { squareNumber = squareNumber * -1; }
                numbers.Add(squareNumber);
            }
            numbers.Sort();

            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = numbers[i];
            }
            return result;
        }
    }
}
