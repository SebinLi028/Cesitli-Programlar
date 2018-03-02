#include<iostream>

using namespace std;
int main(void)
{
	char child[25]; // Holds child’s first name
	int age; // Holds child’s age
	int ctr; // The for loop counter variable
	for (ctr = 1; ctr <= 5; ctr++)
	{
		cout << "What is the next child's name? ";
		cin >> child;
		cout << "What is the child's age? ";
		cin >> age;
		if (age <= 5)
		{
			cout << "\n" << child << " has Mrs. "
				<< "Jones for a teacher\n";
		}
		if (age == 6)
		{
			cout << "\n" << child << " has Miss "
				<< "Smith for a teacher\n";
		}
		if (age >= 7)
		{
			cout << "\n" << child << " has Mr. "
				<< "Anderson for a teacher\n";
		}
	} // Quits after 5 times
	return 0;
}
