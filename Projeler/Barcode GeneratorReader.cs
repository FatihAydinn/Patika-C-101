using System;
using System.Collections;
using IronBarCode;

namespace csharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Yapılacak işlemi seç");
            Console.WriteLine("(1) Barkod oluştur");
            Console.WriteLine("(2) Barkod oku");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
            Console.Write("Barodu oluşturulacak metni gir: ");
            string barcode = Console.ReadLine();
            var myBarcode = BarcodeWriter.CreateBarcode(barcode,BarcodeEncoding.EAN8);
            myBarcode.ResizeTo(400, 200);
            myBarcode.SaveAsImage("myBarcode.jpeg");
            }
            else if (secim == 2)
            {
            BarcodeResult barcodeResult = BarcodeReader.QuicklyReadOneBarcode("myBarcode.jpeg");
            Console.WriteLine(barcodeResult.Text);
            }
            else
            Console.WriteLine("Geçersiz Seçenek");
        Console.ReadKey();
        }
    }
}
