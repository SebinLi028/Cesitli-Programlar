private void button1_Click(object sender, EventArgs e)
{
	int sayi = int.Parse(textBox1.Text), tekc = 1, ciftt = 0;
	for (int i = 1; i <= sayi; i++)
	{
		if (i % 2 == 1) tekc *= i; 
		if (i % 2 == 0) ciftt += i;
	}
	MessageBox.Show("Tek Çarpım: " + tekc.ToString() + "\n" + "Çift Toplam: " + ciftt.ToString());
}
