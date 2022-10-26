using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    class ListClass
    {
        public class PersonData
        {
        private static List<Data> DataList;
        static PersonData()
        {
        DataList = new List<Data>();
        DataList.Add(new Data(){Sayi = 14});
        DataList.Add(new Data(){Sayi = 24});
        DataList.Add(new Data(){Sayi = 34});
        DataList.Add(new Data(){Sayi = 44});
        }
        public static List<Data> dataList
        {
            get { return DataList;}
        }
        }
    }
}
