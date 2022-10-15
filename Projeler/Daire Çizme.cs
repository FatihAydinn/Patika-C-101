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
            for (int l = i; l < n; l++)
            Console.Write(" ");
            for (int j = 1; j < i; j++)
            Console.Write("#");
            for (int k = 1; k <= i; k++)
            Console.Write("#");
            Console.WriteLine(" ");
            }

            for (int i = n-1; i >= 1; i--)
            {
            for (int l = n; l > i; l--)
            Console.Write(" ");
            for (int j = 1; j < i; j++)
            Console.Write("#");
            for (int k = 1; k <= i; k++)
            Console.Write("#");
            Console.WriteLine(" ");
            }
        //Console.ReadKey();
        }
    }
}
