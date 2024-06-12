#include <conio.h>
#include <fstream>
#include <iostream>
using namespace std;
#define INPUT "input.txt"
#define NMAX 100

void nhapMangFile(int a[], int &n);
int *findMax(int a[], int n, int **ptrMax);
int *findMin(int a[], int n, int **ptrMin);
int *ptrMax;
int *ptrMin;

int main()
{
    int a[NMAX], n;
    nhapMangFile(a, n);
    // cau a
    findMax(a, n, &ptrMax);
    cout << "Max: " << *ptrMax << endl;
    cout << "Adress's Max: " << ptrMax << endl;
    // cau b
    findMin(a, n, &ptrMin);
    cout << "Adress's Max: " << ptrMax << endl;
    cout << "Adress's Min: " << ptrMin << endl;
    _getch();
    return 1;
}

void nhapMangFile(int a[], int &n)
{
    ifstream file;
    file.open(INPUT);
    file >> n;
    for (int i = 0; i < n; i++)
    {
        file >> a[i];
        cout << a[i] << "  ";
    }
    cout << endl;
    file.close();
}

int *findMax(int a[], int n, int **ptrMax)
{
    *ptrMax = &a[0];
    for (int i = 1; i < n; i++)
    {
        if (**ptrMax < a[i])
            *ptrMax = &a[i];
    }
}

int *findMin(int a[], int n, int **ptrMin)
{
    *ptrMin = &a[0];
    for (int i = 1; i < n; i++)
    {
        if (**ptrMin > a[i])
            *ptrMin = &a[i];
    }
}