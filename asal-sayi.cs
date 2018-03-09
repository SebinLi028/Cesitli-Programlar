static void Main(string[] args)
{
    Console.WriteLine("\n-------- 1-999 Arasındaki Asal Sayılar --------\n");
    for (int i = 1; i <= 999; i++)
    {
        int syc = 0;
        for (int j = 1; j <= i; j++) if (i % j == 0) syc++;
        if (syc == 2) Console.Write("\t" + i);
    }
    Console.ReadLine();
}
