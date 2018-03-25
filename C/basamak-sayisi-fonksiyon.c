#include<stdio.h>
#include<stdlib.h>

int Find_The_Number_of_Digits(int); //main fonksiyonun altında tanımlanmak istenirse yazılması gerekir

int main(void)
{
	int no;
	printf("Please enter a positive integer: ");
	scanf("%d", &no);
	while (no>0)
	{
		printf("Number of Digits: %d\n\n", Find_The_Number_of_Digits(no));
		printf("Please enter a positive integer: ");
		scanf("%d", &no);
	}
	printf("\n\n");
	system("pause");
	return 0;
}

int Find_The_Number_of_Digits(int number)
{
	int digit = 0;
	while (number > 0)
	{
		digit++;
		number /= 10;
	}
	return(digit);
}
