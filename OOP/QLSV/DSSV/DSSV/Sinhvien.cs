using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSV
{
    class Sinhvien { 
        //thuoc tinh
        int mssv;
        String ho_ten;
        float diem;

        //ptkt khong tham so
        public Sinhvien()
        {
            this.mssv = 0;
            this.ho_ten = "";
            this.diem = 0;
        }

        public string Ho_ten { get => ho_ten; set => ho_ten = value; }
        public float Diem { get => diem; set => diem = value; }
        public int Mssv { get => mssv; set => mssv = value; }
        //phuong thuc
        public void nhap1sv()
        {
            Console.Write("Nhap ten sinh vien: ");
            this.ho_ten = Console.ReadLine();
            Console.Write("Nhap ma so sinh vien: ");
            this.mssv = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap diem so: ");
                this.diem = float.Parse(Console.ReadLine());
            } while (this.diem < 0 || this.diem > 10);
            
        }

        public void xuat1()
        {
            Console.WriteLine($"Hoten: {ho_ten}\n MSSV: {mssv}\n Diem: {diem}");
        }

    }
}
