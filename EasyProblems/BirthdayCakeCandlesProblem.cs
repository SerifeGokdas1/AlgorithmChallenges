using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class BirthdayCakeCandlesProblem
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int count = candles.Count;
            int[] candleBirthday = new int[count];
            for (int i = 0; i < count; i++)
            {
                candleBirthday[i] = candles[i];
            }
            Array.Sort(candleBirthday);
            Array.Reverse(candleBirthday);
            int result = 0;
            foreach (var item in candleBirthday)
            {
                if (item == candleBirthday[0])
                {
                    result++;
                }
                else
                {
                    break;
                }
            }
            return result;

        }

    }
}
