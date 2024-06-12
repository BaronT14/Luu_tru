#include<stdio.h>
#include<conio.h>
#include<string.h>
#include<time.h>

int namHienTai;

struct tuoiNH
{
	int tuoi, thang, nam;
};

struct date {
	int ngay, thang, nam;
};

struct member
{
	char hoTen[31];
	char gioiTinh[5];
	date ngaySinh;
};

void nhap(member &laoDong) {
		printf("Nhap Ho va Ten: ");
		gets_s(laoDong.hoTen);
		printf("Nhap gioi tinh: ");
		gets_s(laoDong.gioiTinh);
		printf("Nhap ngay thang nam sinh (dd/mm/yyyy): ");
		scanf_s("%d/%d/%d", &laoDong.ngaySinh.ngay, &laoDong.ngaySinh.thang, &laoDong.ngaySinh.nam);
}

tuoiNH tuoiNghiHuuLaoDongNam(member laoDong) {
	tuoiNH tuoiNghiHuu;
	if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 9) && laoDong.ngaySinh.nam == 1961) {
		tuoiNghiHuu.tuoi = 60;
		tuoiNghiHuu.thang = 3;
		tuoiNghiHuu.nam = 2021;
	}
	else if((laoDong.ngaySinh.thang >= 10 && laoDong.ngaySinh.nam == 1961) || (laoDong.ngaySinh.thang <= 6 && laoDong.ngaySinh.nam == 1962)){
		tuoiNghiHuu.tuoi = 60;
		tuoiNghiHuu.thang = 6;
		tuoiNghiHuu.nam = 2022;
	}
	else if((laoDong.ngaySinh.thang >= 7 && laoDong.ngaySinh.nam == 1962) || (laoDong.ngaySinh.thang <= 3 && laoDong.ngaySinh.nam == 1963)){
		tuoiNghiHuu.tuoi = 60;
		tuoiNghiHuu.thang = 9;
		tuoiNghiHuu.nam = 2023;
	}
	else if ((laoDong.ngaySinh.thang >= 4 || laoDong.ngaySinh.thang <= 12) && laoDong.ngaySinh.nam == 1963 ) {
		tuoiNghiHuu.tuoi = 61;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 2024;
	}
	else if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 9) && laoDong.ngaySinh.nam == 1964) {
		tuoiNghiHuu.tuoi = 61;
		tuoiNghiHuu.thang = 3;
		tuoiNghiHuu.nam = 2025;
	}
	else if((laoDong.ngaySinh.thang >= 10 && laoDong.ngaySinh.nam == 1964) || (laoDong.ngaySinh.thang <= 6 && laoDong.ngaySinh.nam == 1965)){
		tuoiNghiHuu.tuoi = 61;
		tuoiNghiHuu.thang = 6;
		tuoiNghiHuu.nam = 2026;
	}
	else if ((laoDong.ngaySinh.thang >= 7 && laoDong.ngaySinh.nam == 1965) || (laoDong.ngaySinh.thang <= 3 && laoDong.ngaySinh.nam == 1966)){
		tuoiNghiHuu.tuoi = 61;
		tuoiNghiHuu.thang = 9;
		tuoiNghiHuu.nam = 2027;
	}
	else if(laoDong.ngaySinh.thang >= 4 && laoDong.ngaySinh.nam >= 1966){
		tuoiNghiHuu.tuoi = 62;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 62 - (namHienTai - laoDong.ngaySinh.nam) + namHienTai;
	}
	return tuoiNghiHuu;
}

tuoiNH tuoiNghiHuuLaoDongNu(member laoDong) {
	tuoiNH tuoiNghiHuu;
	if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 8) && laoDong.ngaySinh.nam == 1966) {
		tuoiNghiHuu.tuoi = 55;
		tuoiNghiHuu.thang = 4;
		tuoiNghiHuu.nam = 2021;
	}
	else if ((laoDong.ngaySinh.thang >= 9 && laoDong.ngaySinh.nam == 1966) || (laoDong.ngaySinh.thang <= 4 && laoDong.ngaySinh.nam == 1967)) {
		tuoiNghiHuu.tuoi = 55;
		tuoiNghiHuu.thang = 8;
		tuoiNghiHuu.nam = 2022;
	}
	else if ((laoDong.ngaySinh.thang >= 5 || laoDong.ngaySinh.thang <= 12) && laoDong.ngaySinh.nam == 1967) {
		tuoiNghiHuu.tuoi = 56;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 2023;
	}
	else if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 8) && laoDong.ngaySinh.nam == 1968) {
		tuoiNghiHuu.tuoi = 56;
		tuoiNghiHuu.thang = 4;
		tuoiNghiHuu.nam = 2024;
	}
	else if ((laoDong.ngaySinh.thang >= 9 && laoDong.ngaySinh.nam == 1968) || (laoDong.ngaySinh.thang <= 5 && laoDong.ngaySinh.nam == 1969)) {
		tuoiNghiHuu.tuoi = 56;
		tuoiNghiHuu.thang = 8;
		tuoiNghiHuu.nam = 2025;
	}
	else if ((laoDong.ngaySinh.thang >= 6 || laoDong.ngaySinh.thang <= 12) && laoDong.ngaySinh.nam == 1969) {
		tuoiNghiHuu.tuoi = 57;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 2026;
	}
	else if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 8) && laoDong.ngaySinh.nam == 1970) {
		tuoiNghiHuu.tuoi = 57;
		tuoiNghiHuu.thang = 4;
		tuoiNghiHuu.nam = 2027;
	}
	else if ((laoDong.ngaySinh.thang >= 9 && laoDong.ngaySinh.nam == 1970) || (laoDong.ngaySinh.thang <= 4 && laoDong.ngaySinh.nam == 1971)) {
		tuoiNghiHuu.tuoi = 57;
		tuoiNghiHuu.thang = 8;
		tuoiNghiHuu.nam = 2028;
	}
	else if ((laoDong.ngaySinh.thang >= 5 || laoDong.ngaySinh.thang <= 12) && laoDong.ngaySinh.nam == 1971) {
		tuoiNghiHuu.tuoi = 58;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 2029;
	}
	else if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 8) && laoDong.ngaySinh.nam == 1972) {
		tuoiNghiHuu.tuoi = 58;
		tuoiNghiHuu.thang = 4;
		tuoiNghiHuu.nam = 2030;
	}
	else if ((laoDong.ngaySinh.thang >= 9 && laoDong.ngaySinh.nam == 1972) || (laoDong.ngaySinh.thang <= 4 && laoDong.ngaySinh.nam == 1973)) {
		tuoiNghiHuu.tuoi = 58;
		tuoiNghiHuu.thang = 8;
		tuoiNghiHuu.nam = 2031;
	}
	else if ((laoDong.ngaySinh.thang >= 5 || laoDong.ngaySinh.thang <= 12) && laoDong.ngaySinh.nam == 1973) {
		tuoiNghiHuu.tuoi = 59;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 2032;
	}
	else if ((laoDong.ngaySinh.thang >= 1 || laoDong.ngaySinh.thang <= 8) && laoDong.ngaySinh.nam == 1974) {
		tuoiNghiHuu.tuoi = 59;
		tuoiNghiHuu.thang = 4;
		tuoiNghiHuu.nam = 2033;
	}
	else if ((laoDong.ngaySinh.thang >= 9 && laoDong.ngaySinh.nam == 1974) || (laoDong.ngaySinh.thang <= 4 && laoDong.ngaySinh.nam == 1975)) {
		tuoiNghiHuu.tuoi = 59;
		tuoiNghiHuu.thang = 8;
		tuoiNghiHuu.nam = 2034;
	}
	else if (laoDong.ngaySinh.thang >= 5 && laoDong.ngaySinh.nam >= 1975) {
		tuoiNghiHuu.tuoi = 60;
		tuoiNghiHuu.thang = 0;
		tuoiNghiHuu.nam = 60 - (namHienTai - laoDong.ngaySinh.nam) + namHienTai;
	}
	return tuoiNghiHuu;
}

void thoiGianNghiHuu(member laoDong) {
	int tuoi = namHienTai - laoDong.ngaySinh.nam;
	try
	{
		if (strcmp(laoDong.gioiTinh, "Nam") != 0 && strcmp(laoDong.gioiTinh, "Nu") != 0)
		{
			throw 102;
		}
		if (tuoi <= 18 || (strcmp(laoDong.gioiTinh, "Nam") == 0 && tuoi >= 62) || (strcmp(laoDong.gioiTinh, "Nu") == 0 && tuoi >= 60))
		{
			throw 101;
		}
	}
	catch (int errcode)
	{
		if (errcode == 101)
		{
			printf("101 !!! Khong thuoc do tuoi lao dong");
		}
		if (errcode == 102)
		{
			printf("errcode !!! Khong xac dinh duoc gioi tinh");
		}
		return;
	}
	if (strcmp(laoDong.gioiTinh, "Nam") == 0) {
		tuoiNH tuoiNghiHuu = tuoiNghiHuuLaoDongNam(laoDong);
		printf("Do tuoi duoc nghi huu: %d tuoi %d thang, nam %d", tuoiNghiHuu.tuoi, tuoiNghiHuu.thang, tuoiNghiHuu.nam);
	}
	else
	{
		tuoiNH tuoiNghiHuu = tuoiNghiHuuLaoDongNu(laoDong);
		printf("Do tuoi duoc nghi huu: %d tuoi %d thang, nam %d", tuoiNghiHuu.tuoi, tuoiNghiHuu.thang, tuoiNghiHuu.nam);
	}
}

void main() {
	member laoDong;
	time_t t = time(NULL);
	struct tm* now = localtime(&t);
	namHienTai = now->tm_year + 1900;

	nhap(laoDong);
	thoiGianNghiHuu(laoDong);
	_getch();
}