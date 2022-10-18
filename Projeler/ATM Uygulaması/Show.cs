using System;
using System.Collections;

namespace csharp
{
    class ShowClass : DataClass
    {
        UserClass user = new UserClass();
        public void Show()
        {
            int wrong = 0;
            show:
            int count = 0;
            System.Console.Write("\nKullanıcı adı girin: ");
            string username = Console.ReadLine();
            System.Console.Write("Şifre girin: ");
            string pass = Console.ReadLine();
            if (wrong == 3)
            {
                Console.WriteLine("Çok sayıda yanlış işlemde bulundunuz \nUygulamadan çıkış yapılıyor");
                goto son;
            }
            else
            {
            foreach (var item in UserClass.Datas)
            {
                if (username == item.Username && pass == item.Password)
                {
                    Console.WriteLine("Hoşgeldin " + item.Username + " Yapılacak işlemi seç");
                    goto basla;
                }
                else
                count++;
                if (count == 3)
                {
                System.Console.WriteLine("\nGeçersiz kullanıcı adı veya şifre\nLütfen tekrar deneyiniz");
                wrong++;
                goto show;                    
                }
            }
            }
            basla:
            int cek = 0,yatir = 0;
            Console.WriteLine("(1) Para Çek");
            Console.WriteLine("(2) Para Yükle");
            Console.WriteLine("(3) Bakiye Görüntüle");
            Console.WriteLine("(0) Makbuz Yazdır");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                {
                    Console.Write("Çekilecek para miktarını gir: ");
                    cek = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in UserClass.Datas)
                    {
                        if (username == item.Username)
                        {
                            if (cek > item.Balance)
                                System.Console.WriteLine("Yetersiz Bakiye");                            
                            else
                            item.Balance -= cek;
                        }
                    }
                    goto basla;
                }
                case 2:
                {
                    Console.Write("Yatırılacak para miktarını gir: ");
                    yatir = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in UserClass.Datas)
                    {
                        if (username == item.Username)
                        {
                            item.Balance += yatir;
                        }
                    }
                    goto basla;
                }
                case 3:
                {
                    foreach (var item in UserClass.Datas)
                    {
                        if (item.Username == username)
                        {
                            Console.WriteLine("Hesabınızda "+item.Balance+" TL bulunmaktadır.");
                        }
                    }
                    goto basla;
                }
                case 0:
                {
                    string makbuz;
                    foreach (var item in UserClass.Datas)
                    {
                        if (item.Username == username)
                        {
                            makbuz = "İşlem yapan kullanıcı: "+item.Username +"\nGüncel Bakiye: " + item.Balance +"\nYanlış yapılan giriş sayısı: "+ wrong;
                            System.IO.File.WriteAllText(@"c:\Users\Fatih\Desktop\text.txt",makbuz);
                        }
                    }
                    break;
                }
            }
            son:
            Console.WriteLine();
        }
    }
}