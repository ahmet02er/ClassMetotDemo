using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri ekle)
        {
            Console.WriteLine("Müşteri Eklendi :" + ekle.MusteriAd + " " + ekle.MusteriSoyad);
        }
        public void MusteriSil(Musteri sil)
        {
            Console.WriteLine("Müşteri Silindi :" + sil.MusteriAd + " " + sil.MusteriSoyad);
        }
        public void MusteriListe(Musteri [] liste)
        {
            Console.WriteLine("Müşteri Listesi:");
            Console.WriteLine("************************");
            foreach (Musteri muteriler in liste)
            {
                Console.WriteLine("Id:" + muteriler.Id);
                Console.WriteLine("Ad: " +muteriler.MusteriAd);
                Console.WriteLine("Soyad:" + muteriler.MusteriSoyad);
                Console.WriteLine("Telefon:" + muteriler.MusteriTel);
                Console.WriteLine("Adres:" + muteriler.MusteriAdres);
                Console.WriteLine("Bakiye:" + muteriler.MusteriBakiye);
                Console.WriteLine("****************************");
            }
        }
    }
}
