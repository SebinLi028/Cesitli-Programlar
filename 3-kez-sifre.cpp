#include <iostream>
using namespace std;

int main(void)
{
	// Program to prompt for a password and check it against an internal one.
	int stored_pass = 123;
	int num_tries = 0; // Counter for password attempts.
	int user_pass;
	while (num_tries < 3) // Loop only three times.
	{
		cout << "What is the password (You get 3 tries...)? ";
		cin >> user_pass;
		num_tries++; // Add 1 to counter.
		if (user_pass == stored_pass)
		{
			cout << "You entered the correct password.\n\n";
		}
		else
		{
			cout << "You entered the wrong password.\n";
			if (num_tries == 3)
			{
				cout << "Sorry, you get no more chances\n\n";
			}
			else
			{
				cout << "You get " << (3 - num_tries) << " more tries...\n\n";
			}
		}
	} // End of while loop.
	system("pause");
	return 0;
}
