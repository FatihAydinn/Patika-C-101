using System;
using System.Collections;

namespace konsolprog
{
    class Odev2
    {
        public static void Main(string[] args)
        { 
            // //SORU 1
            // ArrayList asal = new ArrayList();
            // ArrayList dogal = new ArrayList();
            // for (int i = 1; i <= 5; i++)
            // {
            // int count = 0;
            //     sayi:
            //     Console.WriteLine("{0}. Sayıyı gir: ",i);
            //     try
            //     {
            //     int x = Convert.ToInt32(Console.ReadLine());
            //     if (x<=0)
            //     {
            //         Console.WriteLine("Geçersiz değeer");
            //         goto sayi;
            //     }
            //     for (int j = 1; j <= x; j++)
            //     {
            //         if (x % j == 0)
            //         {
            //             count++;
            //         }
            //     }
            //     if (count == 2){
            //         //Asal
            //         asal.Add(x);}
            //     else{
            //       // Asal Değil
            //         dogal.Add(x);
            //     }}
            //     catch (FormatException)
            //     {
            //         Console.WriteLine("Geçersiz değeer");
            //         goto sayi;
            //     }
            // }
            // Console.Write("Doğal Sayılar ==> ");                
            // foreach (var item in dogal)
            // {
            // Console.Write(item+" ");
            // }
            // Console.WriteLine();
            // Console.Write("Asal Sayılar ==> ");                
            // foreach (var item in asal)
            // {
            // Console.Write(item+" ");                
            // }
            //  //SORU 1 SONU

            // //SORU 2
            // int[] x = new int[20];
            // int y = 0;
            // for (int i = 0; i < x.Length; i++)
            // {
            //     Console.WriteLine("{0}. sayıyı gir ",i+1);
            //     x[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // for (int i = 0; i < x.Length; i++)
            // {
            //     for (int j = i; j < x.Length; j++)
            //     {
            //         if (x[i] > x[j])
            //         {
            //         y = x[j];
            //         x[j] = x[i];   
            //         x[i] = y;
            //         }
            //     }
            // }
            // Console.WriteLine("En küçükler ==> "+x[0]+" "+x[1]+" "+x[2]);
            // Console.WriteLine("En büyükler ==> "+x[17]+" "+x[18]+" "+x[19]);
            // int kort = (x[0]+x[1]+x[2])/3;
            // Console.WriteLine("Küçükler Ortalaması ==> "+kort);
            // int bort = (x[17]+x[18]+x[19])/3;
            // Console.WriteLine("Küçükler Ortalaması ==> "+bort);
            // //SORU 2 SONU

            // //SORU 3
            //     ArrayList c = new ArrayList(); 
            // string cumle = Console.ReadLine();
            // foreach (char item in cumle.ToCharArray())
            // {
            //     if (item == 'a' || item == 'e' || item == 'o' || item == 'u' || item == 'i')
            //     {
            //         c.Add(item);
            //     }
            // }
            //     Console.Write("Tüm sesli harfler ==> ");
            // foreach (var item in c)
            // {
            //     Console.Write(item+" ");
            // }
            // //SORU 3 SONU

            Console.ReadKey();
        }

    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
