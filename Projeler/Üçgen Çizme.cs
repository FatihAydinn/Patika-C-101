using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
            Console.WriteLine("");
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("#");
            }
            }
            //------
            Console.WriteLine(" ");
            for (int i = n; i >= 0; i--)
            {
            Console.WriteLine("");
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            }
            //Console.ReadKey();
        }
    }
}


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
