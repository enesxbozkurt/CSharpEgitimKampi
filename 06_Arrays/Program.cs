using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BasicArraysExample
            //string [] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Yeşil";
            //colors[3] = "Sarı";
            //Console.WriteLine(colors[3]);

            //Console.WriteLine(colors[4]);

            //int[] numbers = new int[10];
            //numbers[1] = 5;
            //numbers[3] = 15;
            //numbers[5] = 52;
            //numbers[6] = 54;
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "İstanbul", "Ankara", "Izmir", "Sivas" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region AllArrayElementsList
            //string[] names = { "Enes", "Emre", "Ersin", "Murat" };
            //for (int i = 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine(names[i]);
            //}  

            //int[] numbers = {1,85,963,74,1885,688,4475,63,1158,7895,425,699};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int mostBigNumber = 0;

            //int[] numbers = {1,12,136,542,8596,748596,3258742,1000000,200000,1000895623};
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i]>=mostBigNumber) 
            //    {
            //        mostBigNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(mostBigNumber);


            //string[] persons = {"enes","emre","ersin"};
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 5, 8, 69, 352, 145, 7844, 22222 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 5, 8, 69, 352, 145, 7844, 22222 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region ArrayMethods
            //string[] customers = { "enes", "emre", "ersin", "murat" };
            //int index = Array.IndexOf(customers, "ersin");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //Console.WriteLine("Dizinin en küçük elemanı: "+numbers.Min() +" Dizinin en büyük elemanı: "+numbers.Max());
            #endregion

            #region GetValueFromUser
            //int[] numbers = new int[10];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Dizinin "+i.ToString()+" index'ini giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine()); 
            //}
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = {78,32,61,998,75,488,63,58,95547};

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i] % 2 == 0) 
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}

            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
            #endregion

            Console.Read();
        }
    }
}
