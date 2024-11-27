namespace Indeksleyiciler1
{
    using System;

    class Kitaplik
    {
        private string[] kitaplar = { "C# Rehberi", "Algoritmalar", "Veri Yapıları", "Yapay Zeka" };

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= kitaplar.Length)
                    return "Geçersiz indeks! Kitap bulunamadı.";
                return kitaplar[index];
            }
            set
            {
                if (index < 0 || index >= kitaplar.Length)
                    Console.WriteLine("Geçersiz indeks! Kitap atanamadı.");
                else
                    kitaplar[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Kitaplik kitaplik = new Kitaplik();

            Console.WriteLine(kitaplik[1]); // Çıktı: Algoritmalar
            kitaplik[1] = "Yeni Algoritmalar"; // Kitap ismini değiştiriyor
            Console.WriteLine(kitaplik[1]); // Çıktı: Yeni Algoritmalar
            Console.WriteLine(kitaplik[5]); // Çıktı: Geçersiz indeks! Kitap bulunamadı.
        }
    }

}
