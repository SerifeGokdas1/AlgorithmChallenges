using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public  class MigratoryBirdsProblem
    {

        public static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdsCount = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (birdsCount.ContainsKey(item))
                {
                    birdsCount[item] += 1;
                }
                else
                {
                    birdsCount.Add(item, 1);
                }

            }
            int maxValue = birdsCount.Values.Max();
            int result = birdsCount.Where(x => x.Value == maxValue).Select(x => x.Key).Min();
            return result;
        }
    }
}
