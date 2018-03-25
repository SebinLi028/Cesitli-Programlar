#include<stdio.h>
#include<stdlib.h>

int main() 
{
	int sayi, top = 0, i;
	printf("Deger: ");
	scanf("%d", &sayi);
	for (i = 1; i <= sayi; i++)
	{
		top += i*i;
	}
	printf("Toplam= %d\n", top);
	system("pause");
	return 0;
}
