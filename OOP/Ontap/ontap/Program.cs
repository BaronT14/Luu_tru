using System;
using System.Text.RegularExpressions;


namespace hopdong{
    abstract class Hopdongcasi{
        string mahd;
        string tencasi;
        int sotm;
        DateTime ngaybd;
        double dongia;
        double phuphi;
        public static double tileThue;

        public string Mahd { 
            get {return mahd;}
            set {
                mahd = value;
                if(mahd[0] == 'H' && mahd[1] == 'D' && mahd.Length == 6)
                    throw new Exception("Ma hop dong khong dung");} }
        public string Tencasi { get => tencasi; set => tencasi = value; }
        public int Sotm { get => sotm; set => sotm = value; }
        
        public double Dongia { get => dongia; set { dongia = value; if(dongia < 0) throw new Exception("Don gia am");}}
        public double Phuphi { get => phuphi; set => phuphi = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }

        public Hopdongcasi(){
            mahd = "HD3418";
            tencasi = "Ly Khong Hay";
            sotm = 3;
            DateTime date = new DateTime(2020,10,24);
            Ngaybd = date;
            dongia = 4000000;
            phuphi = 2000000;
        }
        public double tinhTT(){
            return sotm * dongia + phuphi + tinhQC();
        }
        public abstract double tinhQC();
        public double tinhThue(){
            return tileThue * tinhTT();
        }
    }
}