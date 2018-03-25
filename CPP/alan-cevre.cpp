#include <iostream>
#define PI 3.14
using namespace std;

int main(void)
{
	double yaricap, alan, cevre;
	cout << "Yaricapi Giriniz: ";
	cin >> yaricap;
	alan = PI * yaricap * yaricap;
	cevre = 2 * PI * yaricap;
	cout << "Cevresi: " << cevre << endl << "Alan: " << alan << endl << endl;
	system("PAUSE");
	return 0;
}
