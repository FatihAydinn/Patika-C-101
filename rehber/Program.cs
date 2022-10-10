using System;
using System.Collections;

namespace konsolprog
{
    class Program
    {
        public static void Main(string[] args)
        { 
          basla:
        Console.WriteLine();
        Console.WriteLine("Yapılacak işlemi Seçin;");
        Console.WriteLine();
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");
        Console.WriteLine("(0) Çıkış");
        int secim = Convert.ToInt16(Console.ReadLine());
        SearchClass search = new SearchClass();
        AddClass add = new AddClass();
        RemoveClass remove = new RemoveClass();
        UpdateClass update = new UpdateClass();
        ShowClass show = new ShowClass();
        switch (secim)
        {
            case 1:
            {
            add.Add();
            goto basla;
            }
            case 2:
            {
            remove.Remove();
            goto basla;
            }
            case 3:
            {
            update.Update();
            goto basla;
            }
            case 4:
            {
            
            show.Show();
            goto basla;
            }
            case 5:
            {
            search.Search();
            goto basla;
            }
            case 0:
            System.Console.WriteLine("Rehberden çıkış yapmak için herhangi bir tuşa basın");
            Environment.ExitCode = 0;
            break;            
            }
        Console.ReadKey();
        }
    }
}

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");