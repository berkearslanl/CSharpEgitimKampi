using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            #region Double Değişkenler
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı :" + applePrice + " ₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı :" + orangePrice + " ₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı :" + strawberryPrice + " ₺");
            //Console.WriteLine("---- Patates Birim Fiyatı :" + potatoPrice + " ₺");
            //Console.WriteLine("---- Domates Birim Fiyatı :" + tomatoPrice + " ₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan Ürün: Elma -" + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar:" +
            //    appleTotalPrice + " ₺");

            //Console.WriteLine("Alınan Ürün: Portakal -" + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar:" +
            //    orangeTotalPrice + " ₺");

            //Console.WriteLine("Alınan Ürün: Çilek -" + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar:" +
            //    strawberryTotalPrice + " ₺");

            //Console.WriteLine("Alınan Ürün: Patates -" + " Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar:" +
            //    potatoTotalPrice + " ₺");

            //Console.WriteLine("Alınan Ürün: Domates -" + " Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar:" +
            //    tomatoTotalPrice + " ₺");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar : " + shoppingTotalPrice + " ₺");

            #endregion


            #region Char Değişkenler

            // ' ile tanımlanır

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);





            #endregion


            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("CSharp Hava Yolları Yolcu Bilgisi");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("****************************");

            //Console.WriteLine("Yolcu Bilgileri : " + passengerIdentityNumber + "  " + passengerName + " " + passengerSurname +
            //    "  " + passengerDistrict + "/" + passengerCity + "  " + passengerAge + " Yaşında");

            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı adedini giriniz : ");
            ////shoesCount = Console.ReadLine(); BU ŞEKİLDE HATA VERECEĞİ İÇİN AŞAĞIDAKİ DÖNÜŞTÜRME İŞLEMİ YAPILMALIDIR
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar adedini giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye adedini giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon adedini giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice *
            //    tvCount;

            //Console.WriteLine();

            //Console.Write("Toplam Ödemeniz Gereken Tutar : " + totalPrice + "₺");



            #endregion


            #region Klavyeden Ondalıklı Sayı Girişleri ve İşlemleri

            //double vize, final, ortalama;

            //Console.Write("Vize Notunuzu Giriniz : ");
            //vize = double.Parse(Console.ReadLine());

            //Console.Write("Final Notunuzu Giriniz : ");
            //final = double.Parse(Console.ReadLine());

            //ortalama = (vize + final) / 2;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız : " + ortalama);




            #endregion


            #region Klavyeden Karakter Girişleri

            //char gender; // cinsiyet
            //Console.Write("Lütfen Cinsiyetinizi Giriniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion

            Console.Read();


        }
    }
}
