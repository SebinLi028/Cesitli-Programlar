#include<stdio.h>
#include<conio.h>

const float pi = 3.14;

float alan(int rad)
{
	return pi * rad * rad;
}

float cevre(int rad)
{
	return 2 * pi * rad;
}

int main(void)
{
	int r;
	printf("Yaricapi Giriniz: ");
	scanf("%d", &r);
	printf("\n Alani    : %.2f\n", alan(r));
	printf(" Cevresi  : %.2f\n", cevre(r));
	getch();
}
