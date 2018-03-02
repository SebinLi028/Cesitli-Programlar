#include <iostream>
#include <iomanip>
using namespace std;

int main(void)
{
	// Computes a grade average with a for loop, allowing an early exit with a break statement.
	float grade, avg, total = 0.0;
	int num, count = 0; // Total number of grades and counter
	int loopvar; // Used to control for loop
	cout << "\n*** Grade Calculation ***\n\n";
	cout << "How many students are there? ";
	cin >> num; // Get total number to enter.
	for (loopvar = 1; loopvar <= num; loopvar++)
	{
		cout << "\nWhat is the next student's " << "grade? (-1 to quit) ";
		cin >> grade;
		if(grade < 0.0)
		{// A negative number teriggers break.
			break; // Leave the loop early.
		}
		count++;
		total += grade; // Keep a running total.
	}
	avg = total / count;
	cout << "\n\nThe average of this class is " << avg << endl;
	system("PAUSE");
	return 0;
}
