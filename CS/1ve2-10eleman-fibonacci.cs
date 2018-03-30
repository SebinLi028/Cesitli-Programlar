static int sayi1 = 1, sayi2 = 1, gecici = 0;
static int fibo()
{
    Console.Write(sayi1 + "\t");
    gecici = sayi1;
    sayi1 = sayi1 + sayi2;
    sayi2 = gecici;
    return gecici;
}

static void Main(string[] args)
{
    int[] dizi = new int[10];//fibonacci terim sayısı: 10
    int toplam = 0;
    for (int i = 0; i < dizi.Length; i++) dizi[i] = fibo();//fibo elemanlarını diziya aktar
    for (int i = 0; i < dizi.Length; i++) if (dizi[i] % 2 == 0) toplam += dizi[i];//dizideki elemanların çift olanlarını topla
    Console.WriteLine("\n\nToplam Çift Fibonacci: " + toplam);
    Console.ReadKey();
}
