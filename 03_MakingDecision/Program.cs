using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IfElseCommands
            Console.WriteLine("Şifreyi Giriniz");
            string password = Console.ReadLine();
            if (password == "Pass")
            {
                Console.WriteLine("Şifre Doğru :)");
            }
            else 
            {
                Console.WriteLine("Şifre Yanlış :(");
            }
            Console.WriteLine("");

            Console.WriteLine("Ülkeyi Giriniz");
            string country = Console.ReadLine();


            Console.WriteLine("Başkenti Giriniz");
            string capital = Console.ReadLine();
            

            if (country == "Türkiye" && capital == "Ankara")
            {
                Console.WriteLine("Veriler Doğru");
            }
            else 
            {
                Console.WriteLine("Veriler Yanlış");
            }
            Console.WriteLine("");

            
            Console.WriteLine("Numara giriniz");
            int number=int.Parse(Console.ReadLine());
            if (number==10)
            {
                Console.WriteLine("Sayı doğru");
            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }

            Console.WriteLine("");

            int exam1, exam2, exam3,average;
            string result = "Hata! Lütfen girdiğiniz değerleri kontrol ediniz.";
            Console.WriteLine("Sınav 1 giriniz");
            exam1=int.Parse(Console.ReadLine());
            Console.WriteLine("Sınav 2 giriniz");
            exam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sınav 3 giriniz");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            if (average>0&&average<=50)
            {
                result = "Sonuç Kötü";
            }
            if (average > 50 && average <= 70)
            {
                result="Sonuç Orta";
            }
            if (average > 70 && average <= 84)
            {
                result="Sonuç İyi";
            }
            if (average > 84 && average <= 100)
            {
                result = "Sonuç Çok İyi";
            }

            Console.WriteLine(result);
            Console.WriteLine("");

            Console.WriteLine("Şehir Giriniz");
            string city = Console.ReadLine();
            if (city=="istanbul"|city=="ankara"|city=="izmir")
            {
                Console.WriteLine("Şehir Listede Var.");
            }
            else
            {
                Console.WriteLine("Şehir Listede yok.");
            }

            Console.WriteLine("");

            Console.Write("Kullanıcı adını giriniz: ");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.Write("Kullanıcı adı hatalı!");
            }
            else
            {
                Console.Write("Hoş geldiniz...");
            }

            Console.WriteLine();

            #endregion

            #region ModeOperations
            Console.WriteLine("Sayı giriniz");
            int modeNumber=int.Parse(Console.ReadLine());
            if (modeNumber%2==0) Console.WriteLine("Sayı çift sayıdır.");
            if (modeNumber%2==1) Console.WriteLine("Sayı tek saydır");

            Console.Write("1.Sayıyı giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int modeResult = number1 % number2;

            Console.Write("1.Sayının 2.Sayıya bölümünden kalan: " + modeResult);

            Console.WriteLine();
            #endregion

            #region MakingDecisionWithCharVariables
            char team;
            Console.Write("Takım kısaltmasını giriniz: ");
            team = char.Parse(Console.ReadLine());
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }

            if (team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }

            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }

            Console.WriteLine();
            #endregion

            #region ExampleProjectApplication
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-------------------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("-------------------------");
            Console.WriteLine();


            string menuItem;

            Console.Write("Hangi menüyü görmek istiyorsunuz: ");
            menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------------Ana Yemekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Tavuk Pilav");
                Console.WriteLine("2-Patates Kızartmalı Tavuk");
                Console.WriteLine("3-Nohut Pilav");
                Console.WriteLine("4-Fırında Patates Tavuk");
                Console.WriteLine("5-Türlü");
                Console.WriteLine("------------Ana Yemekler------------");

                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("------------Çorbalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Kellepaça Çorbası");
                Console.WriteLine("2-İşkembe Çorbası");
                Console.WriteLine("2-Mercimek Çorbası");
                Console.WriteLine("------------Çorbalar------------");

                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("------------Pizzalar------------");
                Console.WriteLine();
                Console.WriteLine("1-Kaşarlı Zeytinli Pizza");
                Console.WriteLine("2-Çedar Pizza");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine("------------Pizzalar------------");

                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------İçecekler------------");
                Console.WriteLine();
                Console.WriteLine("1-Ayran");
                Console.WriteLine("2-Fanta");
                Console.WriteLine("3-Su");
                Console.WriteLine("------------İçecekler------------");

                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------Tatlılar------------");
                Console.WriteLine();
                Console.WriteLine("1-Çikolatalı Pasta");
                Console.WriteLine("2-Baklava");
                Console.WriteLine("3-Künefe");
                Console.WriteLine("------------Tatlılar------------");

                Console.WriteLine();
            }
            #endregion

            #region SwitchCase

            Console.Write("Lütfen Ay Girişi Yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;
                default: Console.Write("Yanlış veri girişi yaptınız lütfen kontrol ediniz!"); break;
            }
            Console.WriteLine();
            #endregion

            #region SwitchCaseCalculator
            Console.WriteLine("1. Sayıyı Giriniz: ");
            int switchNumber1=int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz: ");
            int switchNumber2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Yapmak istediğiniz işlemin sembolünü giriniz.");
            char symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '+':
                    Console.WriteLine("Sayıların toplamı: "+(switchNumber1+switchNumber2)); break;
                case '-':
                    Console.WriteLine("Sayıların Çıkarımı: "+(switchNumber1-switchNumber2)); break;
                case '/':
                    Console.WriteLine("Sayıların Bölümü: " + (switchNumber1 / switchNumber2)); break;
                case '*':
                    Console.WriteLine("Sayıların Çarpımı: " + (switchNumber1 * switchNumber2)); break;
            }
            Console.ReadLine();
            #endregion

            Console.ReadLine();
        }
    }
}
