static void Main(string[] args)
{
    Console.Title = "----------------- 30 Fibonacci Serisi -----------------";
    Console.ForegroundColor = ConsoleColor.Green;
    int sayi1 = 1, sayi2 = 0, gecici = 0;
    for (int i = 0; i < 30; i++)
    {
        Console.WriteLine(sayi1);
        gecici = sayi1;
        sayi1 = sayi1 + sayi2;
        sayi2 = gecici;
    }
    Console.ReadLine();
}
