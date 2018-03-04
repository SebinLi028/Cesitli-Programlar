#include<stdio.h>
#include<stdlib.h>
int main(void)
{
	int arr[3][3] = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
	int i, j;
	for (i = 0; i<3; i++)
	{
		for (j = 0; j<3; j++)
		{
			printf("value of arr[%d,%d]: %d\n", i, j, arr[i][j]);
		}
	}
	getchar();
}
