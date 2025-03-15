using System;

class Program
{
    // Dizi aynı türdeki verileri bir arada tutan bir yapıdır. Gerçek hayatta öğrenci listesi gibi düşünülebilinir.


    static void Main(string[] args)
    {
        int[] sayilar1 = new int[5];

        // Kullanıcıdan veri alma
        for (int i = 0; i < sayilar1.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            sayilar1[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Dizi elemanlarını ekrana yazdırma
        Console.WriteLine("Girilen sayılar:");
        foreach (int sayi in sayilar1)
        {
            Console.WriteLine(sayi);
        }

        int enBuyukSayi = sayilar1[0]; // karşılaştırma yapmak için ilk elemanı en büyük seçtik

        foreach (int sayi in sayilar1)
        {
            if (sayi > enBuyukSayi)
            {
                enBuyukSayi = sayi; // Daha büyük sayı bulunduğunda güncelle
            }
        }

        Console.WriteLine($"Dizideki en büyük sayı: {enBuyukSayi}");
    }
}