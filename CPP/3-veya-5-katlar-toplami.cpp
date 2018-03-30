#include<iostream>
using namespace std;

int main(void)
{
	int toplam = 0;
	for (int sayi = 1; sayi < 1000; sayi++)
		if (sayi % 3 == 0 || sayi % 5 == 0)
			toplam += sayi;
	cout << "1-1000 arasi 3 veya 5'in katlari toplami: <" << toplam << ">";
	getchar();
	return 0;
}