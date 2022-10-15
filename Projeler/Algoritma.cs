using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        string algoritma = Console.ReadLine();
        string[] domma = algoritma.Split(",");
        int n =  Convert.ToInt32(domma[1]);
        Console.WriteLine(algoritma.Remove(n,1));
        Console.ReadKey();
        }
    }
}
