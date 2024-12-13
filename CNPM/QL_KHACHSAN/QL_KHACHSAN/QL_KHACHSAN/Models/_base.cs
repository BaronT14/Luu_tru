using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QL_KHACHSAN.Models
{
    public class _base
    {
        public static dataDataContext db = new dataDataContext();
        public static string GetLastName(string fullName)
        {
            string[] nameParts = fullName.Trim().Split(' ');
            return nameParts[nameParts.Length - 1];
        }

        public static string taoMa()
        {
            Random rd = new Random();
            string rs = rd.Next(10000, 99999).ToString() + rd.Next(10000, 99999).ToString();
            return rs;
        }

        public static decimal soTienCTHD(decimal giaph, DateTime ngaynhan, DateTime ngaytra)
        {
            int songay = (ngaytra - ngaynhan).Days;
            return giaph * songay;
        }

        public static HOADON taoHoaDon(string makh, string maks, string mapt, string manv, List<ct_doi> dshd, List<CTDV> ctdv = null, double? tientra = null)
        {
            HOADON hd = new HOADON();
            hd.MAKH = makh;
            hd.MAKS = maks;
            hd.MANV = manv;
            hd.MAPT = mapt;
            hd.DATRA = (decimal?)tientra;
            hd.NGAYDAT = DateTime.Now.ToLocalTime();
            if(hd.DATRA == null)
            {
                hd.TINHTRANG = "Chưa thanh toán";
            }
            else
            {
                hd.NGAYTHANHTOAN = DateTime.Now.ToLocalTime();
            }
            while (true)
            {
                string tmp = taoMa();
                if (db.HOADONs.SingleOrDefault(t => t.MAHD == tmp) == null)
                {
                    hd.MAHD = tmp;
                    break;
                }
            }
            db.HOADONs.InsertOnSubmit(hd);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var I in dshd)
            {
                CTHD ct = I.CTHD;
                ct.MAHD = hd.MAHD;
                db.CTHDs.InsertOnSubmit(ct);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (ctdv != null)
            {
                foreach (var II in ctdv)
                {
                    CTDV ct = new CTDV();
                    ct.MAHD = hd.MAHD;
                    ct.MADV = II.MADV;
                    ct.SOLUONG = II.SOLUONG;
                    db.CTDVs.InsertOnSubmit(ct);
                }
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return hd;
        }

        public static KHACHHANG layKH(string chuoiTim)
        {
            string phoneNumber;
            try
            {
                string[] parts = chuoiTim.Split('-');
                phoneNumber = parts[1].Trim();
            }
            catch { phoneNumber = chuoiTim; }
            return db.KHACHHANGs.SingleOrDefault(t => t.SDT == phoneNumber);
        }

        public static string layHD(string chuoiTim)
        {
            string mahd;
            try
            {
                string[] parts = chuoiTim.Split('-');
                mahd = parts[1].Trim();
            }
            catch { mahd = chuoiTim; }
            return mahd;
        }

        public static DICHVU layDV(string chuoiTim)
        {
            string[] parts = chuoiTim.Split('-');
            string maDV = parts[0].Trim();
            return db.DICHVUs.SingleOrDefault(t => t.MADV == maDV);
        }
    }
}