using System;
using System.Collections;

namespace konsolprog
{
    class AddClass : UserData
    {

    public void Add()
    {
        Console.WriteLine("Yeni eklenecek kişinin ismini gir:");
        string newname = Console.ReadLine();
        System.Console.WriteLine("Yeni eklenecek kişinin numarasını gir:");
        string newnumber = Console.ReadLine();
        Data.PersonData.PhoneList.Add(new User(){UserName = newname,UserNumber = newnumber});
    }
    }
}