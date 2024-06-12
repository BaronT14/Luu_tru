#include<stdio.h>
#include<conio.h>
#include<math.h>

//Thap Ha Noi
void chuyen(int n, char a, char b) {
	printf("Chuyen dia %d tu cot %c sang cot %c\n", n, a, b);
}

void thapHaNoi(int n, char dau, char trunggian, char dich) {
	if (n == 1)
		chuyen(n, dau, dich);
	else
	{
		thapHaNoi(n - 1, dau, dich, trunggian);
		chuyen(n, dau, dich);
		thapHaNoi(n - 1, trunggian, dau, dich);
	}
}


// Dat quan Hau
const int Nmax = 100;
int banCo[Nmax][Nmax];
void khoiTao(int banCo[][Nmax], int n) {
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			banCo[i][j] = 0;
		}
	}
}

bool check(int banCo[][Nmax], int n, int row, int col) {
	int i, j;
	for (i = 0; i < col; i++)
	{
		if (banCo[row][i] == 1)
			return false;
	}

	i = row, j = col;
	while (i >= 0 && j >= 0)
	{
		if (banCo[i][j] == 1)
			return false;
		i--;
		j--;
	}

	i = row, j = col;
	while (i < n && j >= 0)
	{
		if (banCo[i][j] == 1)
			return false;
		i++;
		j--;
	}
	return true;
}

bool datHau(int banCo[][Nmax], int n, int col) {
	if (col >= n) return true;
	for (int i = 0; i < n; i++)
	{
		if (check(banCo, n, i, col)){
			banCo[i][col] = 1;
			if (datHau(banCo, n, col + 1))
				return true;
			banCo[i][col] = 0;
		}
	}
	return false;
}

// Quan Ma di tuan
int X[8] = { -2,-2,-1,-1,1,1,2,2 }, Y[8] = { -1, 1, -2,2,-2,2,-1,1 };
int dem = 0;
void xuat(int n) {
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < n; j++)
		{
			printf("%4d", banCo[i][j]);
		}
		printf("\n");
	}
}

void diChuyen(int n, int x, int y) {
	++dem;
	banCo[x][y] = dem;
	for (int i = 0; i < n; i++)
	{
		if (dem == n * n){
			xuat(n);
			return;
		}
		int u = x + X[i];
		int v = y + Y[i];
		if (u >= 0 && u < n && v >= 0 && v < n && banCo[u][v] == 0)
			diChuyen(n, u, v);
	}
	--dem;
	banCo[x][y] = 0;
}

void main() {
	int c;
	printf("1 . Thap Ha Noi\n");
	printf("2 . Dat Quan Hau\n");
	printf("3 . Ma di tuan\n");
	printf("Nhap lua chon: "); scanf_s("%d", &c);
	switch (c)
	{
	case 1: {
		int n = 3;
		thapHaNoi(n, 'a', 'b', 'c');
	}break;
	case 2: {
		int n = 8;
		khoiTao(banCo, n);
		datHau(banCo, n, 0);
		for (int i = 0; i < n; i++)
		{
			for (int j = 0; j < n; j++)
			{
				printf("%2d", banCo[i][j]);
			}
			printf("\n");
		}
	}break;
	case 3: {
		int n = 8, x, y;
		khoiTao(banCo, n);
		printf("Vi tri bat day: "); scanf_s("%d%d", &x, &y);
		diChuyen(n, x, y);
	}break;
	default:
		break;
	}
	_getch();
}