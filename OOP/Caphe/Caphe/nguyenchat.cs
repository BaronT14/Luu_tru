using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caphe{
    class Nguyenchat : Caphe
    {
        public double congxay(){
            if(Sl < 100) return 100 * Sl;
            else return 90 * Sl;
        }
        public override double thanhTien()
        {
            return base.thanhTien() + congxay();
        }
        public new void xuat(){
            base.xuat();
            Console.Write($"\tThanh tien: {thanhTien()}");
        }
    }
}