#include<stdio.h>
#include<stdlib.h>

int main() 
{
	int a, b;
	printf("a degeri: ");
	scanf("%d", &a);
	printf("b degeri: ");
	scanf("%d", &b);
	if (a > b) printf("%d > %d 'dir.\n", a, b);
	else if (a < b) printf("%d < %d 'dir.\n", a, b);
	else printf("%d = %d 'dir.\n", b, a);
	system("pause");
	return 0;
}
