using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ASCII Çevirici";
            while (true)
            {
                try
                {
                    Console.WriteLine("******** SebinLi028.WordPress.Com ********");
                    string metin = "";
                    Console.Write("\n**** Hangi işlem yapılsın? ****\n1-) Metni 2'liğe çevir\n2-) Kodu metne çevir\n3-) Ekranı temizle\n4-) Programdan çık\n\nHangisi: ");
                    int sec = int.Parse(Console.ReadLine());
                    switch (sec)
                    {
                        case 1:
                            Console.Write("\nÇevrilecek metni giriniz: ");
                            metin = Console.ReadLine();
                            string kod = "", skod = "";
                            char[] pkod = metin.ToCharArray(); //metin parçala ve dizi oluştur
                            foreach (char item in pkod)
                            {
                                int intItem = (char)item; //her harfin ascii kod tablosundaki decimal (onluk) karşılığını ata
                                kod = Convert.ToString(Convert.ToInt32(intItem.ToString(), 10), 2); //10'luktan 2'liğe çevir 
                                while (kod.Length < 8) { kod = "0" + kod; }
                                skod += kod + " ";
                            }
                            Console.Write("{0}\nKopyalamak için seçin.\n", skod);
                            break;

                        case 2:
                            Console.Write("\n2'lik kodu giriniz: ");
                            metin = Console.ReadLine();
                            string mtn = "", ymetin = "";
                            while (metin.Length > 0)
                            {
                                ymetin = "";
                                for (int i = 0; i < metin.Length; i++) //tüm metni kontrol et
                                {
                                    if (metin.Substring(i, 1).Trim() == "") continue; //arasında boşluk varsa dahil etme
                                    else ymetin += metin.Substring(i, 1); //yoksa yeni metne aktar
                                }
                                metin = ymetin;
                                var ilk = metin.Substring(0, 8); //ilk 8 karakter seç ve değişkene ata
                                metin = metin.Substring(8); //sonraki 8 karakteri seç ve metne tekrar aktar
                                mtn += (char)Convert.ToInt32(ilk, 2); //2'lik değeri 10'luğa çevir
                            }
                            Console.Write("{0}\nKopyalamak için seçin.\n", mtn);
                            break;

                        case 3: Console.Clear(); break;

                        case 4: Environment.Exit(0); break;

                        default: Console.WriteLine("\nSeçim Yapmadınız."); break;
                    }
                }
                catch (Exception) { Console.WriteLine("\nHatalı Veri Girişi"); }
            }
        }
    }
}
