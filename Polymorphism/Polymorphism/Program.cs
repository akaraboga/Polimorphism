using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kare kare = new Kare();//Geometrik şekillerden nesne turetip,içlerine değer atayıp ekrana yazdırıyoruz.
            kare.Genislik = 10;
            kare.Yukseklik = 3;

            kare.kareAlan();

            Dikdortgen _dikdortgenAlan = new Dikdortgen();
            _dikdortgenAlan.Genislik = 10;
            _dikdortgenAlan.Yukseklik = 7.5;

            _dikdortgenAlan.DikdortgenAlan();

            DıkUcgen _DikucgenAlan = new DıkUcgen();
            _DikucgenAlan.Genislik = 10;
            _DikucgenAlan.Yukseklik = 4;

            Console.WriteLine("Dikucgenin alanı : " + _DikucgenAlan.AlanHesap());


            Console.ReadLine();
        }



        class BaseGeometrikSekil //Genişlik ve yüksekliğin çarpımını alacağımız class
        {
            public double Genislik { get; set; }

            public  double Yukseklik { get; set; }


            public virtual double AlanHesap()//virtual diyerek BaseGeometrikSekili miras alan classın içinde override diyerek istediğimiz şekilde değiştirebileceğiz
            {
                return Genislik * Yukseklik;
            }


        }

        class Kare : BaseGeometrikSekil
    {
            public void kareAlan()
            {
                Console.WriteLine("Karenin alanı : " + AlanHesap());//Karenin alanı


            }
        }


        class Dikdortgen : BaseGeometrikSekil
        {
            public void DikdortgenAlan()
            {
                Console.WriteLine("Dikdortgenin alanı : " + AlanHesap());//Diktortgenin alanı
            }

        }


        class DıkUcgen : BaseGeometrikSekil
        {
            public override double AlanHesap()//BUrada BaseGeometrikSekili miras alarak DıkUcgen clasının içinde BaseGeometrikSekil den gelen AlanHesap() metodunu override ekleyerek isteiğimiz şekilde değişiklik yapabiliyoruz.
            {
                return (Genislik * Yukseklik) / 2;



            }
        }


    }
}
