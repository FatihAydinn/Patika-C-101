using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    class Data
    {
        int sayi;

        public int Sayi 
        { 
            get 
            {
                return sayi;
            }
            set 
            {
                sayi = value-10;
            }
        }
    }
}
