using System;
namespace konsolprog
{
    class ForLoop
    {
        public static void Main(string[] args)
        {
             Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            int tekToplam = 0, ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                {
                    tekToplam += i;
                }

                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek sayilarin toplami: " + tekToplam + "\nCift sayilarin toplami: " + ciftToplam);

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
        }

        }
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
