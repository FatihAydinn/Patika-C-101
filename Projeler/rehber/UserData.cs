using System;
using System.Collections;

namespace konsolprog
{
    class UserData : User
    {
    public class Data { 
    public class PersonData
    {
        private static List<User> phoneList;
        static PersonData()
        {
            phoneList = new List<User>();
            phoneList.Add(new User(){UserName ="Ahmet",  UserNumber="01",});
            phoneList.Add(new User(){UserName ="Fatih",  UserNumber="02",});
            phoneList.Add(new User(){UserName ="Aydın",  UserNumber="03",});
        }
        public static List<User> PhoneList
        {
            get { return phoneList; }
        }
    }
    public Data()
    {
    }
    }
    }
}