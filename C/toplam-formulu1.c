#include<stdio.h>
#include<stdlib.h>

int main()
{
	float i, n;
	float sum = 0;
	printf("enter n value: ");
	scanf("%f", &n);
	for (i = 1; i <= n; i++)
	{
		sum = sum + (i - n) / (i + n);
	}
	printf("sum is --> %f\n", sum);
	system("pause");
	return 0;
}
