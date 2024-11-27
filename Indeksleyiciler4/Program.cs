namespace Indeksleyiciler4
{
    using System;

    class Otopark
    {
        private string[,] katlar = new string[3, 10]; // 3 kat, her katta 10 park yeri

        public string this[int kat, int parkYeri]
        {
            get
            {
                if (kat < 0 || kat >= 3 || parkYeri < 0 || parkYeri >= 10)
                    return "Geçersiz park alanı!";
                return katlar[kat, parkYeri] ?? "Empty"; // Eğer boşsa "Empty" döner
            }
            set
            {
                if (kat < 0 || kat >= 3 || parkYeri < 0 || parkYeri >= 10)
                    Console.WriteLine("Geçersiz park alanı! Araç atanamadı.");
                else
                    katlar[kat, parkYeri] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Otopark otopark = new Otopark();

            otopark[0, 1] = "34XYZ12"; // İlk kat, ikinci yere plaka ekleme
            Console.WriteLine(otopark[0, 1]); // Çıktı: 34XYZ12
            Console.WriteLine(otopark[1, 5]); // Çıktı: Empty
            Console.WriteLine(otopark[5, 5]); // Çıktı: Geçersiz park alanı!
        }
    }

}
