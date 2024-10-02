using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region DoubleVariables
            Console.WriteLine("***** Fiyat Listesi *****\n");

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 25.66;
            orangePrice = 19.99;
            strawberryPrice = 48.50;
            potatoPrice = 23.63;
            tomatoPrice = 47.80;

            Console.WriteLine("---- Elma Birim Fiyatı: "+applePrice+ "₺");
            Console.WriteLine("---- Portakal Birim Fiyatı: "+orangePrice + "₺");
            Console.WriteLine("---- Çilek Birim Fiyatı: "+strawberryPrice + "₺");
            Console.WriteLine("---- Patates Birim Fiyatı: "+potatoPrice + "₺");
            Console.WriteLine("---- Domates Birim Fiyatı: "+tomatoPrice + "₺");

            Console.WriteLine("\n \n");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 0.560;
            orangeGram = 1.890;
            strawberryGram = 0.200;
            potatoGram = 1.959;
            tomatoGram = 2.000;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);

            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);

            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);

            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;

            Console.WriteLine("\n \n");


            Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + " TL\n");

            #endregion

            #region CharVariables
            char symbol;
            symbol = 'E';

            Console.WriteLine(symbol +"\n");
            #endregion

            #region InputDataFromKeyboard
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("İl Bilgisi: ");
            passengerCity = Console.ReadLine();

            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("-----------------------");
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +" "+ passengerName + " " + passengerSurname + " "  + passengerDistrict  + " / " + passengerCity + " " + passengerAge +"\n");
            #endregion

            #region InputIntagerAndTransformationFromKeyboard
            int computerPrice, chairPrice, monitorPrice;
            computerPrice = 20000;
            chairPrice = 7000;
            monitorPrice = 5000;

            int computerCount, chairCount, monitorCount;

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız monitör sayısını giriniz: ");
            monitorCount = int.Parse(Console.ReadLine());

            int totalPrice = computerCount * computerPrice + chairCount * chairPrice + monitorCount * monitorPrice;

            Console.WriteLine("\n Toplam Ödemeniz Gereken Tutar: " +  totalPrice);
            #endregion

            #region InputDoubleNumberFromKeyboard
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);
            #endregion

            #region InputCharFromKeyboard
            char gender;
            Console.Write("Lütfen cinsiyet bilgisini giriniz(M:male,F:Female): ");
            gender = char.Parse(Console.ReadLine());
            if (gender=='M')
            {
                Console.WriteLine("Your gender is Male");
            }
            else
            {
                Console.WriteLine("Your gender is Female");
            }

            #endregion

            Console.Read();
        }
    }
}
