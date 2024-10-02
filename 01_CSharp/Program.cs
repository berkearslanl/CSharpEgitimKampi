using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam"); // bundan sonrakiler alt satıra geçer


            //Console.WriteLine("***** YEMEK KATEGORİLERİ *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** YEMEK KATEGORİLERİ");

            #endregion

            #region String Değişkenler

            //string name;
            //name = "Berke";
            //Console.Write(name);

            //string customerName = "Berke";
            //string customerSurname = "Arslan";
            //string customerPhone = "+90 555 555 55 55";
            //string customerEmail = "deneme@gmail.com";
            //string customerCity = "Kırklareli";
            //string customerDistrict = "Lüleburgaz";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri : "+customerName+" "+customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi :"+customerEmail);
            //Console.WriteLine("Adres : " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("------------------------------");

            //Console.WriteLine() ;

            //customerName = "Emir";
            //customerSurname = "Şen";
            //customerPhone = "+90 444 444 44 44";
            //customerEmail = "test@gmail.com";
            //customerCity = "Kocaeli";
            //customerDistrict = "Gebze";

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi :" + customerEmail);
            //Console.WriteLine("Adres : " + customerDistrict + "/" + customerCity);
            //Console.WriteLine("------------------------------");
            #endregion

            #region Int Değişkenler

            //int number = 34;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: "+hamburgerPrice+" TL");
            Console.WriteLine("-----Pizza: "+pizzaPrice+" TL");
            Console.WriteLine("-----Kola: "+cokePrice+" TL");
            Console.WriteLine("-----Limonata: "+lemonadePrice+" TL");
            Console.WriteLine("-----Kızartma: " + friesPrice + " TL");
            Console.WriteLine("-----Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + " TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + " TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + " TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + " TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + " TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + " TL");

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + 
                totalLemonadePrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + " TL");
            #endregion


            Console.Read(); // enter tuşuna basana kadar ekran kapanmaz
        }
    }
}
