using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Lythuyet : Abstract_class
    {
        double dTL;
        double dCK;

        public Lythuyet() : base()
        {
            dTL = 8;
            dCK = 8.5;
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine($"{dTL}\t{dCK}\t{diemChu()}");
        }
        public override double DTB()
        {
            return dTL * 0.3 + dCK * 0.7;
        }
    }
}
