using System;
namespace konsolprog
{
    class ArrayMetotlari
    {
        public static void Main(string[] args)
        {
         int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,12));
            
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,10);
            sayiDizisi[8] = 99;
            sayiDizisi[9] = 599;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        // int bb = Convert.ToInt32(Console.ReadLine());

        }
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");