using System;
using System.Windows.Forms;
using System.Net;//Mail kütüphanesi
using System.Net.Mail;//Mail kütüphanesi
using System.Net.NetworkInformation;//İnternet bağlantı kütüphanesi

public void MailGonder(string Ad, string Soyad)
{
    DialogResult gonder = MessageBox.Show("Bilgileriniz Gönderilsinmi?", "Mail Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (gonder == DialogResult.Yes)
    {
        if (ogrenciMail.Trim() != "")
        {
            if (NetworkInterface.GetIsNetworkAvailable() == true) //internet bağlantısı varsa devam et
            {
                try
                {
                    //Gmail için Smtp Ayarları
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential("...@gmail.com", "şifre");//gönderen mail adresi ve şifresi
                    
                    MailMessage eMail = new MailMessage();
                    eMail.From = new MailAddress(MailAdresi, info.AssemblyProduct + " v1.0");
                    eMail.To.Add(ogrenciMail.Trim());
                    eMail.Subject = "KULLANICI BİLGİLERİNİZ";
                    eMail.IsBodyHtml = true; //Html özelliklerini aktif et
                    eMail.Body = "<b><u>Adınız:</u></b> " + Ad.Trim() +
                        "<br /><br /><b><u>Soyadınız:</u></b> " + Soyad.Trim();
                    smtp.SendAsync(eMail, (object)eMail); //Mail yığılmasını ve programda hata oluşmasını önle
                    MessageBox.Show("Mail Gönderildi.", "Mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException)
                { MessageBox.Show("Mail Gönderilirken hata oluştu. Tekrar deneyin.", "Mail Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Mail Gönderilemedi!. İnternet bağlantınızı kontrol edin.", "İnternet Bağlantısı Yok", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        else MessageBox.Show("Kayıtlı mail adresiniz bulunmamaktadır!.", "Mail Adresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
    else return;
}

private void Button1_Click(object sender, EventArgs e)
{ MailGonder("İbrahim", "YAVUZ"); }
