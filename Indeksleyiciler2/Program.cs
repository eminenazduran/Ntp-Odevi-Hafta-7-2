namespace Indeksleyiciler2
{
    using System;
    using System.Collections.Generic;

    class OgrenciNotSistemi
    {
        private Dictionary<string, int> notlar = new Dictionary<string, int>();

        public int this[string dersAdi]
        {
            get
            {
                if (!notlar.ContainsKey(dersAdi))
                    throw new KeyNotFoundException($"Ders bulunamadı: {dersAdi}");
                return notlar[dersAdi];
            }
            set
            {
                notlar[dersAdi] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            OgrenciNotSistemi notSistemi = new OgrenciNotSistemi();
            notSistemi["Matematik"] = 90; // Not ekleme
            notSistemi["Fizik"] = 85;

            Console.WriteLine($"Matematik: {notSistemi["Matematik"]}"); // Çıktı: Matematik: 90
            Console.WriteLine($"Fizik: {notSistemi["Fizik"]}"); // Çıktı: Fizik: 85

            try
            {
                Console.WriteLine(notSistemi["Kimya"]); // Hata: Ders bulunamadı
            }
            catch (KeyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
