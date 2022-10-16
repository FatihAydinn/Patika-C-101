using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Write("Sayı limitini belirleyin : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] sayi = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1)+". değeri gir: ");
            sayi[i] = Convert.ToInt32(Console.ReadLine());
        }
        //int[] kucuk = new int[null]; 
        List<int> kucuk = new List<int>();
        List<int> buyuk = new List<int>();
        double sayi1 = 0 , sayi2 = 0;
        foreach (var item in sayi)
        {
            if (item > 67)
            {
                buyuk.Add(item);
            }
            else if(item <= 67)
            {
                kucuk.Add(item);
            }
        }
        foreach (var item in buyuk)
        {
            sayi1 +=  Math.Pow((Math.Abs(67-item)),2);
        }
        foreach (var item in kucuk)
        {
            sayi2 += (67-item);
        }
        Console.WriteLine("Büyük sayılar ==> "+sayi1);
        Console.WriteLine("Küçük sayılar ==>"+sayi2);
        Console.ReadKey();
        }
    }
}
