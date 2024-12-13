using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public  class CollectionsProblems
    {

        //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        //Negatif ve numeric olmayan girişleri engelleyin.
        //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
        //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
        public static void primeNonPrimeNumbers(ArrayList numbers)
        {
            ArrayList primeNumber = new ArrayList();
            ArrayList nonPrimeNumber = new ArrayList();

            foreach(int item in numbers)
            {
                int count = 0;
                
                for(int i=2; i<item; i++)
                {
                    if(item % i == 0) { count++;  }
                }
                if (count == 0) { primeNumber.Add(item); } else { nonPrimeNumber.Add(item); }
            }

            void sortNumbers(ArrayList numbers)
            {
                for(int i=0; i< numbers.Count; i++) { Console.Write(numbers[i]+", "); }
            }
            Console.WriteLine("Asal sayıların büyükten küçüğe sırası:");
            primeNumber.Sort();
            sortNumbers(primeNumber);
            Console.WriteLine("Asal olmayan sayıların büyükten küçüğe sıralanması:");
            sortNumbers(nonPrimeNumber);

            void averageArrayList(ArrayList numbers)
            {
                int count = 0;
                int sum = 0;
                foreach(int item in numbers) { count++;  sum += item; }
                int average = sum / count;
                Console.Write("eleman sayısı: "+count+" ve ortalaması: "+average);
            }

            Console.WriteLine("Asal sayıların olduğu listenin");
            averageArrayList(primeNumber);
            Console.WriteLine("Asal olmayan sayıların olduğu listenin");
            averageArrayList(nonPrimeNumber);


        }


        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan
        //ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        public static void minMaxNumbers(ArrayList numbers)
        {
            numbers.Sort();
            ArrayList minThree = new ArrayList();
            ArrayList maxThree = new ArrayList();
            int minSum = 0;
            int maxSum = 0;
            Console.WriteLine("\nEn küçük 3 sayı:");
            for (int i=0; i<3; i++)
            {
                Console.WriteLine( numbers[i]);
                minSum += Convert.ToInt32(numbers[i]);
                minThree.Add(numbers[i]);
            }
            Console.WriteLine("\nEn büyük 3 sayı:");
            for (int i = numbers.Count - 1; i >= numbers.Count - 3; i--)
            {
                Console.WriteLine(numbers[i]);
                maxSum += Convert.ToInt32(numbers[i]);
                maxThree.Add(numbers[i]);
            }

            //Average
            Console.WriteLine("Küçük sayıların ortalaması: "+(minSum/3));
            Console.WriteLine("Büyük sayıların ortalaması: "+(maxSum/3));
            Console.WriteLine("İki grubun ortalaması: "+(maxSum/3 + minSum/3)/2);
            Console.WriteLine("İki grubun ortalama toplamı: "+ maxSum / 3 + minSum / 3);

        }

        //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
        public static void stringArray()
        {
            Console.WriteLine("Bir cümle giriniz.");
            string sentence = Console.ReadLine();
            char[] vowel = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü',
                                'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
            // Cümledeki sesli harfleri filtreleme
            char[] vowels = sentence
                .Where(c => vowel.Contains(c))
                .ToArray();

            // Sonuçları yazdır
            Console.WriteLine("\nCümledeki sesli harfler:");
            foreach (char harf in vowels)
            {
                Console.Write(harf + " ");
            }



        }


    }
}
