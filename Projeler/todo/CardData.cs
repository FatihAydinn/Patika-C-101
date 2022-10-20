using System;
namespace todo 
{
    class CardData : Board
    {
        private static List<Board> todolist;
        static CardData()
        {
            todolist = new List<Board>();
            todolist.Add(new Board(){Titles = "Ders", Contents = "Matematik",Persons = "Ahmet",Sizes = "X",});
        }
        public static List<Board> Boards
        {
            get { return todolist; }
        }
    }
        class CardData1 : Board
    {
        private static List<Board> inprogresslist;
        static CardData1()
        {
            inprogresslist = new List<Board>();
            inprogresslist.Add(new Board(){Titles = "Spor", Contents = "Yüzme",Persons = "Fatih",Sizes = "XL",});
        }
        public static List<Board> Boards
        {
            get { return inprogresslist; }
        }
    }
        class CardData2 : Board
    {
        private static List<Board> donelist;
        static CardData2()
        {
            donelist = new List<Board>();
            donelist.Add(new Board(){Titles = "Kitap", Contents = "Bir Bilim Adamının Romanı",Persons = "Aydın",Sizes = "S",});
        }
        public static List<Board> Boards
        {
            get { return donelist; }
        }
    }
}