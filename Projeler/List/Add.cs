using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    public class AddClass 
    {
    public void Add()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        ListClass.PersonData.dataList.Add(new Data(){Sayi = x});
    }
    }
}