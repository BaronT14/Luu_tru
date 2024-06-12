#include <conio.h>
#include <iostream>
using namespace std;

int main()
{
    float a, b;
    float *pa, *pb;
    pa = &a;
    pb = &b;
    cout << "Nhap 2 so thuc: ";
    cin >> a >> b;
    cout << "Gia tri cua a thong qua con tro: " << *pa << endl;
    cout << "Gia tri cua b thong qua con tro: " << *pb << endl;
    _getch();
    return 1;
}