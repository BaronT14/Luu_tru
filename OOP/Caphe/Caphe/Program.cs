using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using caphe;

namespace program{
    class Program{
        public static void Main(string[] args){
            Hat h = new Hat();
            Nguyenchat nc = new Nguyenchat();
            h.xuat();
            nc.xuat();
            Console.ReadKey();
        }
    }
}