using System;

namespace SystemProgrammingHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "4 Basamaklı Süper Asal Sayılar (========>>>> SebinLi028 <<<<========)";
            int superasalsay = 0;
            Console.WriteLine("\n\tSağdan-Sola Süper Asal Sayılar\n");
            for (int i = 1000; i <= 9999; i++)
            {
                int durum1, durum2, durum3, durum4, kbir, kon, kyuz, kbin;
                durum1 = durum2 = durum3 = durum4 = 0;
                kbir = i % 10; kon = i % 100; kyuz = i % 1000; kbin = i % 10000;
                for (int j1 = 1; j1 <= kbir; j1++) if (kbir % j1 == 0) durum1++;
                for (int j2 = 1; j2 <= kon; j2++) if (kon % j2 == 0) durum2++;
                for (int j3 = 1; j3 <= kyuz; j3++) if (kyuz % j3 == 0) durum3++;
                for (int j4 = 1; j4 <= kbin; j4++) if (kbin % j4 == 0) durum4++;
                if (durum1 == 2 && durum2 == 2 && durum3 == 2 && durum4 == 2)
                {
                    superasalsay++;
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine("\n\nToplam " + superasalsay + " süper asal sayı bulunmaktadır.\n\n\n\n");

            Console.WriteLine("\tSoldan-Sağa Süper Asal Sayılar\n");
            superasalsay = 0;
            for (int i = 1000; i <= 9999; i++)
            {
                int durum1, durum2, durum3, durum4, kbir, kon, kyuz;
                durum1 = durum2 = durum3 = durum4 = 0;
                kbir = i / 1000; kon = i / 100; kyuz = i / 10;
                for (int j1 = 1; j1 <= kbir; j1++) if (kbir % j1 == 0) durum1++;
                for (int j2 = 1; j2 <= kon; j2++) if (kon % j2 == 0) durum2++;
                for (int j3 = 1; j3 <= kyuz; j3++) if (kyuz % j3 == 0) durum3++;
                for (int j4 = 1; j4 <= i; j4++) if (i % j4 == 0) durum4++;
                if (durum1 == 2 && durum2 == 2 && durum3 == 2 && durum4 == 2)
                {
                    superasalsay++;
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine("\n\nToplam " + superasalsay + " süper asal sayı bulunmaktadır.\n\n");

            Console.ReadKey();
        }
    }
}
