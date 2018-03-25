#include<cstdio> //C dili ana kütüphane
#include<conio.h> //getch() kütüphanesi
#include<cstdlib> //random ve system("pause") kütüphanesi
#include<time.h> //random kütüphanesi

//(sizeof(dizi) / sizeof(int)) = dizi.lenght()

int asalkontrol(int sayi)
{	//asal kontrol et
	int asal = 0;
	for (int j = 1; j <= sayi; j++)
		if (sayi % j == 0) asal++;
	return asal;
}

int main(void)
{
	srand(time(NULL)); //farklı rastgele sayı üret
	int dizi[20], dizieleman = 0;
	for (int i = 0; i < (sizeof(dizi) / sizeof(int)); i++) dizi[i] = 54 + rand() % 312; //54-312
	for (int i = 0; i < (sizeof(dizi) / sizeof(int)); i++)
	{
		if (asalkontrol(dizi[i]) == 2) { printf("%d\t", dizi[i]); dizieleman++; } //asalsa sayıyı ekrana yazdır
		else continue; //asal değilse sayıyı alma
	}
	printf("\n\n54 ile 312 arasinda 20 kez uretilen %d random asal sayi vardir.", dizieleman);
	getch();
	return 0;
}
