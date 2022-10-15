using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        string str = Console.ReadLine();
        for (int i = str.Length-1; i >= 0 ; i--)
        {
            Console.Write(str[i]);
        }
        Console.ReadKey();
        }
    }
}
