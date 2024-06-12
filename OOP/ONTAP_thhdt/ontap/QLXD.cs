using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
#pragma warning disable CS8618
#pragma warning disable CS8600
#pragma warning disable CS8602
namespace QLXD{
    class XANGDAU{
        public string mahang, tenhang;
        double dongia;
        public double Dongia { get => dongia; set => dongia = value; }
        public XANGDAU(string mahang, string tenhang, double dongia){
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.dongia = dongia;
        }
    }

    abstract class HOADON{
        public string maso, hoten;
        XANGDAU mathang;
        DateTime ngaylap;
        int soluong;
        
        internal XANGDAU Mathang { get => mathang; set => mathang = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public HOADON(string maso, string hoten, XANGDAU mathang, DateTime ngaylap, int soluong){
            this.maso = maso;
            this.hoten = hoten;
            this.mathang = mathang;
            this.ngaylap = ngaylap;
            this.soluong = soluong;
        }

        public abstract double tinhThanhTien();
        public abstract double tienKhuyenMai();
        public double TongThanhTien(){
            return tinhThanhTien() - tienKhuyenMai();
        }
        public void xuat(){
            Console.WriteLine($"{mathang.mahang} | {mathang.tenhang} | {mathang.Dongia}");
            Console.WriteLine($"{maso} | {hoten} | {ngaylap.ToString("dd/MM/yyyy")} | {soluong} | {TongThanhTien()}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }

    class DS_HOADON{
        List<HOADON> dshd = new List<HOADON>();

        public void nhapXML(string file){
            XmlDocument r = new XmlDocument();
            r.Load(file);
            XmlNodeList list = r.SelectNodes("/dshd/HOADON");
            foreach (XmlNode node in list){
                HOADON hd;
                string loai = node["loai"].InnerText;
                string ms = node["ms"].InnerText;
                string ten = node["ten"].InnerText;
                DateTime ngaylap = DateTime.Parse(node["ngaylap"].InnerText);
                string mh = node["HANG"]["MH"].InnerText;
                string tenhang = node["HANG"]["tenHang"].InnerText;
                double dongia = double.Parse(node["HANG"]["dongia"].InnerText);
                XANGDAU hang = new XANGDAU(mh, tenhang, dongia);
                int soluong = int.Parse(node["soluong"].InnerText);
                if(loai == "1")
                    hd = new VIP(ms, ten, hang, ngaylap, soluong);
                else if(loai == "2")
                    hd = new THANTHIET(ms, ten, hang, ngaylap, soluong);
                else
                    hd = new VANGLAI(ms, ten, hang, ngaylap, soluong);
                dshd.Add(hd);
            }
        }

        public void xuatDS(){
            foreach(HOADON i in dshd){
                i.xuat();
            }
        }

        public void ds_VANGLAI(){
            List<VANGLAI> t = dshd.OfType<VANGLAI>().ToList();
            foreach(VANGLAI i in t){
                i.xuat();
            }
        }

        public void dem_VIP_THANTHIET(){
            int sl_VIP = dshd.OfType<VIP>().ToList().Count;
            int sl_THANTHIET = dshd.OfType<THANTHIET>().ToList().Count;
            Console.WriteLine("So luong VIP va THANTHIET: {0}", sl_THANTHIET + sl_VIP);
        }

        public void tongThanhTien_HD(){
            double tong = dshd.Sum(t => t.TongThanhTien());
            Console.WriteLine("Tong tien tat ca hoa don: {0}", tong);
        }

        public void ds_TTT_CaoNhat(){
            double max_TTT = dshd.Max(t => t.TongThanhTien());
            List<HOADON> t = dshd.Where(t => t.TongThanhTien() == max_TTT).ToList();
            foreach(HOADON i in t){
                i.xuat();
            }
        }

        public void tongTamUng(string hoten){
            List<THANTHIET> t = dshd.OfType<THANTHIET>().Where(t => t.hoten == hoten).ToList();
            Console.WriteLine("Tien tam ung tat ca hoa don: {0}", t.Sum(t => t.thanhToanTamUng()));
            foreach(THANTHIET i in t){
                Console.WriteLine(i.thanhToanTamUng());   
            }
        }

        public void sapXep(){
            List<HOADON> t = dshd.OrderBy(t => t.TongThanhTien()).ThenByDescending( t => t.maso).ToList();
            foreach(HOADON i in t){
                i.xuat();
            }
        }
    }
}