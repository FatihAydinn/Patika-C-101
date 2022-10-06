using System;
namespace konsolprog
{
    class MetotOverloading
    {
        public static void Main(string[] args)
        {
            string deger = Console.ReadLine();
            int outdeger;
            bool sonuc = int.TryParse(deger , out outdeger);
            if (sonuc)
            {
                Console.WriteLine("evet recep gerçekten de öyle");
                Console.WriteLine(outdeger);
            }             
            else
                Console.WriteLine("yok");

                Metotlar instance = new Metotlar();
                instance.Topla (2,3, out int toplamsonuc);
                Console.WriteLine(toplamsonuc);

                 int ifade=999;
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("fatih","alo");
                
        }
        class Metotlar
        {
            public void Topla (int a , int b, out int toplam)
            {
                toplam = a + b;
            }
             public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1,string veri2)
        {
            System.Console.WriteLine(veri1+veri2);
        }
        }
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");