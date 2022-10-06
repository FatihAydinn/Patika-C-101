using System;
using System.Collections;

namespace konsolprog
{
    class StaticSinifveUyeler
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine("{0}",Calisan.CalisanSayi);
            Calisan calisan1 = new Calisan("Fatih","Aydın");
            Console.WriteLine("{0}",Calisan.CalisanSayi);
            Console.WriteLine();
            Console.WriteLine("Toplam sonucu ==> "+Islem.Topla(50,75));
            Console.ReadKey();
        }
        class Calisan
        {
            private static int calisanSayi;

            public static int CalisanSayi { get => calisanSayi; set => calisanSayi = value; }


            private string isim; // yazdırılmayacak sadece verileri alınıyor
            private string soyisim;

            public Calisan(string isim, string soyisim)
            {
                this.isim = isim;
                this.soyisim = soyisim;
                calisanSayi++;
            }

            static Calisan(){
                calisanSayi = 1;
            }
        }
       static class Islem{
        public static int Topla(int x , int y){
            return x + y;    
        }
       }
        
        
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");