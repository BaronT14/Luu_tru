using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Thuchanh : Abstract_class
    {
        double c1;
        double c2;
        double c3;
        public Thuchanh() : base()
        {
            c1 = 9;
            c2 = 9;
            c3 = 9;
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"{c1}\t{c2}\t{c3}\t{diemChu()}");
        }
        public override double DTB()
        {
            return (c1 + c2 + c3) / 3;
        }
    }
}
