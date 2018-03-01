using System;
using System.Windows.Forms;
using System.Net;//Mail kütüphanesi
using System.Net.Mail;//Mail kütüphanesi
using System.Net.NetworkInformation;//İnternet bağlantı kütüphanesi

public void MailGonder(string Ad, string Soyad, string kimden, string kime)
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
                    smtp.Port = 587; //Gmail smtp varsayılan port
                    smtp.EnableSsl = true; //SSL aktif et
                    smtp.Credentials = new NetworkCredential(kimden, "Gönderen şifresi");
                    
                    MailMessage eMail = new MailMessage();
                    eMail.From = new MailAddress(kimden); //kimden
                    eMail.To.Add(kime); //kime
                    eMail.Subject = "C# Mail Gönderme";
                    eMail.IsBodyHtml = true; //Html özelliklerini aktif et
                    eMail.Body = "<b><u>Adınız:</u></b> " + Ad.Trim() +
                        "<br /><br /><b><u>Soyadınız:</u></b> " + Soyad.Trim() +
                        "<br /><br /><a href="https://sebinli028.wordpress.com">SebinLi028.WordPress.Com</a>"
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
{ MailGonder("İbrahim", "YAVUZ", "Gönderen mail adresi", "Alıcı mail adresi"); }
