static void Main(string[] args)
{
    do
    {
        try
        {
            int sec;
            Console.WriteLine("<1> Dizi Sıralama (5 elemanlı)\n<2> Final Not Hesaplama (Vize %20, Uygulama %30)\n<3> Ekranı Temizle\n<-1> Çıkış\n");
            Console.Write("Hangisi? ");
            sec = int.Parse(Console.ReadLine());
            switch (sec)
            {
                case -1: Environment.Exit(0); break; //Exit içindeki değer ne ise ona göre çıkış yapar.
                case 1:
                    int[] eBykDizi = new int[5]; //dizinin eleman sayısı 5
                    int[] eKckDizi = new int[eBykDizi.Length];
                    int sayi, eByk, eKck;
                    Console.WriteLine("\nDizi Elemanlarını Girin;");
                    for (int e = 0; e < eBykDizi.Length; e++)
                    {
                        Console.Write("Dizinin " + (e + 1).ToString() + ".elemanı: ");
                        sayi = int.Parse(Console.ReadLine());
                        eBykDizi[e] = sayi;
                        eKckDizi[e] = eBykDizi[e];
                    }
                    for (int i = 0; i < eBykDizi.Length; i++)
                    {
                        for (int j = 0; j < eBykDizi.Length; j++)
                        {
                            if (eKckDizi[i] < eKckDizi[j])
                            {
                                eKck = eKckDizi[i];
                                eKckDizi[i] = eKckDizi[j];
                                eKckDizi[j] = eKck;
                            }

                            if (eBykDizi[i] > eBykDizi[j])
                            {
                                eByk = eBykDizi[i];
                                eBykDizi[i] = eBykDizi[j];
                                eBykDizi[j] = eByk;
                            }
                        }
                    }
                    Console.Write("\nBüyükten Küçüğe Sıralama: ");
                    foreach (int item in eBykDizi) Console.Write("{0} ", item);
                    Console.Write("\n\nKüçükten Büyüğe Sıralama: ");
                    foreach (int item in eKckDizi) Console.Write("{0} ", item);
                    Console.Write("\n\n");
                    break;
                case 2:
                    double vize = 63, uygulama = 85, vizeuyg;
                    double AA, BA, BB, CB, CC, DC, DD, FF;
                    Console.Write("\nVize Notu: "); vize = int.Parse(Console.ReadLine());
                    Console.Write("Uygulama Notu: "); uygulama = int.Parse(Console.ReadLine());
                    vizeuyg = Math.Round((vize * 20 / 100) + (uygulama * 30 / 100), 0);
                    if (vize >= 0 && vize <= 100 && uygulama >= 0 && uygulama <= 100)
                    {
                        Console.WriteLine("\n\n\tVizenin %20'si ve Uygulamanın %30'u ile {0} düşer.", vizeuyg);
                        //AA: 90
                        AA = (90 - vizeuyg) * 100 / 50;
                        //BA: 85
                        BA = (85 - vizeuyg) * 100 / 50;
                        //BB: 80
                        BB = (80 - vizeuyg) * 100 / 50;
                        //CB: 75
                        CB = (75 - vizeuyg) * 100 / 50;
                        //CC: 70
                        CC = (70 - vizeuyg) * 100 / 50;
                        //DC: 60
                        DC = (60 - vizeuyg) * 100 / 50;
                        //DD: 50
                        DD = (50 - vizeuyg) * 100 / 50;
                        //FF: 49
                        FF = (49 - vizeuyg) * 100 / 50;
                        Console.WriteLine("\n\n{0} ile AA\n{1} ile BA\n{2} ile BB\n{3} ile CB\n{4} ile CC\n{5} ile DC\n{6} ile DD\n{7} ile FF alırsın.", AA, BA, BB, CB, CC, DC, DD, FF);
                    }
                    else Console.WriteLine("\n\n\tVize ve Uygulama Notu 0 ile 100 arasında olmalıdır.");
                    Console.Write("\n\n");
                    break;
                case 3: Console.Clear(); break;
                default: Console.WriteLine("\n\n\tSeçim Yapmadınız!\n\n"); break;
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("\n\n\tSeçim Yapmadınız!\n\n");
        }
    } while (true);
}
