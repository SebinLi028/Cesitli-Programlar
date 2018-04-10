using System;
using System.Numerics;//BigInteger veri tipi için projeye Add Referance -> Numerics diye aratıp projenize ekleyin

namespace CSharp_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger i, sum = 0, fact = 1, num = 100;//BigInteger aralık devasa :)))
            for (i = num; i > 1; i--) fact *= i;
            char[] digitArray = fact.ToString().ToCharArray();//Sayıyı rakamlarına ayır ve diziye aktar
            foreach (char item in digitArray) sum += BigInteger.Abs(BigInteger.Parse(item.ToString()));//Abs ile mutlak değeri hesapla
            Console.Write("\n{0} sayısının faktöriyeli;\n\n{1}\n\nolan sayının rakamları toplamı {2} sayısıdır.", num, fact, sum);
            Console.ReadKey();
        }
    }
}