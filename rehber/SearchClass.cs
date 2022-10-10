using System;
using System.Collections;

namespace konsolprog
{
    class SearchClass:UserData
    {
        public void Search()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**********************************************");
        Console.WriteLine();
        Console.WriteLine("İsime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        int secim = Convert.ToInt32(Console.ReadLine());
        switch (secim)
        {
            case 1:
            {
            Console.WriteLine("Aranacak kişinin ismini girin:");
            string search = Console.ReadLine();
            foreach (var item in Data.PersonData.PhoneList)
            {
            if (search == item.UserName)
            {
            Console.WriteLine(search + ": isimli kişinin bilgileri");
            Console.WriteLine("İsim: "+item.UserName);
            Console.WriteLine("Numara: "+item.UserNumber);
            }
            }
            break;
            }
            case 2:
            {
            Console.WriteLine("Aranacak kişinin ismini girin:");
            string search = Console.ReadLine();
            foreach (var item in Data.PersonData.PhoneList)
            {
            if (search == item.UserNumber)
            {
            Console.WriteLine(search + ": numaralı kişinin bilgileri");
            Console.WriteLine("İsim: "+item.UserName);
            Console.WriteLine("Numara: "+item.UserNumber);
            }
            }
            break;
            }
        }  
    }
    }
}