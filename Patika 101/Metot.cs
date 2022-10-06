using System;
namespace konsolprog
{
    class Metot
    {
        public static void Main(string[] args)
        {
          int a=10;
            int b=3;
            System.Console.WriteLine(a+b);
            int x = 0;
            int y = 0;
            int result=Topla(x,y);
            // System.Console.WriteLine(result);

            Metotlar metotlar=new Metotlar();
            metotlar.EkranaYazdir(result.ToString());

            int result2 = metotlar.ArttirTopla(ref a,ref b);
            System.Console.WriteLine(result2);
        }
        
            static int Topla(int deger1,int deger2)
            {
                deger1 = Convert.ToInt32(Console.ReadLine());
                deger2 = Convert.ToInt32(Console.ReadLine());
                return deger1 + deger2;
            }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }   
        public int  ArttirTopla(ref int deger1,ref int deger2)
        {
            deger2+=1;
            deger1+=1;
            return deger1+deger2;
        }            
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");