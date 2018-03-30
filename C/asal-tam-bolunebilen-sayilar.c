#include<cstdio>
#include<cmath>

int main(void)
{
	double sayi = 600851475143;
	for (double i = 2; i <= sayi; i++)
	{
		int asal = 0;
		if (fmod(sayi, i) == 0)//double mod alma
		{
			for (double j = 1; j <= i; j++)
				if (fmod(i, j) == 0) asal++;
			if (asal == 2) printf("%.0lf\t", i);
		}
	}
	getchar();
	return 0;
}