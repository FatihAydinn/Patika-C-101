using System;
using System.Collections;

namespace konsolprog
{
    class KurucuFonksiyonlar
    {
        public static void Main(string[] args)
        { 
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Fa";
            calisan1.Soyad = "tih";
            calisan1.Yas = 2;
            calisan1.Mevki = "x";
            Calisan calisan2 = new Calisan("Fatih","Aydın",22,"dev");
            calisan1.Yazdir();
            Console.WriteLine();
            calisan2.Yazdir();
        Console.ReadKey();
        }

        class Calisan{
            public string Ad ;            
            public string Soyad ;            
            public int Yas ;            
            public string Mevki ;            
    

            public Calisan(){}

            public Calisan(string ad , string soyad , int yas , string mevki){ // Kurucu Fonk.
                this.Ad = ad;
                this.Soyad = soyad;
                this.Yas = yas;
                this.Mevki = mevki;
            }
            
            public void Yazdir(){
                Console.WriteLine("{0} ",Ad);
                Console.WriteLine("{0} ",Soyad);
                Console.WriteLine("{0} ",Yas);
                Console.WriteLine("{0} ",Mevki);
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");