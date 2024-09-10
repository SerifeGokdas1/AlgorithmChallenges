using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class RichestCustomerWealthProblem
    {
        //Problem
        //You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
        //A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.

        public static int MaximumWealth(int[][] accounts)
        {
            int wealth = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                int money = 0;
                for (int y = 0; y < accounts[i].Length; y++)
                {
                    money += +accounts[i][y];
                }
                wealth = (wealth < money) ? money : wealth;
            }
            return wealth;
        }
    }
}
