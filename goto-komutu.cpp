#include <stdlib.h>
#include <iostream>
using namespace std;

int main(void)
{
	goto Here;
First:
	cout << "A \n";
	goto Final;
There:
	cout << "B \n";
	goto First;
Here:
	cout << "C \n";
	goto There;
Final:
	cout << "END OF PROGRAM \n";
	system("PAUSE");
	return 0;
}
