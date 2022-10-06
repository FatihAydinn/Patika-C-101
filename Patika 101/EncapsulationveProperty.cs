using System;
using System.Collections;

namespace konsolprog
{
    class EncapsulationveProperty
    {
        public static void Main(string[] args)
        { 
        Ogrenci ogrenci1 = new Ogrenci("Fatih","Aydın",188,12,"AE");
        ogrenci1.SinifAtla();
        ogrenci1.Yazdir();
        Console.ReadKey();
        }

        class Ogrenci{
            private string ad;
            private string soyad;
            private int no;
            private int sinif;
            private string sube;

//          public string Ad { get => ad; set => ad = value; }
            public string Ad 
            {
            get { return ad; }
            set {  ad = value; }
            }

            public string Soyad { get => soyad; set => soyad = value; }
            public int No { get => no; set => no = value; }
            public int Sinif { get => sinif; 
            set{
            if (value>12)
            {
                Console.WriteLine("Mezun");
                sinif = 12;
            }
            else
            sinif = value; }}
            public string Sube { get => sube; set => sube = value; }
        
            public Ogrenci(){}
            public Ogrenci(string Adi , string Soyadi , int Noo, int Sinifi , string Subesi){
                this.ad = Adi;
                this.soyad = Soyadi;
                this.no = Noo;
                this.sinif = Sinifi;
                this.Sube = Subesi;
            }
            public void Yazdir()
            {
                Console.WriteLine("{0} ",ad);
                Console.WriteLine("{0} ",soyad);
                Console.WriteLine("{0} ",no);
                Console.WriteLine("{0} ",sinif);
                Console.WriteLine("{0} ",sube);
            }
            public void SinifAtla()
            {
                this.Sinif += 1;
            }
        }
        
        
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
