using System;
using System.Collections;

namespace konsolprog
{
    class RemoveClass : UserData
    {
    public void Remove()
    {
        System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını giriniz:");
        string remove = Console.ReadLine();
        int count = 0;
         foreach (User item in Data.PersonData.PhoneList)
        {
           if(remove == item.UserName){
            Data.PersonData.PhoneList.RemoveAt(count);
            break;}
           else count++;
        }
    }
    }
}