using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class main
    {
        public static void Main(string[] args)
        {
            Lythuyet lt = new Lythuyet();
            Thuchanh th = new Thuchanh();
            lt.xuat();
            th.xuat();
            Console.ReadKey();
        }
    }
}