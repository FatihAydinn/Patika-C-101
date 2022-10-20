using System;
namespace todo 
{
    class ShowCard : Board
    {
        public void Show()
        {
                Console.WriteLine("TODO Line");
                Console.WriteLine("************************");
            foreach (var item in CardData.Boards)
            {
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("-");
            }
                Console.WriteLine("IN PROGRESS Line");
                Console.WriteLine("************************");
            foreach (var item in CardData1.Boards)
            {
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("-");
            }
                Console.WriteLine("DONE Line");
                Console.WriteLine("************************");
            foreach (var item in CardData2.Boards)
            {
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("-");
            }
        }
    }
}