#include <cstdlib>
#include <iostream>
using namespace std;

int main(void)
{
	int tries = 0;
	char comp_ans, user_guess;
	// Save the computer's letter
	comp_ans = 't';
	// Letter if desired.
	cout << "I am thinking of a letter...";
	do
	{
		cout << "What is your guess? ";
		cin >> user_guess;
		tries++; // Add 1 to the guess-counting variable.
		if(user_guess > comp_ans)
		{
			cout << "Your guess was too high\n";
			cout << "\nTry again...";
		}
	} while(user_guess != comp_ans); // Quit when a match is found.
									   // They got it right, let them now.
	cout << "*** Congratulations! You got it right! \n";
	cout << "It took you only " << tries << " tries to guess.\n\n";
	system("Pause");
	return 0;
}
