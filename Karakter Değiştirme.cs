using System;
using System.Collections;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
        Console.Write("Cümle gir: ");
        string[] str = Console.ReadLine().Split();
        foreach (var item in str)
        {
        char[] arr = item.ToCharArray();
        char tut = arr[0];
        arr[0] = arr[arr.Length - 1];
        arr[arr.Length - 1] = tut;
        string s = "";
        foreach (var c in arr)
        s += c.ToString();
        System.Console.Write(s+" ");
        }        
        Console.ReadKey();
        }
    }
}
