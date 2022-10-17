using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Write("Metin gir: ");
        string str = Console.ReadLine();
        int count = 0;
        bool sonuc = false;
        foreach (var item1 in str.Split(' '))
        {
            sonuc = false;
            count = 0;
        foreach (var item in item1)
        {
            if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö' || item == 'u' || item == 'ü')
            {
            count = 0;
               
            }
            else 
            {
             count++;
                if (count == 2)
                {
                    sonuc = true;
                    goto son;                    
                }
           }
        }
        son:
        Console.Write(sonuc+" ");
        }
        Console.ReadKey();
        }
    }
}
