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
        public int ThirdMax(int[] nums)
        {
            int firstMaximum = int.MinValue;
            int secondMaximum = int.MinValue;
            int thirdMaximum = int.MinValue;
            bool thirdNumberFound = false;

            foreach (var item in nums)
            {

                if (item == firstMaximum || item == secondMaximum || item == thirdMaximum)
                {
                    continue;
                }

                if (item > firstMaximum)
                {
                    thirdMaximum = secondMaximum;
                    secondMaximum = firstMaximum;
                    firstMaximum = item;
                }
                else if (item > secondMaximum)
                {
                    thirdMaximum = secondMaximum;
                    secondMaximum = item;
                }
                else if (item > thirdMaximum)
                {
                    thirdMaximum = item;
                    thirdNumberFound = true;
                }
            }


            if (thirdNumberFound)
            {
                return thirdMaximum;
            }

            return firstMaximum;

        }
    }
}
