#include<iostream>
#include<stdlib.h>
using namespace std;

void yol1()
{
	//variables for counter…
	int i, j;
	//outer loop, execute this first...
	for (i = 1; i < 11; i++)
	{
		cout << "\n" << i;
		//then...execute inner loop with loop index j
		//the initial value of j is i + 1
		for (j = i + 1; j < 11; j++)
			//Display result…
			cout << j;
		//increment counter by 1 for inner loop…
	}
	//increment counter by 1 for outer loop…
	cout << "\n";
}

void yol2()
{
	for (int i = 0; i < 11; i++)
	{
		cout << "\n";
		for (int j = i + 1; j < 11; j++) cout << j;
	}
}

int main(void)
{
	yol1();
	cout << endl;
	yol2();
	system("pause");
	return 0;
}
