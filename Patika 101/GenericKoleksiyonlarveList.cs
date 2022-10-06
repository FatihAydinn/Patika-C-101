using System;
namespace konsolprog
{
    class GenericKoleksiyonlarveList
    {
        public static void Main(string[] args)
        { 
    
        List<int> sayiList = new List<int>();
        sayiList.Add(11);
        sayiList.Add(12);
        sayiList.Add(13);
        List<string> sebze = new List<string>();
        sebze.Add("domatez");
        sebze.Add("biber");
        sebze.Add("patlıcan");

        Console.WriteLine(sebze.Count);
        
        foreach (var item in sebze)
        {
            Console.WriteLine(item);
        }
        sayiList.ForEach(x=>Console.WriteLine(x));
        
        sayiList.Remove(12);
        sayiList.RemoveAt(0);
        sayiList.ForEach(x=>Console.WriteLine(x));

        if (sayiList.Contains(13))
        Console.WriteLine("evet 13");

        Console.WriteLine(sebze.BinarySearch("biber"));

        string[] mfo = {"mahzar","fuat","ozkan"};
        List<string> mfolist = new List<string>(mfo);
        mfolist.ForEach(x=>Console.WriteLine(x));
        mfolist.Clear();

        List<Kullanicilar> kullaniciList = new List<Kullanicilar>();
        Kullanicilar kullanici1 = new Kullanicilar();
        kullanici1.Isim = "Fatih";
        kullanici1.Soyisim = "Aydın";
        kullanici1.Yas = 22;
        Kullanicilar kullanici2 = new Kullanicilar();
        kullanici2.Isim = "Pamir";
        kullanici2.Soyisim = "On";
        kullanici2.Yas = 7;
        kullaniciList.Add(kullanici1);
        kullaniciList.Add(kullanici2);
        // kullaniciList.ForEach(x=>Console.WriteLine(x));

        foreach (var kullanici in kullaniciList)
        {
            Console.WriteLine(kullanici.Isim);
            Console.WriteLine(kullanici.Soyisim);
            Console.WriteLine(kullanici.Yas);
        }
        Console.ReadKey();
        }
     
     public class Kullanicilar
     {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value;}
        public string Soyisim { get => soyisim; set => soyisim = value;}
        public int Yas { get => yas; set => yas = value;}
     }

     }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
