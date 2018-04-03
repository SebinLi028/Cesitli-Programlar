static void Main(string[] args)
{
    int sayi1 = 1, sayi2 = 1, gecici = 0, toplam = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.Write("{0}\t", sayi1);
        gecici = sayi1;
        sayi1 = sayi1 + sayi2;
        sayi2 = gecici;
        if (gecici % 2 == 0) toplam += gecici;
    }
    Console.WriteLine("\n\n Toplam Çift Fibonacci: {0}", toplam);
    Console.ReadKey();
}
