#include <conio.h>
#include <string>
#include <iostream>
using namespace std;

int main()
{
    string st, *pst;
    pst = &st;
    cout << "Nhap chuoi ki tu: ";
    getline(cin, st);
    for (char *ptr = &st[0]; *ptr != '\0'; ptr++)
    {
        cout << *ptr << endl;
    }
    _getch();
    return 1;
}