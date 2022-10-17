using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserClass user = new UserClass();
            PointClass point = new PointClass();
            Console.WriteLine("\nVoting Uygulamasına Hoşgeldin");
            Console.WriteLine("Film Kategoriler:");
            Console.WriteLine("(1) Bilim Kurgu");
            Console.WriteLine("(2) Macera");
            Console.WriteLine("(3) Korku");
            Console.WriteLine("(4) Komedi");
            Console.WriteLine("(5) Romantik");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                {
                    user.User();
                    point.BilimKurgu();
                    break;              
                }
                case 2:
                {
                    point.Macera();
                    break; 
                }
                case 3:
                {
                    point.Korku();
                    break;                 
                }
                case 4:
                {
                    point.Komedi();
                    break;                 
                }
                case 5:
                {
                    point.Romantik();
                    break;                 
                }
            }
        Console.ReadKey();
        }
    }
}
