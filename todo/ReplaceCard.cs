using System;
namespace todo 
{
    class ReplaceCard : Board
    {
        public void Replace()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız: ");
            string replace = Console.ReadLine();
            Program program = new Program();
            int count = 0;
            foreach (var item in CardData.Boards)
            {
                if (replace == item.Titles)
                {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("Line        : TODO");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:"); 
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choose = Convert.ToInt16(Console.ReadLine());
                if (choose == 1)
                {
                CardData.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 2)
                {
                CardData1.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 3)
                {
                CardData2.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                break;
                }
                else count++;
            }
            count = 0;
                foreach (var item in CardData1.Boards)
            {
                if (replace == item.Titles)
                {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("Line        : IN PROGRESS");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:"); 
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choose = Convert.ToInt16(Console.ReadLine());
                if (choose == 1)
                {
                CardData.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData1.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 2)
                {
                CardData1.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData1.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 3)
                {
                CardData2.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData1.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                break;
                }
                else count++;
            }
            count = 0;
            foreach (var item in CardData2.Boards)
            {
                if (replace == item.Titles)
                {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine("Başlık      : "+item.Titles);
                Console.WriteLine("İçerik      : "+item.Contents);
                Console.WriteLine("Atanan Kişi : "+item.Persons);
                Console.WriteLine("Büyüklük    : "+item.Sizes);
                Console.WriteLine("Line        : DONE");
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:"); 
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int choose = Convert.ToInt16(Console.ReadLine());
                if (choose == 1)
                {
                CardData.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData2.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 2)
                {
                CardData1.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData2.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                if (choose == 3)
                {
                CardData2.Boards.Add(new Board(){Titles = item.Titles , Contents = item.Contents, Persons = item.Persons, Sizes = item.Sizes});
                CardData2.Boards.RemoveAt(count);
                Console.WriteLine("Başlığı: "+item.Titles+ " olan kart başarıla taşınmıştır.");
                goto end;
                }
                break;
                }
                else count++;
            }
                end:
                Console.WriteLine();
        }

    }
}