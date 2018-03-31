#include<cstdio>

int main(void)
{
	long long int sayi = 600851475143, i, j, eByk = 0;
	printf("%lld sayisinin asal tam bolunenleri: ", sayi);
	for (i = 2; i <= sayi; i++)
	{
		int asal = 0;
		if (sayi % i == 0)
		{
			for (j = 1; j <= i; j++) if (i % j == 0) asal++;//sayının asal sayı olup olmadığı kontrol et
			sayi /= i;//işlem yoğunluğunu azaltmak için sayıyı tam bölündüğü sayıya böl
			if (asal == 2)//asallıktan gelen kural(sayının 1 ve kendisine başka böleni olmayacak)
			{
				printf("%lld  ", i);//asal sayıları yazdır
				if (i > eByk) eByk = i;//en büyük sayıyı bul
			}
		}
	}
	printf("\n\nEn Buyuk Asal Bolen: %lld", eByk);
	getchar();
	return 0;
}
