using System;
namespace konsolprog
{
    class RekursifveExtensionMetotlar
    {
        public static void Main(string[] args)
        {
           int result = 1;
           for (int i = 1 ; i < 5 ; i++)
           {
            result *= 3;
           }
        Islemler instance = new();
        int sayi = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(instance.Expo(sayi));
//---------------

        string ifade = "Merhaba Dünya";
        Console.WriteLine(ifade.RemovewhiteSpaceS());
        Console.WriteLine(ifade.Makelowertase());
        Console.WriteLine(ifade.RemovewhiteSpaceS());
        int[] dizi = {2,6,5,7,8};
        dizi.SortArray();
        Console.WriteLine(dizi.SortArray());
        dizi.EkranaYazdir();
        Console.ReadKey();
        }
        public class Islemler
        {
            public int Expo(int number)
            {
                if(number == 1)
                return (number);
                return number * Expo(number-1);
            }
        }
    }
        
         public static class Extension
        {
        public static string RemovewhiteSpaceS(this string param) { 
        string[] dizi = param.Split (" ");
        return string.Join("•",dizi); 
        }

         public static string MakeUpperCase(this string param){
        return param.ToUpper(); 
         } 

        public static string Makelowertase(this string param) {
        return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
        Array.Sort(param); 
        return param;
        }
        public static void EkranaYazdir(this int[] param) {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }
     }
}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
