using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSV
{
    class DSSV
    {
        List<Sinhvien> dssv = new List<Sinhvien>();

        public List<Sinhvien> Dssv { get => dssv; set => dssv = value; }

        public void nhapnSV()
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) 
            {
                Sinhvien sv = new Sinhvien();
                sv.nhap1sv();
                dssv.Add(sv);
            }
        }
        public void xuatDS()
        {
            for (int i = 0; i < dssv.Count(); i++) 
            {
                dssv[i].xuat1();
            }
        }
        public void xuatDSLonHon8()
        {
            //for (int i = 0; i < dssv.Count(); i++)
            //{
            //    if (dssv[i].Diem > 8){
            //        dssv[i].xuat1();
            //    }
            //}
            foreach(var x in dssv)
            {
                if (x.Diem > 8)
                    x.xuat1();
            }
        }

    }
}
