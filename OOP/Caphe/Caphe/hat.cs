using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caphe
{
    class Hat : Caphe, Hotro
    {
        public Hat() : base() { }
        public override double thanhTien()
        {
            return base.thanhTien();
        }
        public double kpht()
        {
            return Sl * 10;
        }
        public new void xuat()
        {
            base.xuat();
            Console.Write($"\tThanh tien: {thanhTien()}\tKinh phi ho tro: {kpht()}");
        }
    }
}