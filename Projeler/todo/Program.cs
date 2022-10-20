using System;
namespace todo 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            basla:
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(0) Çıkış");
            int secim = Convert.ToInt32(Console.ReadLine());
            ShowCard show = new ShowCard();
            AddCards add = new AddCards();
            RemoveCard remove = new RemoveCard();
            ReplaceCard replace = new ReplaceCard();
            switch (secim)
            {
                case 1:
                {
                    show.Show();
                }
                goto basla;
                case 2:
                {
                    add.Add();
                }
                goto basla;
                case 3:
                {
                    remove.Remove();
                }
                goto basla;
                case 4:
                {
                    replace.Replace();
                }
                goto basla;
                case 0:
                {
                    Console.WriteLine("Programdan çıkış yapmak için herhangi bir tuşa basın");
                    Environment.ExitCode = 0;
                }
                break;
            }


            Console.ReadKey();
        }    
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");