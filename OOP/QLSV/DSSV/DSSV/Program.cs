using DSSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSV
{
    class mainMethod
    {
        public static void Main(String[] args)
        {
            DSSV ds = new DSSV();

            ds.nhapnSV();
            ds.xuatDSLonHon8();

            Console.ReadKey();
        }
    }
}