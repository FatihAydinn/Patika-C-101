using System;
namespace konsolprog
{
    class Try_catch_finally
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiginiz sayi: " + sayi);
                // int i = int.Parse(null);
                // int i = int.Parse("deneme");
                int i = int.Parse("-200000000000");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Bos deger girdiniz...");
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Veri tipi uygun degil...");
                Console.WriteLine(e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz...");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Islem basariyla tamamlandi.");
            } 
        }
    }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");