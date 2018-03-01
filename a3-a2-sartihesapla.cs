static void Main(string[] args)
{
    try
    {
        int syc = 0;
        Console.WriteLine("\n----------------- a^3-a^2=b Koşulu -----------------\n");
        do
        {
            syc++;
            Console.Write("b sayısını giriniz: "); double b = Convert.ToDouble(Console.ReadLine());
            double list = 0.0;
            for (int a = 0; a < 101; a++)
            {
                list = Math.Pow(a, 3) - Math.Pow(a, 2);
                if (list <= b)
                {
                    Console.WriteLine(a + ".sayı sonuç: " + list.ToString());
                }
            }
            Console.Write("\n");
        } while (syc >= 0);
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nDevam etmek için bir tuşa basın...");
    }
    Console.ReadLine();
}
