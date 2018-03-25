//while döngüsü ile yapılışı

#include<stdio.h>

int main()
{
	int alt = 0;
	float fahr, celcius;
	fahr = alt;
	int ust = 300;
	while (fahr <= ust)
	{
		celcius = (5.0 / 9.0)*(fahr - 32.0);
		printf("%f\t%f\n", fahr, celcius);
		fahr = fahr + 20;
	}
	getchar();
}

//for döngüsü ile yapılışı

#include<stdio.h>

int main()
{
	int alt = 0;
	float fahr, celcius;
	fahr = alt;
	for (fahr = 0; fahr <= 300; fahr += 20)
	{
		celcius = (5.0 / 9.0)*(fahr - 32.0);
		printf("%f\t%f\n", fahr, celcius);
	}
	getchar();
}
