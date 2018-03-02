#include<stdio.h>
#include<stdlib.h>

int fakt(int n)
{
	int i, f  = 1;
	for (i = n; i >= 1; i--) f *= i;
	return f;
}

int main(void)
{
	int s;
	printf("Enter an integer number: ");
	scanf("%d", &s);
	printf("The factorial of %d is %d.\n\n", s, fakt(s));
	system("pause");
	return 0;
}
