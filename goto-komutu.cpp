// This program demonstrates the overuse of goto.
#include <iostream.h>
main()
{
    goto Here;
    First:
    cout << "A \n";
    goto Final;
    There:
    cout << "B \n";
    goto First;
    Here:
    cout << "C \n";
    goto There;
    Final:
    cout << "END OF PROGRAM \n";
    system("PAUSE");
    return 0;
}
