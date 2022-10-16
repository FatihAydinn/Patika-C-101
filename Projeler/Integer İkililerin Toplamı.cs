using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        basla:
        Console.Write("Sayı miktarını belirleyiniz : ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 1 || n <= 0)
        {
            Console.WriteLine("Girilen değer tek , 0 veya negatif olamaz");
            goto basla;
        }
        int[] sayi = new int[n];
        double[] total = new double[(n/2)];
        int j = 0;
        int k = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1)+". değeri girin: ");
            sayi[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 1; i <= n; i+=2)
        {
            if (sayi[i] == sayi[j])
            {
                total[k] = Math.Pow((sayi[i] + sayi[j]),2);
            }
            else
            total[k] = sayi[i] + sayi[j];
            k++;
            j+=2;
        }
        Console.Write("Sonuc ==> ");
        foreach (var item in total)
        {
            Console.Write(item +" ");
        }
        Console.ReadKey();
        }
    }
}
