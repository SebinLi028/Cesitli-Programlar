#include<stdio.h>

int main(void)
{
	int i;
	for (i = 1; i<100; i++)
	{
		if (i % 3 == 0) printf("%d\t", i);
	}
	getchar();
}
