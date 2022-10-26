using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        Data data = new Data();
        AddClass add = new AddClass();
        ShowClass show = new ShowClass();
        add.Add();
        show.Show();
        Console.ReadKey();
        }
    }
}
