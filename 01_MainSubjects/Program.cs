using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WriteCommands
            Console.Write("Test Messages");
            Console.WriteLine("Value \n");
            #endregion

            #region StringVariables
            string customerName = "Enes", customerSurname = "Bozkurt", customerEmail = "enesxbozkurt@gmail.com", customerPhone = "11111111111", customerSalary = "45000";
            Console.WriteLine(customerName+" "+customerSurname+" "+customerEmail+" "+customerPhone+" "+customerSalary+"\n");
            #endregion

            #region IntegerVariables
            int hamburgerPrice = 300, lemonadePrice = 30, waterPrice = 10, friesPrice = 50;
            Console.WriteLine("Hamburger Ücreti: "+hamburgerPrice+" \n" +"Limonata Ücreti: "+lemonadePrice+"\n"+"Su Ücreti: "+waterPrice+"\n"+"Patetes Kızartması Ücreti: "+friesPrice);

            int hamburgerCount;
            int lemonadeCount;
            int waterCount;
            int friesCount;

            int totalHamgurgerPrice;
            int totalLemonadePrice;
            int totalWaterPrice;
            int totalFriesPrice;


            hamburgerCount = 2;
            lemonadeCount = 5;
            waterCount = 6;
            friesCount = 4;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalHamgurgerPrice + totalLemonadePrice + totalWaterPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");
            #endregion

            Console.Read();
        }
    }
}
