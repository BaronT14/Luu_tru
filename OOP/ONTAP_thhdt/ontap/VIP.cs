using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXD{
    class VIP : HOADON, I_THANHTOAN{
        public VIP(string maso, string hoten, XANGDAU mathang, DateTime ngaylap, int soluong)
            :base(maso, hoten, mathang, ngaylap, soluong){}
        public override double tinhThanhTien(){
            if(Soluong > 50) return Soluong * Mathang.Dongia * (1 - 0.05);
            return Soluong * Mathang.Dongia;
        }

        public override double tienKhuyenMai(){
            double thanhtien = tinhThanhTien();
            if(Soluong > 50) return 0;
            if(Soluong <= 50 && thanhtien >= 600000)
                return 0.04 * thanhtien;
            if(Soluong < 10) return 0;
            return 0.01 * thanhtien;
        }

        public double thanhToanTamUng(){
            return TongThanhTien() * 0.4;
        }

        public double tinhLaiXuatTraCham(){
            return 0.02 * (TongThanhTien() - thanhToanTamUng());
        }
    }
}