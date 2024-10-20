using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForeachLoop
            //string[] cities = {"istanbul","ankara","izmir","bursa","sivas"};
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            //foreach (int number in numbers) 
            //{
            //    if (number%2==0) Console.WriteLine(number);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //int sum = 0;
            //foreach (int i in numbers)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,523,5874,369885
            //};

            //string word = "enesxbozkurt";
            //foreach(char c in word) Console.WriteLine(c);
            #endregion

            #region ExampleExamSystemApp
            Console.WriteLine("Sınıfınızda kaç öğrenci var");
            int studentCount = int.Parse(Console.ReadLine());

            string[] students = new string[studentCount];
            string[] studentName = new string[studentCount];
            double[] studentAverage = new double[studentCount];
            double totalExamResult = 0;

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentName[i]} isimli öğrencinin {j + 1}. notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult = value + totalExamResult;
                }
                studentAverage[i] = totalExamResult / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması {studentAverage[i]}");
            }

            for (int i = 0; i < studentCount; i++)
            {
                if (studentAverage[i] < 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci sınıfta kaldı");
                }
                if (studentAverage[i] >= 50) Console.WriteLine($"{studentName[i]} adlı öğrenci sınıfı başarıyla geçti");

            }
            #endregion

            Console.Read();
        }
    }
}
