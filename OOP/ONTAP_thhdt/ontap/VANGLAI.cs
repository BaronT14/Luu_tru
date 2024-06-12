using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXD{
    class VANGLAI : HOADON{
        public VANGLAI(string maso, string hoten, XANGDAU mathang, DateTime ngaylap, int soluong)
            :base(maso, hoten, mathang, ngaylap, soluong){}
        public override double tinhThanhTien(){
            return Soluong * Mathang.Dongia;
        }

        public override double tienKhuyenMai(){
            double thanhtien = tinhThanhTien();
            if(thanhtien > 1000000) return thanhtien * 0.03;
            return 0;
        }
    }
    
}