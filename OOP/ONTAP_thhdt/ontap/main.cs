using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLXD{
    class Program{
        public static void Main(string[] args){
            DS_HOADON ds = new DS_HOADON();
            ds.nhapXML("hoadon.xml");
            ds.ds_VANGLAI();


            Console.ReadKey();
        }
    }
}