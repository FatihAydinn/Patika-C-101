using System;
using System.Collections;

namespace konsolprog
{
    class UpdateClass : UserData
    {
         public void Update()
    {
        Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını giriniz:");
        string update = Console.ReadLine();
        foreach (var item in Data.PersonData.PhoneList)
        {
            if (update == item.UserName)
            {
                Console.WriteLine(update+" kişininin yeni ismini girin ");
                string newname = Console.ReadLine();
                Console.WriteLine(update+" kişininin yeni numarasını girin ");
                string newnumber = Console.ReadLine();
                item.UserName = newname;
                item.UserNumber = newnumber;
            }
        }
    }
    }
}