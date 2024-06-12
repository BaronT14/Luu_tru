#include <conio.h>
#include <iostream>
#include <fstream>
using namespace std;
#define NMax 100
#define INPUT "input.txt"

void nhapMang(int a[], int &n);
void xuatMang(int a[], int n);
void nhapMangFile(int a[], int &n);
int findMax(int a[], int n);
int findMin(int a[], int n);
int demSoChan(int a[], int n);
int demSoLe(int a[], int n);
void timXTuyenTinh(int a[], int n);
void tangMang(int a[], int n);
void timXNhiPhan(int a[], int n);

int main()
{
    int a[NMax], n = 0;
    nhapMangFile(a, n);
    timXNhiPhan(a, n);

    _getch();
    return 1;
}

void nhapMang(int a[], int &n)
{
    cout << "Nhap so luong phan tu cua mang: ";
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cout << "Nhap phan tu thu " << i + 1 << ":";
        cin >> a[i];
    }
}

void xuatMang(int a[], int n)
{
    for (int i = 0; i < n; i++)
    {
        cout << a[i] << "   ";
    }
}

void nhapMangFile(int a[], int &n)
{
    ifstream file;
    file.open(INPUT);
    file >> n;
    for (int i = 0; i < n; i++)
    {
        file >> a[i];
    }
    cout << endl;
    file.close();
}

int findMax(int a[], int n)
{
    int max = a[0];
    for (int i = 1; i < n; i++)
    {
        if (max < a[i])
            max = a[i];
    }
    return max;
}

int findMin(int a[], int n)
{
    int min = a[0];
    for (int i = 1; i < n; i++)
    {
        if (min > a[i])
            min = a[i];
    }
    return min;
}

int demSoChan(int a[], int n)
{
    int dem = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] % 2 == 0)
        {
            dem++;
        }
    }
    return dem;
}

int demSoLe(int a[], int n)
{
    int dem = 0;
    for (int i = 0; i < n; i++)
    {
        if (a[i] % 2 != 0)
        {
            dem++;
        }
    }
    return dem;
}

void timXTuyenTinh(int a[], int n)
{
    if (n < 1)
    {
        cout << "Mang rong!!!";
        _getch();
        return;
    }
    int x;
    cout << "Nhap so muon tim: ";
    cin >> x;
    for (int i = 0; i < n; i++)
    {
        if (x == a[i])
        {
            cout << "Tim thay X o vi tri thu " << i + 1;
            return;
        }
    }
    cout << "Khong tim thay X trong mang";
    _getch();
}

void swap(int &a, int &b)
{
    int tmp = a;
    a = b;
    b = tmp;
}

void tangMang(int a[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
            if (a[i] > a[j])
                swap(a[i], a[j]);
        }
    }
}

void timXNhiPhan(int a[], int n)
{
    if (n < 1)
    {
        cout << "Mang rong!!!";
        _getch();
        return;
    }
    int x;
    cout << "Nhap so muon tim: ";
    cin >> x;
    tangMang(a, n);
    xuatMang(a, n);
    int head = 0, tail = n - 1;
    while (tail >= head)
    {
        int mid = (head + tail) / 2;
        if (a[mid] == x)
        {
            cout << "Tim thay X o vi tri thu " << mid + 1;
            _getch();
            return;
        }
        else if (x < a[mid])
        {
            tail = mid - 1;
        }
        else
            head = mid + 1;
    }
    cout << "Khong tim thay X";
    _getch();
}