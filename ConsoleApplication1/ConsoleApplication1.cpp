// ConsoleApplication1.cpp : Ce fichier contient la fonction 'main'. L'exécution du programme commence et se termine à cet endroit.
//

#include <iostream>
using namespace std;

typedef bool(*expression)(int);

bool isEven(int);

int main()
{
    cout << &isEven << endl;

    expression ptr_isEven = &isEven;

    cout << ptr_isEven(42) << endl;
}

bool isEven(int x)
{
    return x % 2 == 0;
}
