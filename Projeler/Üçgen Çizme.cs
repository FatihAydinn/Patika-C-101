using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("#");

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                if (i == n)
                {
                    System.Console.Write("#"); // son satır son elemanı eksik kalmaması için
                }
            }
            //Console.ReadKey();
        }
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
