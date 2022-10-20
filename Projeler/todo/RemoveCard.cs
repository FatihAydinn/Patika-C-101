using System;
namespace todo 
{
    class RemoveCard : Board
    {
        public void Remove()
        {
        //ShowCard show = new ShowCard();
        CardData data = new CardData();
        Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
        Console.WriteLine("Lütfen kart başlığını yazınız:");
        string remove = Console.ReadLine();
        int count = 0;
        foreach (var item in CardData.Boards)
        {
            if (remove == item.Titles)
            {
                CardData.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ "olan kart başarıla silinmiştir");
                break;
            }
            else count++;
        }
        count = 0;
        foreach (var item in CardData1.Boards)
        {
            if (remove == item.Titles)
            {
                CardData1.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ "olan kart başarıla silinmiştir");

                break;
            }
            else count++;
        }
        count = 0;
        foreach (var item in CardData2.Boards)
        {
            if (remove == item.Titles)
            {
                CardData2.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ "olan kart başarıla silinmiştir");
                break;
            }
            else count++;
        }
        
        }
    }
}