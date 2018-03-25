//while ile yapılışı

#include <stdio.h>
#include <conio.h>

int main(void)
{
	int number_of_entered_value = 0;
	int sum_of_numbers = 0;
	int number;
	do 
	{
		printf("Please enter a number> ");
		scanf("%d", &number);
		sum_of_numbers += number;
		number_of_entered_value++;
	} while (number>0);
	sum_of_numbers -= number;
	number_of_entered_value--;
	printf("\nTotally %d numbers entered.\n", number_of_entered_value);
	printf("Sum of %d numbers.\n", sum_of_numbers);
	printf("Average of numbers--> %.3f\n", (float)sum_of_numbers / number_of_entered_value);
	getch();
	return 0;
}

//for ile yapılışı

#include<stdio.h>

int main(void)
{
	int number, i, sum_of_numbers = 0, number_of_entered_value = 0;
	for ( ; ; ) //sonsuz döngü
	{
		printf("Please enter a number> ");
		scanf("%d", &number);
		sum_of_numbers += number;
		number_of_entered_value++;
		if (number<0)
		{
			sum_of_numbers -= number;
			number_of_entered_value--;
			getchar();
			break;
		}
	}
	printf("\nTotally %d numbers entered.\n", number_of_entered_value);
	printf("Sum of %d numbers.\n", sum_of_numbers);
	printf("Average of numbers--> %.3f\n", (float)sum_of_numbers / number_of_entered_value);
	getchar();
}
