using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class RansomNoteProblem
    {
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            int count = ransomNote.Length;

            for (int i = 0; i < count; i++)
            {
                if (magazine.Contains(ransomNote[i]))
                {
                    magazine = magazine.Remove(magazine.IndexOf(ransomNote[i]), 1);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
