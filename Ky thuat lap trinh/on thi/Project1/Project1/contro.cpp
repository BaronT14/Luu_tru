//#include<stdio.h>
//#include<conio.h>
//#include<stdlib.h>
//#include<time.h>
//#include<math.h>
//
//void nhap(int *a, int n) {
//	srand(time(NULL));
//	int r;
//	for (int i = 0; i < n; i++)
//	{
//		r = rand() % 10;
//		*(a + i) = r;
//	}
//}
//
//bool ktrSNT(int* a) {
//	for (int i = 2; i <= sqrt(*a); i++){
//		if (*a % i == 0)
//			return false;
//	}
//	return true;
//}
//
//void xuatSNT(int* a, int n) {
//	for (int i = 0; i < n; i++)
//	{
//		if (ktrSNT((a + i)))
//			printf("%5d", *(a + i));
//	}
//}
//
//void xuatPhanThapPhan(float* a, int n) {
//	for (int i = 0; i < n; i++)
//	{
//		int phanNguyen = (int)*(a + i);
//		printf("%f\n", *(a + i) - phanNguyen);
//	}
//}
//
//int ktrSo2(float* a) {
//	int phanNguyen = (int)*a;
//	while (phanNguyen != 0)
//	{
//		if (phanNguyen % 10 == 2)
//		{
//			return 1;
//		}
//		phanNguyen /= 10;
//	}
//	return 0;
//}
//
//void xoaPhanTuLe(int* a, int &n) {
//	for (int i = 0; i < n; i++)
//	{
//		if (*(a + i) % 2 != 0) {
//			for (int j = i ; j < n; j++)
//			{
//				*(a + j) = *(a + j + 1);
//			}
//			n--;
//			i--;
//		}
//	}
//}
//
//int findMax(int* a, int n) {
//	int imax = 0;
//	for (int i = 1; i < n; i++)
//	{
//		if (*(a + i) > *(a + imax))
//			imax = i;
//	}
//	return imax;
//}
//
//void themXTruocMax(int* a, int& n, int x) {
//	int imax = findMax(a, n);
//	for (int i = n ; i >= imax; i--)
//	{
//		*(a + i) = *(a + i - 1);
//	}
//	n++;
//	*(a + imax) = x;
//}
//
//void themXSauMax(int* a, int& n, int x) {
//	int imax = findMax(a, n);
//	for (int i = n; i > imax; i--)
//	{
//		*(a + i) = *(a + i - 1);
//	}
//	n++;
//	*(a + imax + 1) = x;
//}
//
//void swap(int& a, int& b) {
//	int tmp = a;
//	a = b;
//	b = tmp;
//}
//
//void interchangeSoft(int* a, int n) {
//	for (int i = 0; i < n - 1; i++)
//	{
//		for (int j = i+1; j < n; j++){
//			if (*(a + i) > *(a + j))
//				swap(*(a + i), *(a + j));
//		}
//	}
//}
//
//void selectSoft(int* a, int n) {
//	for (int i = 0; i < n - 1; i++)
//	{
//		int imin = i;
//		for (int j = i + 1; j < n; j++)
//		{
//			if (*(a + imin) > *(a + j))
//				imin = j;
//		}
//		swap(*(a + imin), *(a + i));
//	}
//}
//
//int timKiemNhiPhan(int* a, int n, int x) {
//	selectSoft(a, n);
//	int left = 0, right = n - 1, mid;
//	while (left < right)
//	{
//		mid = (left + right) / 2;
//		if (*(a + mid) == x)
//			return 1;
//		else if (x > *(a + mid)) {
//			left = mid + 1;
//		}
//		else if (x < *(a + mid)) {
//			right = mid - 1;
//		}
//	}
//	return 0;
//}
//
//int timKiemNhiPhan1(int* a, int n, int left, int right, int x) {
//	selectSoft(a, n);
//	int mid = (left + right) / 2;
//	if (left > right)
//		return 0;
//	if (x == *(a + mid))
//		return 1;
//	if (x > *(a + mid))
//		return timKiemNhiPhan1(a, n, mid + 1, right, x);
//	if (x < *(a + mid))
//		return timKiemNhiPhan1(a, n, left, mid - 1, x);
//}
//
//void main() {
//	int a[100];
//	int n = 5;
//	int* pa;
//	pa = &a[0];
//	nhap(pa, n);
//
//	printf("%d", timKiemNhiPhan1(pa, n, 0, n - 1, 5));
//
//
//	printf("\n");
//	for (int i = 0; i < n; i++)
//	{
//		printf("%5d", *(pa + i));
//	}
//
//	_getch();
//}