#include<stdio.h>
#include<stdlib.h>

int main() 
{
	int sayi, i;
	for (i = 1; i <= 5; i++) {
		printf(" karesi alinacak sayi: ");
		scanf("%d", &sayi);
		printf("%d'inci sayinin karesi= %d\n\n", i, sayi*sayi);
	}
	system("pause");
	return 0;
}
