using System;
using System.Collections.Generic;

class Program
{

    class Urun
    {
        public string Ad { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
    }

    
    static List<Urun> depo = new List<Urun>();
    static decimal kullaniciParasi = 1000m;
    static void Main(string[] args)
    {
        while (true)
        {
           
            Console.WriteLine(" 1) Ürün Satış");
            Console.WriteLine(" 2) Depodaki Ürünler");
            Console.WriteLine(" 3) bir şey almayacağım.");
            Console.Write("seçimin:");
            string secim = Console.ReadLine();

            switch (secim)
            {
                
                case "1":
                    UrunSatis();
                    break;
                case "2":
                   DepoyuGoruntule();
                    break;
                case "seçimin":
                    Console.WriteLine("satış yapılmadı");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }



    static void UrunSatis()
    {
        Console.WriteLine("\n=== Ürün Satış ===");
        DepoyuGoruntule();

        Console.Write("Satın almak istediğiniz ürün adı: ");
        string ad = Console.ReadLine();

        bool urunBulundu = false;

        for (int i = 0; i < depo.Count; i++)
        {
            if (depo[i].Ad == ad)
            {
                urunBulundu = true;

                Console.Write("Almak istediğiniz adet: ");
                int adet = int.Parse(Console.ReadLine());

                decimal toplamTutar = depo[i].BirimFiyat * adet;

                if (adet > depo[i].Adet)
                {
                    Console.WriteLine("Depoda yeterli ürün bulunmuyor. (Depo hatası)");
                }
                else if (toplamTutar > kullaniciParasi)
                {
                    Console.WriteLine("Yeterli bakiyeniz yok. (Bakiye hatası)");
                }
                else
                {
                    depo[i].Adet -= adet;
                    kullaniciParasi -= toplamTutar;
                    Console.WriteLine($"{ad} ürününden {adet} adet satın alındı. Kalan bakiye: {kullaniciParasi:C}");
                }
                break;
            }
        }

        if (!urunBulundu)
        {
            Console.WriteLine("Bu isimde bir ürün bulunamadı.");
        }
    }

    static void DepoyuGoruntule()
    {
        Console.WriteLine("\n=== Depodaki Ürünler ===");

        if (depo.Count == 0)
        {
            Console.WriteLine("Depo şu anda boş.");
            return;
        }

        for (int i = 0; i < depo.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Ürün: {depo[i].Ad}, Birim Fiyat: {depo[i].BirimFiyat:C}, Adet: {depo[i].Adet}");
        }
    }
}
