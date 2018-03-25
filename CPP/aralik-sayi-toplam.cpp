#include <iostream>
using namespace std;

int main(void)
{
	int number, sum = 0;
	cout << "enter a number less than 100: ";
	cin >> number;
	while (number < 100)
	{
		sum += number;
		number++;
	}
	cout << "Sum: " << sum << endl << endl;
	system("PAUSE");
	return 0;
}
