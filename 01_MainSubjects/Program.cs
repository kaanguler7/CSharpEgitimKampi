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
            #region YazdırmaKomutları
            //Console.WriteLine("***** Yemek Katagorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Talatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Katagorileri *****");

            #endregion
            #region StringDeğişkenler 


            //string name;
            //name = "Kaan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName ="Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 0533 608 69 31";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("Telefon No; " + customerPhone);
            //Console.WriteLine("Email Adresi ;" + customerEmail);
            //Console.WriteLine("İlçe ;" + district);
            //Console.WriteLine("Şehir ;" + city);







            #endregion

            #region IntDeğişkenler

            //int 
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Resturant Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("-----Kola :" + cokePrice+"TL");
            Console.WriteLine("-----Hamburger :" + hamburgerPrice + "TL");
            Console.WriteLine("-----Su :" + waterPrice + "TL");
            Console.WriteLine("-----Kızartmalar :" + friesPrice + "TL");
            Console.WriteLine("-----Pizza :" + pizzaPrice + "TL");
            Console.WriteLine("-----Limonata :" + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Resturant Menü Fiyatı *****");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int hamburgerTotalPrice;
            int waterTotalPrice;
            int friesTotalPrice;
            int lemonadeTotalPrice;
            int cokeTotalPrice;
            int pizzaTotalPrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            hamburgerTotalPrice = hamburgerPrice * hamburgerCount;
            waterTotalPrice = waterPrice * waterCount;
            friesTotalPrice = friesPrice * friesCount;
            lemonadeTotalPrice = lemonadePrice * lemonadeCount;
            cokeTotalPrice = cokePrice * cokeCount;
            pizzaTotalPrice = pizzaPrice * pizzaCount;

            Console.WriteLine();

            Console.WriteLine("***** Hesap *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger Fiyatı :" + hamburgerTotalPrice + "TL");
            Console.WriteLine("Kola Fiyatı :" + cokeTotalPrice + "TL");
            Console.WriteLine("Su Fiyatı :" + waterTotalPrice + "TL");
            Console.WriteLine("Kızartma Fiyatı :" + friesTotalPrice + "TL");
            Console.WriteLine("Pizza Fiyatı :" + pizzaTotalPrice + "TL");
            Console.WriteLine("Limonata Fiyatı :" + lemonadeTotalPrice + "TL");

            Console.WriteLine();
            int toplamHesap=hamburgerTotalPrice+cokeTotalPrice+waterTotalPrice+friesTotalPrice+pizzaTotalPrice+lemonadeTotalPrice;
            Console.WriteLine("Toplam Hesap :"+toplamHesap+"TL");


            #endregion

            Console.Read();
        }
    }
}
