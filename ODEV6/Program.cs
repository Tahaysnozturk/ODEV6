using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("İlk sayıyı girin: ");
        int ilkSayi = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int ikinciSayi = Convert.ToInt32(Console.ReadLine());

        Console.Write("TEK'leri mi ÇİFT'leri mi toplamak istersiniz? (TEK/ÇİFT): ");
        string tercih = Console.ReadLine().ToUpper();

        int baslangic = Math.Min(ilkSayi, ikinciSayi);
        int bitis = Math.Max(ilkSayi, ikinciSayi);

        int toplam = 0;

        if (tercih == "TEK")
        {
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 != 0)
                {
                    toplam += i;
                }
            }
        }
        else if (tercih == "ÇİFT")
        {
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
            return;
        }

        Console.WriteLine("Toplam = " + toplam);
    }
}
