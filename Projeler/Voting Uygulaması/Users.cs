using System;
using System.Collections;

namespace csharp
{
    class UserClass : DataClass
    {
        public void User()
        {
        Console.Write("Kullanıcı adı gir: ");
        string user = Console.ReadLine();
        int count = 0,count2 = 0;
        List<string> UserList = new List<string>();
        UserList.Add("Ahmet");
        UserList.Add("Fatih");
        UserList.Add("Aydın");
        foreach (var item in UserList)
        {
            count2++;
            if (item == user)
            {
                Console.WriteLine("Hoşgeldin "+user);
                break;
            }
            else
            count++;
        }
        if (count == count2)
        {
            Console.WriteLine(user+" adında bir kullanıcı bulunamadı.");
            Console.Write("Kayıt olmak için kullanıcı adını gir: ");
            user = Console.ReadLine();
            UserList.Add(user);
            Console.WriteLine("Hoşgeldin "+user);
            
        }
        }
    }
}