namespace Indeksleyiciler3
{
    using System;

    class SatrancTahtasi
    {
        private string[,] tahtadakiTaslar = new string[8, 8]; // 8x8 satranç tahtası

        public string this[int satir, int sutun]
        {
            get
            {
                if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                    return "Geçersiz kare!";
                return tahtadakiTaslar[satir, sutun] ?? "Boş"; // Eğer taş yoksa "Boş" döner
            }
            set
            {
                if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                    Console.WriteLine("Geçersiz kare! Taş atanamadı.");
                else
                    tahtadakiTaslar[satir, sutun] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SatrancTahtasi tahtasi = new SatrancTahtasi();

            tahtasi[0, 0] = "Kale"; // İlk kareye kale yerleştirme
            Console.WriteLine(tahtasi[0, 0]); // Çıktı: Kale
            Console.WriteLine(tahtasi[1, 1]); // Çıktı: Boş
            Console.WriteLine(tahtasi[9, 9]); // Çıktı: Geçersiz kare!
        }
    }

}
