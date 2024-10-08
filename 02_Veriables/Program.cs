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
            #region Double Değişkenler
            //double number;
            //number = 0.75;
            //Console.Write(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potate, tomato;

            //applePrice = 14.85;
            //orangePrice = 13.50;
            //strawberryPrice = 25.25;
            //potate = 8.75;
            //tomato = 6;

            //Console.WriteLine("---- Elma Birim Fiyatı : "+applePrice+ " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potate + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomato + "  TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potateGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potateGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice= orangeGram * orangePrice;
            //double strawberryTotalPrice= strawGram * strawberryPrice;
            //double potateTotalPrice= potateGram * potate;
            //double tomatoTotalPRice= tomatoGram * tomato;

            //Console.WriteLine("Toplam Alınan Elma Fiyatı : " + appleTotalPrice+" TL");
            //Console.WriteLine("Toplam Alınan Portakal Fiyatı : " + orangeTotalPrice + " TL");
            //Console.WriteLine("Toplam Alınan Çilek Fiyatı : " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Toplam Alınan Patates Fiyatı : " + potateTotalPrice + " TL");
            //Console.WriteLine("Toplam Alınan Domates Fiyatı : " + tomatoTotalPRice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potateTotalPrice + tomatoTotalPRice;

            //Console.WriteLine("Toplam Ödenecek Alışveriş Tutarı : " + shoppingTotalPrice + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);




            #endregion
            #region Klavyeden Veri Girişi
            Console.WriteLine("**** Kaan Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;
            Console.Write("Yolcu Adı :");
            passengerName =Console.ReadLine();

            Console.Write("Yolcu Soyadı :");
            passengerSurname =Console.ReadLine();

            Console.Write("İlçe Bilgisi :");
            passengerDistrict = Console.ReadLine();

            Console.Write("Şehir Bilgisi :");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcu Yaşı :");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcu Kimlik NO :");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("----------------------");
            Console.WriteLine("Yolcu : "+passengerName+" "+passengerSurname+" "+passengerDistrict+" "+passengerCity+" "+passengerAge+" "+passengerIdentityNumber);


            #endregion

            Console.Read();
            
        }
    }
}
