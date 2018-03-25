#include<stdio.h>
#include<stdlib.h>
#define size 100

int main(void) 
{
	float arr[size];
	int i, j, n;
	printf("Enter total number of elements(1 to 100): ");
	scanf("%d", &n);
	printf("\n");
	for (i = 0; i<n; ++i)
	{
		printf("Enter number %d: ", i + 1);
		scanf("%f", &arr[i]);
	}
	for (j = 1; j<n; ++j)
	{
		if (arr[0]<arr[j])
		{
			arr[0] = arr[j];
		}
	}
	printf("Largest element = %.2f\n\n", arr[0]);
	system("pause");
	return 0;
}
