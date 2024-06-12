//#include<stdio.h>
//#include<conio.h>
//#include<time.h>
//#include<stdlib.h>
//
//#define Nmax 100
//
//void nhap(int a[][Nmax], int n) {
//	srand(time(NULL));
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < n; j++)
//		{
//			int r = rand() % 100;
//			a[i][j] = r;
//		}
//	}
//}
//
//void swap(int& a, int& b) {
//	int tmp = a;
//	a = b;
//	b = tmp;
//}
//
//void interchangeSoft(int a[], int n) {
//	for (int i = 0; i < n - 1; i++)
//	{
//		for (int j = i + 1; j < n; j++)
//		{
//			if (a[i] > a[j])
//				swap(a[i], a[j]);
//		}
//	}
//}
//
//void sapXepTangDanZicZac(int a[][Nmax], int n) {
//	const int m = Nmax;
//	int tmp[m], i = 0;
//	for (int j = 0; j < n; j++)
//	{
//		for (int z = 0; z < n; z++)
//		{
//			tmp[i] = a[j][z];
//			i++;
//		}
//	}
//	interchangeSoft(tmp, n * n);
//	for (int i = 0; i < n*n; i++)
//	{
//		printf("%5d", tmp[i]);
//	}
//}
//
//void main() {
//	int a[Nmax][Nmax], n = 5;
//	nhap(a, n);
//	sapXepTangDanZicZac(a, n);
//	
//
//	printf("\n");
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < n; j++)
//		{
//			printf("%5d", a[i][j]);
//		}
//		printf("\n");
//	}
//	_getch();
//}