using System;
using System.Collections;

namespace konsolprog
{
    class ShowClass : UserData
    {
    public void Show()
    {
        int count = 0;
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**********************************************");
        Console.WriteLine();
        foreach (User item in Data.PersonData.PhoneList)
        {
            count++;
            Console.WriteLine(count+") "+ item.UserName+" "+item.UserNumber);
        }
    }
    }
}