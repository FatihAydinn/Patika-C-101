using System;
using System.Collections;

namespace konsolprog
{
    class User
    { 
        private string userName;
        private string userNumber;

        public string UserName 
        { 
            get => userName; 
            set => userName = value; 
        }
        public string UserNumber 
        {
            get => userNumber;
            set => userNumber = value; 
        }
    }
}