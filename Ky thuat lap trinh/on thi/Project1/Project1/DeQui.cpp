#include<stdio.h>
#include<conio.h>
#include<time.h>
#include<stdlib.h>
#include<math.h>

#define Nmax 100

void nhap(int a[], int n) {
	srand(time(NULL));
	for (int i = 0; i < n; i++)
	{
			int r = rand() % 5;
			a[i] = r;
	}
}

//Tong mang
int sumArr(int a[], int n) {
	if (n == 1) return a[n - 1];
	return sumArr(a, n - 1) + a[n - 1];
}

//Tich mang
int tichMang(int a[], int n) {
	if (n == 1) return a[n - 1];
	return tichMang(a, n - 1) * a[n - 1];
}

//Tim min
int timMin(int a[], int n) {
	if (n == 0) return -1;
	if (n == 1) return a[n - 1];
	if (a[n - 1] < timMin(a, n - 1))
		return a[n - 1];
	else
		return timMin(a, n - 1);
}

//Tim max
int timMax(int a[], int n) {
	if (n == 0) return -1;
	if (n == 1) return a[n - 1];
	if (a[n - 1] > timMax(a, n - 1))
		return a[n - 1];
	else
		return timMax(a, n - 1);
}

//dem phan tu duong
int demDuong(int a[], int n) {
	if (n == 0) return 0;
	if (a[n - 1] >= 0)
		return demDuong(a, n - 1) + 1;
	else
		return demDuong(a, n - 1);
}

// f(0)=f(1)=2, f(n)=2*f(n-1)*f(n-2)
int f1(int n) {
	if (n == 0 || n == 1) return 2;
	return 2 * f1(n - 1) * f1(n - 1);
}

int giaiThua(int n) {
	if (n == 0) return 1;
	return n * giaiThua(n - 1);
}

//Sn1
float Sn(int n) {
	if (n == 0) return 0;
	return Sn(n - 1) + ((n * giaiThua(n + 1))/((n+1)+sqrt(n+2)));
}

//x0 = 1, y0 = 0, xn = xn-1 + yn-1 với mọi n > 0 và yn = 3xn-1 + 2yn-1 với mọi n > 0::: Bai 10
int xn(int n);
int yn(int n);

int xn(int n) {
	if (n < 0) return -1;
	if (n == 0) return 1;
	return xn(n - 1) + yn(n - 1);
}
int yn(int n) {
	if (n < 0) return -1;
	if (n == 0) return 0;
	return 3*xn(n - 1) + 2*yn(n - 1);
}

//fibonaci
int fibonacci(int n) {
	if (n == 1 || n == 2) return 1;
	return fibonacci(n - 1) + fibonacci(n - 2);
}

bool soChinhPhuong(int n) {
	int x = int(sqrt(n));
	return x * x == n;
}

bool ktrFibonacci(int n) {
	// Một số n là số Fibonacci nếu và chỉ nếu ít nhất một trong các biểu thức (5n^2 + 4) hoặc (5n^2 - 4) là số chính phương.
	return soChinhPhuong(5 * n * n + 4) || soChinhPhuong(5 * n * n - 4);
}

int findFibonacci(int m) {
	if (ktrFibonacci(m - 1)) return m - 1;
	return findFibonacci(m - 1);
}

// nCk
int C(int n, int k) {
	if (k == 0 || n == k) return 1;
	if (k > 0 && k < n)
		return C(n - 1, k - 1) + C(n - 1, k);
}

void main() {
	int a[Nmax], n = 7;
	//nhap(a, n);
	printf("%d", C(15,7));

	//printf("\n");
	//for (int i = 0; i < n; i++)
	//{
	//	printf("%5d", a[i]);
	//}
	_getch();
}