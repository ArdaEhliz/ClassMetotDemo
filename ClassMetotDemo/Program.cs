using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Adi = "Ahmet",
                Soyadi = "Ehliz",
                DogumTarihi = "01.01.1980"
                TcKimlikNumarasi = "10111111111",
                HesapNo = 0897 - 12345678 - 5001 - 5002
            };
            Musteri musteri2 = new Musteri
            {
                Adi = "Engin",
                Soyadi = "Demiroğ",
                DogumTarihi = "01.01.1991"
                TcKimlikNumarasi = "10111111112",
                HesapNo = 0254 - 12345678 - 3591 - 7561
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle
            {

            }
        }
    }
}
