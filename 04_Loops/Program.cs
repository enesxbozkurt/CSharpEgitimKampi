using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForLoop
            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int j = 1; j <= 20; j++)
            //{
            //    Console.WriteLine(j);
            //}

            //for (int k = 3; k <= 70; k += 3)
            //{
            //    Console.WriteLine(k);
            //}

            //Console.Write("Kaç kere ekrana yazılmalı: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int l = 1; l <= finishValue; l++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region MakingDecisionWithForLoop
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 25; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalValue = 0;

            //for (int i = 1; i < 80; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 99; i++)
            //{
            //    if (i % 9 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium = bacterium * 2;
            //}
            //Console.WriteLine(bacterium);
            #endregion

            #region WhileLoop
            //int i = 1;

            //while (i <= 40)
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 30)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);
            #endregion

            #region ExampleExamQuestion
            //Console.Write("Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //Console.WriteLine(hundreds + "-" + tens + "-" + ones);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            #endregion
            Console.Read();
        }
    }
}
