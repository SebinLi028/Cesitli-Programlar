using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/// <summary>
/// ATM v1.0
/// https://SebinLi028.WordPress.Com
/// </summary>

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        int[] bakiye = new int[] { 0 }; //Toplam bakiye
        int[] parabirimleri = new int[] { 200, 100, 50, 20, 10, 5 }; //Kağıt paralar
        int nakit, limit = 5;

        void BakiyeGoster()
        {
            int gecici = bakiye[0]; //Bakiyeyi hesaplama yapmak için geciciye aktar
            string[] bakiyeStr = new string[parabirimleri.Length + 1]; //Dizi boyutu para birimlerinden bir fazlası
            bakiyeStr[0] = "Bakiye: " + gecici.ToString() + " TL"; //Toplam bakiyeyi 0. elemana ata
            for (int i = 0; i < parabirimleri.Length; i++)
            {
                if (gecici / parabirimleri[i] != 0) //Bakiyede para birimi varmı?
                {
                    int adet = gecici / parabirimleri[i]; //Para birimi adeti
                    gecici -= (adet * parabirimleri[i]); //Diğer para birimlerini kontrol et
                    bakiyeStr[i + 1] = adet.ToString() + " tane " + parabirimleri[i] + " TL";
                }
            }
            string goster = "";
            //MessageBox kutusunda null içermeyen birim adetlerini göster
            for (int i = 0; i < bakiyeStr.Length; i++) if (!String.IsNullOrEmpty(bakiyeStr[i])) goster += bakiyeStr[i] + "\n";
            MessageBox.Show(goster, "BAKİYE AYRINTI");
        }

        private void ParaYatirmaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nakit = Math.Abs(int.Parse(Interaction.InputBox("Yatırılacak Para Miktarını Giriniz.", "PARA YATIRMA (Bakiye: " + bakiye[0] + " TL)")));
                if (nakit % limit == 0) //Limit ile sınırlama
                {
                    bakiye[0] += nakit;
                    MessageBox.Show("Bakiyeye " + nakit + " TL yatırıldı.", "BAKİYE: " + bakiye[0] + " TL");
                }
                else MessageBox.Show(limit.ToString() + " TL ve Katları Olmalıdır.", "PARA YATIRMA (Bakiye: " + bakiye[0] + " TL)");
            }
            catch (Exception)
            { MessageBox.Show("İşlem İptal Edildi!", "İPTAL"); }
        }

        private void ParaCekmeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nakit = Math.Abs(int.Parse(Interaction.InputBox("Çekilecek Para Miktarını Giriniz.", "PARA ÇEKME (Bakiye: " + bakiye[0] + " TL)")));
                if (nakit % limit == 0) //Limit ile sınırlama
                {
                    if (nakit > bakiye[0]) MessageBox.Show("Yeterli Bakiye Bulunmamaktadır. Tekrar Deneyiniz.", "BAKİYE: " + bakiye[0] + " TL");
                    else
                    {
                        bakiye[0] -= nakit;
                        MessageBox.Show("Bakiyeden " + nakit + " TL çekildi.", "BAKİYE: " + bakiye[0] + " TL");
                    }
                }
                else MessageBox.Show(limit.ToString() + " TL ve Katları Olmalıdır.", "PARA ÇEKME (Bakiye: " + bakiye[0] + " TL)");
            }
            catch (Exception)
            { MessageBox.Show("İşlem İptal Edildi!", "İPTAL"); }
        }

        private void TumParayiCekmeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Bakiyeden " + bakiye[0] + " TL çekildi.", "TÜM PARAYI ÇEKME");
                bakiye[0] = 0;
            }
            catch (Exception)
            { MessageBox.Show("İşlem İptal Edildi!", "İPTAL"); }
        }

        private void BakiyeSorgulamaBtn_Click(object sender, EventArgs e)
        { BakiyeGoster(); }

        private void Cikis(object sender, EventArgs e)
        { Application.Exit(); }
    }
}
