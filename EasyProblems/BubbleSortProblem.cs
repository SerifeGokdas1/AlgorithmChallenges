using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class BubbleSortProblem
    {
        public static void BubbleSort(List<int> a)
        {
            int n = a.Count;
            int numSwaps = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int swapsThisRound = 0;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        // Swap işlemi
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapsThisRound++;
                        numSwaps++;
                    }
                }

                if (swapsThisRound == 0)
                    break;
            }

            Console.WriteLine($"Array is sorted in {numSwaps} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[n - 1]}");

        }

    }
}
