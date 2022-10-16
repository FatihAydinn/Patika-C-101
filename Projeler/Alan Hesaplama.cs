using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            basla:
        Console.WriteLine(" ");
        Console.WriteLine("Hesaplanmasını istediğiniz geometrik şekli seçin");
        Console.WriteLine("Daire      : (1)");
        Console.WriteLine("Kare       : (2)");
        Console.WriteLine("Üçgen      : (3)");
        Console.WriteLine("Dikdörtgen : (4)");
        Console.WriteLine("Çıkış      : (0)");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
        case 1:
        {
            daire:
            Console.Write("Dairenin yarıçap değerini girin: ");
            double ycap = Convert.ToInt32(Console.ReadLine());
            ycap /= 2;
            Console.WriteLine("Alan hesaplamaası için  (1)");
            Console.WriteLine("Çevre hesaplamaası için (2)");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                ycap = Math.PI * (Math.Pow(ycap,2));
                Console.WriteLine("Dairenin çevresi ==> "+ ycap);
            }
            else if (d == 2)
            {
                ycap = 2 * Math.PI * ycap;
                Console.WriteLine("Dairenin çevresi ==> "+ ycap);
            }
            else
            {
            Console.WriteLine("Hatalı değer girdiniz");
            goto daire;
            }
        }
        goto basla;
        case 2:
        {
            kare:
            Console.Write("Karenin kenar uzunluk değerini girin: ");
            double kuzun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alan hesaplamaası için  (1)");
            Console.WriteLine("Çevre hesaplamaası için (2)");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("Karenin çevresi ==> "+ (kuzun *= 4));
            }
            else if (d == 2)
            {
                Console.WriteLine("Karenin alanı ==> "+ Math.Pow(kuzun,2));
            }
            else
            {
            Console.WriteLine("Hatalı değer girdiniz");
            goto kare;
            }
        }
        goto basla;
        case 3:
        {
            ucgen:
            Console.Write("Eşkenar üçgenin kenar uzunluk değerini girin: ");
            double ucgen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alan hesaplamaası için  (1)");
            Console.WriteLine("Çevre hesaplamaası için (2)");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("Eşkenar üçgenin çevresi ==> "+ (ucgen *= 3));
            }
            else if (d == 2)
            {
                ucgen = (Math.Pow(ucgen,2) * Math.Sqrt(3))/4;
                Console.WriteLine("Eşkenar üçgenin alanı "+ ucgen);
            }
            else
            {
            Console.WriteLine("Hatalı değer girdiniz");
            goto ucgen;
            }
        }
        goto basla;
        case 4:
        {
            dikdörgen:
            Console.Write("Dikdörgenin uzun kenar değerini girin: ");
            double duzun = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörgenin kısa kenar değerini girin: ");
            double dkisa = Convert.ToInt32(Console.ReadLine());
            if (dkisa >= duzun)
            {
                Console.WriteLine("Kısa kenar uzun kenardan uzun olamaz");
                goto dikdörgen;
            }
            Console.WriteLine("Alan hesaplamaası için  (1)");
            Console.WriteLine("Çevre hesaplamaası için (2)");
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("Dikdörgenin çevresi ==> "+ (duzun + dkisa)*2);
            }
            else if (d == 2)
            {
                Console.WriteLine("Dikdörgenin çevresi ==> "+ (duzun * dkisa));
            }
            else
            {
            Console.WriteLine("Hatalı değer girdiniz");
            goto dikdörgen;
            }
        }
        goto basla;
        case 0:
        {
            Environment.Exit(0);
        }
        break;
        default:
        {
            System.Console.WriteLine("Geçersiz bir değer girildi");
            goto basla;
        }
        }
        Console.ReadKey();
        }
    }
}
