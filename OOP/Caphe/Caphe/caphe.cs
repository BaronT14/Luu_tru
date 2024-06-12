using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caphe{
    class Caphe
    {
        private string ma;
        private string ten;
        private int sl;
        private double dongia;
        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Sl { get => sl; set => sl = value; }
        public double Dongia { get => dongia; set => dongia = value; }

        public Caphe(){
            ma = "010";
            ten = "CoCo";
            sl = 100;
            dongia = 30000;
        }
        public virtual double thanhTien(){
            return Dongia * Sl;
        }
        public void xuat(){
            Console.Write($"\nMa: {Ma}\tTen: {Ten}\tSo luong: {Sl}\tDon gia: {Dongia}");
        }
    }
}

