using System;
using System.Collections;

namespace csharp
{
    class PointClass   
    {
        int point = 0;
        double totalvotes = 0 ;
        double voterate = 0,  totalpoints = 0;
        public void BilimKurgu()
        {
            Console.WriteLine("\nBilim Kurgu kategorisi için veriler:");
            Console.WriteLine("Toplam oy sayısı: "+ (totalvotes = 13));
            Console.WriteLine("Toplam puan: " + (totalpoints = 121));
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = totalpoints/totalvotes)));
            point:
            Console.Write("Puanınızı girin(1-10): ");
            point = Convert.ToInt32(Console.ReadLine());
            if (point > 10 || point <= 0)
            {
                Console.WriteLine("Girilen değer geçersizdir.");
                goto point;
            }
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = (totalpoints+point)/(totalvotes+1)))+"\nŞeklinde güncellenmiştir");
        }
        public void Macera()
        {
            Console.WriteLine("\nMacera kategorisi için veriler:");
            Console.WriteLine("Toplam oy sayısı: "+ (totalvotes = 7));
            Console.WriteLine("Toplam puan: " + (totalpoints = 64));
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = totalpoints/totalvotes)));
            point:
            Console.Write("Puanınızı girin(1-10): ");
            point = Convert.ToInt32(Console.ReadLine());
            if (point > 10 || point <= 0)
            {
                Console.WriteLine("Girilen değer geçersizdir.");
                goto point;
            }
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = (totalpoints+point)/(totalvotes+1)))+"\nŞeklinde güncellenmiştir");
        }
        public void Korku()
        {
            Console.WriteLine("\nKorku kategorisi için veriler:");
            Console.WriteLine("Toplam oy sayısı: "+ (totalvotes = 3));
            Console.WriteLine("Toplam puan: " + (totalpoints = 24));
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = totalpoints/totalvotes)));
            point:
            Console.Write("Puanınızı girin(1-10): ");
            point = Convert.ToInt32(Console.ReadLine());
            if (point > 10 || point <= 0)
            {
                Console.WriteLine("Girilen değer geçersizdir.");
                goto point;
            }
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = (totalpoints+point)/(totalvotes+1)))+"\nŞeklinde güncellenmiştir");
        }
        public void Komedi()
        {
            Console.WriteLine("\nKomedi kategorisi için veriler:");
            Console.WriteLine("Toplam oy sayısı: "+ (totalvotes = 9));
            Console.WriteLine("Toplam puan: " + (totalpoints = 44));
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = totalpoints/totalvotes)));
            point:
            Console.Write("Puanınızı girin(1-10): ");
            point = Convert.ToInt32(Console.ReadLine());
            if (point > 10 || point <= 0)
            {
                Console.WriteLine("Girilen değer geçersizdir.");
                goto point;
            }
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = (totalpoints+point)/(totalvotes+1)))+"\nŞeklinde güncellenmiştir");
        }
        public void Romantik()
        {
            Console.WriteLine("\nRomantik kategorisi için veriler:");
            Console.WriteLine("Toplam oy sayısı: "+ (totalvotes = 1));
            Console.WriteLine("Toplam puan: " + (totalpoints = 1));
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = totalpoints/totalvotes)));
            point:
            Console.Write("Puanınızı girin(1-10): ");
            point = Convert.ToInt32(Console.ReadLine());
            if (point > 10 || point <= 0)
            {
                Console.WriteLine("Girilen değer geçersizdir.");
                goto point;
            }
            Console.WriteLine(String.Format("Puan oranı: 10/{0:0.0}",(voterate = (totalpoints+point)/(totalvotes+1)))+"\nŞeklinde güncellenmiştir");
        }
    }
}