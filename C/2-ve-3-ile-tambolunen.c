#include<stdio.h>
#include<stdlib.h>

int main(void)
{
	int i = 1, kontrol = 0;
	int sayi;
	printf("********** 2'ye ve 3'e tam bolunebilen sayilar **********\n(-1 Cikis)\n\n");
	do
	{
		kontrol = 0;
		printf("sayilar kaca kadar olsun> ");
		scanf_s("%d", &sayi);
		for (i = 1; i <= sayi; i++)
		{ 
			if (i % 2 == 0 && i % 3 == 0)
			{
				printf("%d\t", i);
				kontrol++;
			}
		}
		if (kontrol == 0) printf("bolunebilen sayi yoktur.");
		printf("\n\n");
	} while (sayi > -1);
	printf("\n\n");
	system("pause");
	return 0;
}
