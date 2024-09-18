
#region EasyProblems

//#region RunningSum
//using AlgorithmChallenges.EasyProblems;

//int[] nums = { 1, 2, 3, 4 };
//int[] result = RunningSumProblem.RunningSum(nums);

//Console.WriteLine("Running Sum: " + string.Join(", ", result));
//#endregion

//#region RichestCustomerWealth

//using AlgorithmChallenges.EasyProblems;

//int[][] accounts = {
//    new int[] {1, 2, 3},
//    new int[] {4, 5, 6},
//    new int[] {7, 8, 9}
//        };
//int result = RichestCustomerWealthProblem.MaximumWealth(accounts);
//Console.WriteLine("Richest Customer Wealth: " + string.Join(", ", result));
//#endregion

#region  FizzBuzz
using AlgorithmChallenges.EasyProblems;

int n = 15; 
var result = FizzBuzzProblem.FizzBuzz(n);

foreach (var item in result)
{
    Console.WriteLine(item);
}
#endregion

#endregion





