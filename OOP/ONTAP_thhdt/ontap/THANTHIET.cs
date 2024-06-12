using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXD{
    class THANTHIET : HOADON, I_THANHTOAN{
        public THANTHIET(string maso, string hoten, XANGDAU mathang, DateTime ngaylap, int soluong)
            :base(maso, hoten, mathang, ngaylap, soluong){}
            
        public override double tinhThanhTien(){
            if(Soluong > 60) return Soluong * Mathang.Dongia * (1 - 0.04);
            return Soluong * Mathang.Dongia;
        }
        public override double tienKhuyenMai(){
            double thanhtien = tinhThanhTien();
            if(Soluong > 60) return 0;
            if(Soluong >= 50 && thanhtien >= 800000) return thanhtien * 0.03;
            return 0;
        }
        public double thanhToanTamUng(){
            return 0.6 * TongThanhTien();
        }
        public double tinhLaiXuatTraCham(){
            return 0.03 * (TongThanhTien() - thanhToanTamUng());
        }
    }
}