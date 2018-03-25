#include<stdio.h>
#include<stdlib.h>

int main(void)
{
	int a, maks = 0;
	int i = 1;
	while (i <= 5)
	{
		printf("ENTER A NUMBER: ");
		scanf("%d", &a);
		if (a > maks) maks = a;
		i++;
	}
	printf("\nMAXIMUM VALUE = %d\n", maks);
	system("pause");
	return 0;
}
