using System;
namespace todo 
{
    class AddCards : Board
    {
            public enum Sizess
            {
                XS=1,
                S,
                M,
                L,
                XL
            }
        public void Add()
        {
            Sizess sizes = new Sizess();
            Console.WriteLine("Başlık Giriniz                                  :");
            string title = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz                                  :");
            string content = Console.ReadLine();
            size0:
            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int size = Convert.ToInt32(Console.ReadLine());
            if (size > 5 || size <= 0)
            {
                Console.WriteLine("Lütfen beliritlen değerler arasında değer girin");
                goto size0;
            }
            int count = 0;
            string stringsize="";
            foreach (Sizess item in (Sizess[]) Enum.GetValues(typeof(Sizess)))
            {
                count++;
                if (size == count)
                {
                stringsize = item.ToString();
                }
            }           
            person0:
            Console.WriteLine("Kişi Seçiniz ->  (1),(2),(3)                    :");
            int person = Convert.ToInt32(Console.ReadLine());
            if (person > 4 || person <= 0)
            {
                Console.WriteLine("Lütfen beliritlen değerler arasında değer girin");
                goto person0;
            }
            Dictionary<int,string> person1 = new Dictionary<int, string>();
            person1.Add(1,"Ahmet");
            person1.Add(2,"Fatih");
            person1.Add(3,"Aydın");
            CardData.Boards.Add(new Board(){Titles = title, Contents = content, Sizes = stringsize, Persons = person1[person]});
        }
    }
}