using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    abstract class Abstract_class
    {
        private string mamh;
        private string tenmh;
        private int soTC;

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public void xuat()
        {
            Console.WriteLine($"{mamh}\t{tenmh}\t{soTC}");
        }
        public Abstract_class()
        {
            mamh = "001";
            tenmh = "JJJ";
            soTC = 3;
        }
        public abstract double DTB();
        public string diemChu()
        {
            double dtb = DTB();
            if (dtb < 4) return "F";
            if (dtb <= 4.9) return "D";
            if (dtb <= 5.4) return "D+";
            if (dtb <= 6.4) return "C";
            if (dtb <= 6.9) return "C+";
            if (dtb <= 7.9) return "B";
            if (dtb <= 8.4) return "B+";
            if (dtb <= 9.4) return "A";
            else return "A+";
        }
    }
}
