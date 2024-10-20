using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VoidMethods

            //void CustomerList() 
            //{
            //    Console.WriteLine("Enes Bozkurt");
            //    Console.WriteLine("Emre Bozkurt");
            //    Console.WriteLine("Murat Bozkurt");
            //    Console.WriteLine("Ersin Bozkurt");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x, y, sum;
            //    x = 1; y=0;
            //    Console.WriteLine("Toplam: "+(sum=x+y).ToString());
            //}

            //Sum();

            #endregion

            #region NotReturnValueParameterMethods
            //void WriteNameMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //WriteNameMethod("Enes");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri ismi: "+name+" Müşteri Soyismi: "+surName);
            //}

            //CustomerCard("Enes","Bozkurt");

            #endregion

            #region NotReturnValueIntParameterMethods
            //void Sum(int number1,int number2, int number3)
            //{
            //    int result=number1 + number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(5, 10, 15);

            #endregion

            #region ReturnValueMethods

            //string CustomerName()
            //{
            //    return "Enes Bozkurt";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Enes";
            //    string surName = "Bozkurt";
            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region ReturnValueStringParameterMethods
            //string CountryCard(string countryName,string capitalName,string flagColor)
            //{
            //    return "Ülke Adı: "+countryName+" - Başkent İsmi: "+capitalName+" - Bayrak Rengi: "+flagColor;
            //}
            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz:");
            //x= Console.ReadLine();
            //Console.WriteLine("Başkent Adını Giriniz:");
            //y = Console.ReadLine();
            //Console.WriteLine("Bayrak Rengini Giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion

            #region ReturnValueIntParameterMethods
            //int Sum(int number1, int number2) 
            //{ 
            //   int result = number1 + number2;
            //   return result;
            //}

            //Console.WriteLine(Sum(120, 365));
            //Console.WriteLine(Sum(487, 852));
            //Console.WriteLine(Sum(444, 316));
            //Console.WriteLine(Sum(659, 5240));
            #endregion

            #region ExampleApp
            string ExamResult(string student, int exam1, int exam2, int exam3) 
            { 
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50) return student + " "+ "Öğrenci sınavı geçti"+ " Ortalama: "+result;

                else return student + " "+ "Öğrenci başarısız oldu"+ " Ortalama: "+result;
            }

            Console.WriteLine(ExamResult("Enes", 100, 75, 90));
            Console.WriteLine(ExamResult("Ersin", 45, 48, 62));
            #endregion

            Console.Read();
        }
    }
}
