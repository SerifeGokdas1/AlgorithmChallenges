using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class TimeConversionProblem
    {
        //Complete the timeConversion function in the editor below. It should return a new string representing the input time in 24 hour format.
        //timeConversion has the following parameter(s): string s: a time in 12 hour format, 
        //Returns: string: the time in 24 hour format


        public static string timeConversion(string s)
        {
            DateTime newDate = Convert.ToDateTime(s);
            newDate.AddHours(12);
            string result = newDate.ToString("HH:mm:ss");
            return result;

        }

    }
}
