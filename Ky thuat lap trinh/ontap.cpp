// Viết hàm đếm có bao nhiêu khoảng trắng trong chuỗi.
// 3. Nhập vào một chuỗi, xóa những khoảng trắng thừa trong chuỗi.
// 4. Viết hàm đổi những kí tự đầu tiên của mỗi từ thành chữ in hoa và
// những từ không phải đầu câu sang chữ thường
// 5. Viết chương trình tìm kiếm tên trong chuỗi họ tên. Nếu có thì xuất ra là
// tên này đã nhập đúng, ngược lại thông báo là đã nhập sai.
// 6. Viết hàm cắt chuỗi họ tên thành chuỗi họ lót và chuỗi tên.
// Ví dụ: chuỗi họ tên là: “Nguyễn Văn A” cắt ra 2 chuỗi là chuỗi họ lót:
// “NguyễnVăn” ,chuỗi tên là: “A”.

#include <conio.h>
#include <stdio.h>
#include <string.h>

int demKhoangTrang(char x[])
{
    int count = 0;
    for (int i = 0; i < strlen(x); i++)
    {
        if (x[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

void xoa(char s[90], int vitrixoa)
{
    int n = strlen(s);
    for (int i = vitrixoa; i < n; i++) // duyệt chuỗi từ vị trí cần xóa
        s[i] = s[i + 1];
    s[n - 1] = '\0'; // kết thúc
}

void xoakt(char *s)
{
    // xoa giữa
    for (int i = 0; i < strlen(s); i++)
    {
        if (s[i] == ' ' && s[i + 1] == ' ')
        {
            xoa(s, i);
            i--;
        }
    }
    if (s[0] == ' ')
        xoa(s, 0);
    if (s[strlen(s) - 1] == ' ')
        xoa(s, strlen(s) - 1);
}

void toupper(char x[])
{
    for (int i = 0; i < n - 1; i++)
    {
        if (a[i] == ' ' && a[i + 1] != ' ')
            a[i + 1] = toupper(a[i + 1]); // in hoa chữ cái đầu tiên mỗi từ
    }
}

int main()
{
    char x[30] = " Cho  Thinh ";
    xoakt(x);
    printf("%s", x);
    return 1;
    _getch;
}
