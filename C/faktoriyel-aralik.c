#include<stdio.h>
#include<stdlib.h>

int main() 
{
	int sayi, fakt = 1, i;
	printf("Sayi Giriniz: ");
	scanf("%d", &sayi);
	if (sayi == 0) printf("0!= 1\n");
	else if (sayi > 0)
	{ for (i = 1; i <= sayi; i++) printf("%d!= %d\n", i, fakt *= i); }
	system("pause");
	return 0;
}
