static void Main(string[] args)
{
    Console.Title = "----------------- 30 Fibonacci Serisi -----------------";
    Console.ForegroundColor = ConsoleColor.Green;
    double sayi1 = 0.0, sayi2 = 1.0, gecici = 0.0;
    for (int i = 0; i <= 60; i++)
    {
        Console.WriteLine(sayi2);
        gecici = sayi2;
        sayi2 = sayi1 + sayi2;
        sayi1 = gecici;
    }
    Console.ReadLine();
}
