using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class GenericsProblem
    {
        public void PrintArray<T>(T[] Array)
        {
            foreach(var item in Array) { Console.WriteLine(item); }
        }
    }
}
