using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "ÖZER";
            musteri1.MusteriTel = 01245;
            musteri1.MusteriAdres = "İstanbul";
            musteri1.MusteriBakiye = 1250.50;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Özer";
            musteri2.MusteriSoyad = "AHMET";
            musteri2.MusteriTel = 054321;
            musteri2.MusteriAdres = "Ankara";
            musteri2.MusteriBakiye = 3210.25;

            // Müşteri Manager Metodu
            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("******* Müşteri Ekleme Metodu **********");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("*************************");

            Console.WriteLine("******* Müşteri Silme Metodu **********");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("*************************");

            Console.WriteLine("******* Müşteri Liteleme Metodu **********");
            Musteri[] musteriliste = new Musteri[] { musteri1, musteri2 };
            musteriManager.MusteriListe(musteriliste);
            Console.WriteLine("*************************");


            Console.ReadLine();
        }
    }
}
