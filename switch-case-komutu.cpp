//Sample program, Menu selection
#include <iostream>
#include <stdlib.h>

using namespace std;
int main(void)
{
	char selection;
	cout << "\n Menu";
	cout << "\n========";
	cout << "\n A - Append";
	cout << "\n M - Modify";
	cout << "\n D - Delete";
	cout << "\n X - Exit";
	cout << "\n Enter selection: ";
	cin >> selection;
	switch (selection)
	{
	case 'A': {cout << "\n To append a record\n"; }
		break;
	case 'M': {cout << "\n To modify a record"; }
		break;
	case 'D': {cout << "\n To delete a record"; }
		break;
	case 'X': {cout << "\n To exit the menu"; }
		break;
		//Other than A, M, D and X...
	default: { cout << "\n Invalid selection"; }
		//No break in the default case
	}
	cout << "\n";
	system("pause");
	return 0;
}
