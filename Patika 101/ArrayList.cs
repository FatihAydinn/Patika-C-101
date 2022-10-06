using System;
using System.Collections;

namespace konsolprog
{
    class ArrayListt
    {
        public static void Main(string[] args)
        { 
            ArrayList list = new ArrayList();

    // // ArrayList'e veri atamak
    // list.Add("Ayşe");
    // list.Add(2);
    // list.Add(true);
    // list.Add('A');

    // // içerisindeki verilere erişim
    // Console.WriteLine(list[1]);
    // foreach (var item in list)
    // {
    //   Console.WriteLine(item);
    // }

    // string[] colors = {"Kırmızı", "Sarı", "Yeşil"};
    List<int> numbers = new List<int>() {1, 8, 3, 7, 9, 92, 5};
    // list.AddRange(colors);
    list.AddRange(numbers);
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    list.Sort();
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    Console.WriteLine(list.BinarySearch(9));

    list.Reverse(); 
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    list.Clear();
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

                Console.ReadKey();
            }
        }
    }
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
