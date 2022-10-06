using System;
namespace konsolprog
{
    class WhileForeach
    {
        public static void Main(string[] args)
        {
            int i = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int total = 0;
            while (count <= i)
            {
            total += count; 
            count++;
            }
            Console.WriteLine(total/i);
        
            char c = 'c';
            while (c < 'k')
            {
                c++;
                count ++;
            }
            Console.WriteLine("k ile c arasında "+count+" tane harf vardır");

            string[] araba = {"BMW","KIA","Mercedes","Nissan"};
            foreach (var item in araba)
            {
                if (item == "Nissan")
                {
                Console.WriteLine(araba[3]);
                }
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");