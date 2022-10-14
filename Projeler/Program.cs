using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int s1 = 0;
            int s2 = 1;
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            int total = 0;
            double avarage = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                total = s1+s2;
                s1 = s2;
                s2 = total;
                array[i] = total;
            Console.WriteLine(total);
            }
            foreach (var item in array)
            {
                avarage += item;
            }
            System.Console.WriteLine(avarage/n);
        }
    }
}
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
