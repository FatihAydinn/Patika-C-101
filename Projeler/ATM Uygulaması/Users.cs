using System;
using System.Collections;

namespace csharp
{
    class UserClass:DataClass
    {
        

        private static List<DataClass> UserList;
        static UserClass()
        {
            UserList = new List<DataClass>();
            UserList.Add(new DataClass(){Username = "Ahmet",Password = "1234",Balance = 50});
            UserList.Add(new DataClass(){Username = "Fatih",Password = "2345",Balance = 70});
            UserList.Add(new DataClass(){Username = "Aydın",Password = "3456",Balance = 90});
        }
        public static List<DataClass> Datas
        {
            get {return UserList;}
        }

    }
}
