using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    class ShowClass : AddClass
    {
        public void Show()
        {
        Data data = new Data();
        AddClass add = new AddClass();
        foreach (var item in ListClass.PersonData.dataList)
        {
            System.Console.WriteLine(item.Sayi);
        }
        }
    }
}