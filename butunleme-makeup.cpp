#include <iostream>
using namespace std;

int main(void) 
{
	int grade, makeup;
	cout << "enter grade: ";
	cin >> grade;
	if (grade >= 50) cout << "PASS" << endl << endl;
	else
	{
		cout << "enter make up grade: ";
		cin >> makeup;
		if (makeup >= 60) cout << "Success!" << endl << endl;
		else cout << "Fail!" << endl << endl;
	}
	system("PAUSE");
	return 0;
}
