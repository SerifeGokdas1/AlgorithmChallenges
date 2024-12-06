






















#region EasyProblems
#region RunningSum
//using AlgorithmChallenges.EasyProblems;

//int[] nums = { 1, 2, 3, 4 };
//int[] result = RunningSumProblem.RunningSum(nums);

//Console.WriteLine("Running Sum: " + string.Join(", ", result));
#endregion
#region RichestCustomerWealth

//using AlgorithmChallenges.EasyProblems;

//int[][] accounts = {
//    new int[] {1, 2, 3},
//    new int[] {4, 5, 6},
//    new int[] {7, 8, 9}
//        };
//int result = RichestCustomerWealthProblem.MaximumWealth(accounts);
//Console.WriteLine("Richest Customer Wealth: " + string.Join(", ", result));
#endregion
#region  FizzBuzz
//using AlgorithmChallenges.EasyProblems;

//int n = 15; 
//var result = FizzBuzzProblem.FizzBuzz(n);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
#endregion
#region ArithmeticSlicesProblem
//using AlgorithmChallenges.EasyProblems;

//int[] nums = { 5, -2, -9, -16, -23, -30 };
//int result = ArithmeticSlicesProblem.NumberOfArithmeticSlices(nums);
//Console.WriteLine($"Number of arithmetic subarrays: {result}");
#endregion
#region ThirdMaximumNumber

//using AlgorithmChallenges.EasyProblems;

//int[] nums = { 3, 2, 1 };
//int result = ThirdMaximumNumberProblem.ThirdMax(nums);
//Console.WriteLine($"The third distinct maximum number is: {result}");

#endregion
#region Number of Steps to Reduce a Number to Zero
//using AlgorithmChallenges.EasyProblems;

//int num = 15;
//var result = NumberofStepstoReduceaNumbertoZeroProblem.NumberOfSteps(num);
//Console.WriteLine(result);
#endregion
#region Middle of The Linked List Problem

//using AlgorithmChallenges.EasyProblems;

//ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

//ListNode middleNode = MiddleoftheLinkedListProblem.MiddleNode(head);

//Console.Write("Orta düğüm ve sonrası: ");
//while (middleNode != null)
//{
//    Console.Write(middleNode.val + " ");
//    middleNode = middleNode.next;
//}
#endregion
#region Ransom Note
//using AlgorithmChallenges.EasyProblems;

//bool result = RansomNoteProblem.CanConstruct("ne", "deneme");
//Console.WriteLine("Result: "+result);
#endregion
#region Max Consecutive Ones
//using AlgorithmChallenges.EasyProblems;

//int[] max = new int[6] { 1, 1, 0, 1, 1, 1 };
//int result = MaxConsecutiveOnesProblem.FindMaxConsecutiveOnes(max);
//Console.WriteLine("Result: "+ result);

#endregion
#region Find Numbers with Even Number of Digits
//using AlgorithmChallenges.EasyProblems;

//int[] nums = new int[5] {12, 345, 2, 6, 7896};
//int result = FindNumberswithEvenNumbefofDigitsProblem.FindNumbers(nums);
//Console.WriteLine(result);
#endregion
#region Squares of a Sorted Array

//using AlgorithmChallenges.EasyProblems;

//int[] nums = new int[5] {-4, -1, 0, 3, 10};
//int[] result = SquaresofaSortedArrayProblem.SortedSquares(nums);
//Console.WriteLine(result);

#endregion
#region Duplicate Zeros

//using AlgorithmChallenges.EasyProblems;

//int[] nums = new int[8] {1, 0, 2, 3, 0, 4, 5, 0};
//int[] result = DuplicateZerosProblem.DuplicateZeros(nums);
//Console.WriteLine(result);

#endregion
#region Merge Sorted Array
//using AlgorithmChallenges.EasyProblems;

//int[] num1 = new int[6] { 1, 2, 3, 0, 0, 0 };
//int[] num2 = new int[3] { 2, 5, 6 };
//int[] result = MergeSortedArrayProblem.Merge(num1, 3, num2, 3);
//Console.WriteLine(result);
#endregion
#region Birthday Cake Candles
//using AlgorithmChallenges.EasyProblems;
//using System.IO;

//List<int> candles = new List<int>{8,2,6,4,8,1,8,3};

//int result = BirthdayCakeCandlesProblem.birthdayCakeCandles(candles);

//Console.WriteLine(result);

#endregion
#region Sorting Problem

//using AlgorithmChallenges.EasyProblems;

//List<int> a = new List<int> { 4, 3, 1, 2 };
//BubbleSortProblem.BubbleSort(a);
#endregion
#region  Migratory Birds


//using AlgorithmChallenges.EasyProblems;

//List<int> arr = new List<int> { 1, 2, 3, 4 ,5 ,4, 3, 2 ,1 ,3 ,4 };

//int result = MigratoryBirdsProblem.migratoryBirds(arr);

//Console.WriteLine(result);
#endregion
#region //n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

//Console.WriteLine("Sayı giriniz:");
//int n = Convert.ToInt32(Console.ReadLine());
//List<int> numbers = new List<int>();
//for(int i=0; i<n; i++)
//{
//    Console.WriteLine(i+1+". sayıyı giriniz:");
//    numbers.Add(Convert.ToInt32(Console.ReadLine()));
//}
//foreach(var item in numbers)
//{
//    if (item % 2 == 0)
//    {
//        Console.WriteLine(item);
//    }
//}

#endregion
#region //Kullanıcıdan girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
// Kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).kullanıcıdan n adet pozitif sayı girmesini isteyin.  m'e eşit yada tam bölünenleri yazdırın.


//Console.WriteLine("Sayı giriniz:");
//int n=Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[n];
//int m = 0;
//for(int i=-1;i<n; i++)
//{
//    Console.WriteLine("Sayı giriniz: ");
//    if(i!= -1)
//    {
//        numbers[i]=Convert.ToInt32(Console.ReadLine());
//    }
//    else {  m = Convert.ToInt32(Console.ReadLine()); }
//}
//foreach(var item in numbers)
//{
//    if(item % m == 0)
//    {
//        Console.WriteLine(item);
//    }
//}


#endregion
#region kullanıcıdan pozitif bir sayı girmesini isteyin (n) . n adet kelime girmesi isteyin. kelimeleri sondan başa doğru console'a yazdırın

//Console.WriteLine("Sayı giriniz:");
//int n = Convert.ToInt32(Console.ReadLine());
//string[] vocabulary = new string[n];

//for(int i=0; i<n; i++)
//{
//    Console.WriteLine(i+1+". kelimeyi giriniz:");
//    vocabulary[i]=(Console.ReadLine());
//}

//Array.Reverse(vocabulary);
//foreach(var item in vocabulary) { Console.WriteLine(item); }

#endregion
#region Kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

//using System.Diagnostics.Metrics;

//Console.WriteLine("Bir cümle yazınız:");
//string sentence = Console.ReadLine();
//int letterCount = 0;
//int vocabularyCount = 0;

//foreach(char item in sentence)
//{
//    if (char.IsLetter(item)) letterCount++;
//}
//string[] vocabulary = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

//vocabularyCount = vocabulary.Length;
//Console.WriteLine("Toplam Kelime Sayısı:"+vocabularyCount+" ve harf sayısı:"+letterCount);

#endregion
#region String to Integer
////Read a string, S, and print its integer value; if S cannot be converted to an integer, print Bad String.
////Note: You must use the String-to-Integer and exception handling constructs built into your submission language.
////If you attempt to use loops/conditional statements, you will get a  score.

//string S = "4532";
////List<char> result= new List<char>(S.ToCharArray());
////string.Concat(S.Where(char.IsDigit));

//try
//{
//    Console.WriteLine(int.Parse(S));
//}
//catch
//{
//    Console.WriteLine("Bad String");
//}

#endregion

#region CalculatorException

Calculator myCalculator = new Calculator();
int T = Int32.Parse(Console.ReadLine());
while (T-- > 0)
{
    string[] num = Console.ReadLine().Split();
    int n = int.Parse(num[0]);
    int p = int.Parse(num[1]);
    try
    {
        int ans = myCalculator.power(n, p);
        Console.WriteLine(ans);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);

    }

#endregion



#endregion

#region MediumProblems

//#region FindTheMostCompetitiveSubsequenceProblem
//using AlgorithmChallenges.MediumProblems;

//int[] nums = { 2, 4, 3, 3, 5, 4, 9, 6 };
//int k = 4;
//int[] result = FindTheMostCompetitiveSubsequenceProblem.MostCompetitive(nums, k);
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//#endregion



#endregion





