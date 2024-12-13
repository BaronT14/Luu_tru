using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using QL_KHACHSAN.Models;

namespace QL_KHACHSAN.Controllers
{
    public class HomeController : Controller
    {
        dataDataContext db = new dataDataContext();
        public bool ktrDN()
        {
            if(Session["DN"] != null)
                return true;
            return false;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DangNhap()
        {
            ViewBag.kq = 0;
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string tendn, string mk)
        {
            TAIKHOAN tk = db.TAIKHOANs.SingleOrDefault(t => t.TENDN == tendn && t.MK == mk);
            if(tk != null)
                Session["DN"] = db.NHANVIENs.SingleOrDefault(t => t.MANV == tk.MANV);
            if (ktrDN())
            {
                Session["newDN"] = 1;
                return RedirectToAction("Index");
            }
            else
                Session["newDN"] = -1;
            return RedirectToAction("DangNhap");
        }

        public ActionResult DangXuat()
        {
            Session["DN"] = null;
            return RedirectToAction("Index");
        }

        public ActionResult QL_DatPhong()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            if(TempData["dsp"] != null)
                ViewBag.dsp = TempData["dsp"] as List<PHONG>;
            List<HOADON> hd = db.HOADONs.ToList();
            List<string> dshd = new List<string>();
            foreach(var i in hd)
            {
                string tmp = i.KHACHHANG.TENKH + " - " + i.MAHD;
                dshd.Add(tmp);
            }
            ViewBag.dshd = dshd;
            return View();
        }

        public ActionResult ht_LoaiPhong()
        {
            return View(db.LOAIPHONGs.ToList());
        }

        public ActionResult ht_Tang(List<PHONG> dsp)
        {
            ViewBag.ks = db.KHACHSANs.SingleOrDefault(t => t.MAKS == "KS000");
            ViewBag.dsp = dsp;
            return View();
        }

        public ActionResult ht_Phong(int tang, List<PHONG> dsp)
        {
            if (dsp.Count == 0)
                dsp = db.PHONGs.ToList();
            return View(dsp.Where(t=>t.TANG == tang).ToList());
        }

        public ActionResult ht_Phong_Loai(string MaLoai)
        {
            List<PHONG> dsp = db.PHONGs.Where(t => t.MALOAI == MaLoai).ToList();
            TempData["dsp"] = dsp;
            return RedirectToAction("QL_DatPhong");
        }

        public ActionResult ht_Phong_KhoangGia(double minPr, double maxPr)
        {
            List<PHONG> dsp = db.PHONGs.Where(t => t.GIAPHONG <= (decimal)minPr && t.GIAPHONG <= (decimal)maxPr).ToList();
            TempData["dsp"] = dsp;
            return RedirectToAction("QL_DatPhong");
        }
        // Thêm khách hàng
        public ActionResult ThemKhachHang()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemKhachHang(KHACHHANG kh, string Quoctich, string gioitinh = "Nam")
        {
            if (kh != null)
            {
                string tmp;
                while (true)
                {
                    tmp = _base.taoMa();
                    if(db.KHACHHANGs.SingleOrDefault(t=>t.MAKH == tmp) == null)
                    {
                        break;
                    }
                }
                kh.MAKH = tmp;
                kh.GTINH = gioitinh;
                db.KHACHHANGs.InsertOnSubmit(kh);
                try
                {
                    db.SubmitChanges();
                    TempData["loi"] = (dynamic)0;
                }
                catch (System.Data.SqlClient.SqlException sqlEx) { TempData["loi"] = sqlEx.Number; }
            }
            return View();
        }


        //Dặt phòng
        public ActionResult GioHang()
        {
            var ds = Session["DSCT"] as List<ct_doi>;
            ViewBag.sl = ds != null ? ds.Count : 0;
            return View();
        }

        public ActionResult DatPhong(string maphong)
        {
            ViewBag.ph = db.PHONGs.SingleOrDefault(t => t.MAPH == maphong);
            return View();
        }
        [HttpPost]
        public ActionResult DatPhong(string maphong, CTHD cthd)
        {
            List<ct_doi> dsct = Session["DSCT"] as List<ct_doi>;
            if (dsct == null || dsct.Count == 0)
            {
                dsct = new List<ct_doi>();
            }
            ct_doi tmp = new ct_doi();
            tmp.PHONG = db.PHONGs.SingleOrDefault(t => t.MAPH == maphong);
            
            cthd.MAPH = maphong;
            try
            {
                cthd.THANHTIEN = _base.soTienCTHD(tmp.PHONG.GIAPHONG.Value, cthd.NGAYNHAN.Value, cthd.NGAYTRA.Value);
            }
            catch {  }

            tmp.CTHD = cthd;
            if (tmp.CTHD.NGAYNHAN.HasValue)
            {
                tmp.CTHD.NGAYNHAN = tmp.CTHD.NGAYNHAN.Value.AddHours(14);
            }

            if (tmp.CTHD.NGAYTRA.HasValue)
            {
                tmp.CTHD.NGAYTRA = tmp.CTHD.NGAYTRA.Value.AddHours(12);
            }
            dsct.Add(tmp);
            Session["DSCT"] = dsct;
            TempData["themthanhcong"] = true;
            return RedirectToAction("QL_DatPhong");
        }

        public ActionResult ds_Cho()
        {
            List<string> dskh = new List<string>();
            List<KHACHHANG> kh = db.KHACHHANGs.ToList();
            foreach(var k in kh)
            {
                string temp = k.TENKH + " - " + k.SDT;
                dskh.Add(temp);
            }
            ViewBag.dskh = dskh;
            List<ct_doi> dsct = Session["DSCT"] as List<ct_doi>;
            if(dsct == null || dsct.Count == 0)
            {
                Session["DSCT"] = null;
                ViewBag.kq = 0;
            }
            return View();
        }

        public ActionResult XoaCTHD(string maph)
        {
            List<ct_doi> dsct = Session["DSCT"] as List<ct_doi>;
            ct_doi ct = dsct.SingleOrDefault(t => t.CTHD.MAPH == maph);
            dsct.Remove(ct);
            if(dsct.Count == 0)
            {
                return RedirectToAction("XoaCTHD_all");
            }
            return RedirectToAction("ds_Cho");
        }

        public ActionResult XoaCTHD_all()
        {
            Session["DSCT"] = null;
            Session["CTDV"] = null;
            Session["SDT_KH"] = null;
            TempData["KQ_XOA_ALL"] = true;
            return RedirectToAction("QL_DatPhong");
        }

        public ActionResult DS_DichVu()
        {
            List<CTDV> ctdv = Session["CTDV"] as List<CTDV>;
            if( ctdv == null || ctdv.Count == 0 )
            {
                Session["CTDV"] = null;
                ViewBag.kq = 0;
            }
            List<string> dsdv = new List<string>();
            List<DICHVU> dv = db.DICHVUs.ToList();
            foreach(var i in dv)
            {
                string tmp = i.MADV + " - " + i.TENDV;
                dsdv.Add(tmp);
            }
            ViewBag.dsdv = dsdv;
            return View();
        }

        public ActionResult XoaCTDV(string madv)
        {
            List<CTDV> ctdv = Session["CTDV"] as List<CTDV>;
            CTDV ct = ctdv.SingleOrDefault(t => t.MADV == madv);
            ctdv.Remove(ct);
            if (ctdv.Count == 0)
            {
                return RedirectToAction("XoaCTDV_all");
            }
            return RedirectToAction("DS_DichVu");
        }

        public ActionResult XoaCTDV_all()
        {
            Session["CTDV"] = null;
            TempData["KQ_XOA_ALL"] = true;
            return RedirectToAction("DS_DichVu");
        }

        public ActionResult SL_DichVu()
        {
            List<CTDV> ctdv = Session["CTDV"] as List<CTDV>;
            if (ctdv == null || ctdv.Count == 0)
            {
                ViewBag.kq = 0;
                return View();
            }
            ViewBag.kq = ctdv.Count;
            return View();
        }

        public ActionResult ThemDichVu(string dv, int sl)
        {
            List<CTDV> ctdv = Session["CTDV"] as List<CTDV>;
            if (ctdv == null || ctdv.Count == 0)
            {
                ctdv = new List<CTDV>();
            }
            var temp = ctdv.Find(t => t.MADV == _base.layDV(dv).MADV);
            if (temp != null)
            {
                temp.SOLUONG += sl;
            }
            else
            {
                CTDV ct = new CTDV();
                ct.MADV = _base.layDV(dv).MADV;
                ct.SOLUONG = sl;
                ct.DICHVU = db.DICHVUs.SingleOrDefault(t => t.MADV == ct.MADV);
                ctdv.Add(ct);
            }
            Session["CTDV"] = ctdv;
            TempData["KQ_THEM_DV"] = 1;
            return RedirectToAction("DS_DichVu");
        }

        public ActionResult ThanhToan(string kh = null, string mahd = null)
        {
            KHACHHANG user = null;
            List<ct_doi> dsct;
            List<CTDV> ctdv;
            if(kh == null)
            {
                kh = Session["SDT_KH"] as string;
            }
            if (mahd == null)
            {
                dsct = Session["DSCT"] as List<ct_doi>;
                ctdv = Session["CTDV"] as List<CTDV>;
                try
                {
                    user = _base.layKH(kh);
                }
                catch {  }
                if (user == null)
                {
                    TempData["kh"] = -1;
                    return RedirectToAction("ds_Cho");
                }
            }
            else {
                string ma_hd = _base.layHD(mahd);
                dsct = new List<ct_doi>();
                List<CTHD> dsct_db = db.CTHDs.Where(t => t.MAHD == ma_hd).ToList();
                foreach(var i in dsct_db)
                {
                    ct_doi t = new ct_doi();
                    t.CTHD = i;
                    t.PHONG = db.PHONGs.SingleOrDefault(k => k.MAPH == i.MAPH);
                    dsct.Add(t);
                }
                ViewBag.luu = 1;
                ctdv = db.CTDVs.Where(t => t.MAHD == ma_hd).ToList();
                HOADON hd = db.HOADONs.SingleOrDefault(t => t.MAHD == ma_hd);
                user = db.KHACHHANGs.SingleOrDefault(t => t.MAKH == hd.MAKH);
                ViewBag.hoadon = hd;
            }
            ViewBag.dsct = dsct;
            ViewBag.ctdv = ctdv;
            ViewBag.pttt = db.PHUONGTHUCTHANHTOANs.ToList();
            ViewBag.ctkh = db.CHITIETKHs.Where(t => t.MAHD == _base.layHD(mahd)).ToList();
            try
            {
                ViewBag.sl = dsct.Count + ctdv.Count;
            }
            catch { ViewBag.sl = dsct.Count; }
            return View(user);
        }

        public ActionResult LuuHoaDon(string mapt = "PT001", double? tientra = null)
        {
            KHACHHANG kh = _base.layKH(Session["SDT_KH"] as string);
            NHANVIEN nv = Session["DN"] as NHANVIEN;
            List<ct_doi> dsct = Session["DSCT"] as List<ct_doi>;
            List<CTDV> dsdv = Session["CTDV"] as List<CTDV>;
            try
            {
                if(tientra == 0)
                {
                    tientra = null;
                }
                HOADON hd = _base.taoHoaDon(kh.MAKH, "KS000", mapt, nv.MANV, dsct, dsdv, tientra);
                hd = db.HOADONs.SingleOrDefault(t => t.MAHD == hd.MAHD);
                if (hd.DATRA == hd.TONGTIEN)
                {
                    hd.TINHTRANG = "Đã thanh toán";
                }
                db.SubmitChanges();
                Session["DSCT"] = null;
                Session["CTDV"] = null;
                Session["SDT_KH"] = null;
                TempData["KQ_TAO_HD"] = 1;
                object tmp = TempData["tt"];
                if (tmp == (object)1) { TempData["tt"] = 1;  return RedirectToAction("ThanhToan", new { mahd = hd.MAHD }); }
                return RedirectToAction("QL_DatPhong");
            }
            catch { TempData["KQ_TAO_HD"] = -1; return RedirectToAction("ds_Cho"); }
        }

        public ActionResult luuSessionKH(string kh)
        {
            Session["SDT_KH"] = kh;
            return RedirectToAction("ds_Cho");
        }

        public ActionResult NhanTraHuyPhong(string mahd)
        {
            ViewBag.hd = db.HOADONs.SingleOrDefault(t => t.MAHD == mahd);
            ViewBag.dsct = db.CTHDs.Where(t => t.MAHD == mahd).ToList();
            ViewBag.ctdv = db.CTDVs.Where(t => t.MAHD == mahd).ToList();
            return View(ViewBag.dsct);
        }

        public ActionResult NhanPhong(string maph, string mahd)
        {
            ViewBag.ctkh = db.CHITIETKHs.Where(t => t.MAHD == mahd).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult NhanPhong(string maph, string mahd, CHITIETKH ctkh, string gioitinh)
        {
            ctkh.GIOITINH = gioitinh;
            ctkh.MAHD = mahd;
            db.CHITIETKHs.InsertOnSubmit(ctkh);

            CTHD p = db.CTHDs.SingleOrDefault(t => t.MAHD == mahd && t.MAPH == maph);
            p.TINHTRANG = "Đã nhận phòng";
            PHONG ph = p.PHONG;
            ph.TINHTRANG = "Đang sử dụng";
            ViewBag.mahd = mahd;
            db.SubmitChanges();
            ViewBag.kq = 1;
            return View();
        }

        public ActionResult LuuCTKH(string maph, string mahd, CHITIETKH ctkh, string gioitinh)
        {
            List<CHITIETKH> ds_ctkh = db.CHITIETKHs.Where(t => t.MAHD == mahd).ToList();
            if (ds_ctkh == null || ds_ctkh.Count == 0)
            {
                ds_ctkh = new List<CHITIETKH>();
            }
            ctkh.GIOITINH = gioitinh;
            ctkh.MAHD = mahd;
            ds_ctkh.Add(ctkh);

            CTHD p = db.CTHDs.SingleOrDefault(t => t.MAHD == mahd && t.MAPH == maph);
            p.TINHTRANG = "Đã nhận phòng";
            PHONG ph = p.PHONG;
            ph.TINHTRANG = "Đang sử dụng";

            db.SubmitChanges();
            ViewBag.kq = 1;
            return View();
        }

        public ActionResult TraPhong(string maph, string mahd)
        {
            CTHD p = db.CTHDs.SingleOrDefault(t => t.MAHD == mahd && t.MAPH == maph);
            if (p == null)
            {
                return HttpNotFound("Không tìm thấy thông tin phòng hoặc hóa đơn.");
            }
            p.TINHTRANG = "Đã trả phòng";
            DateTime now = DateTime.Now;
            TimeSpan kc = now - p.NGAYTRA.Value;
            if (kc.TotalHours < 0)
            {
                if (Math.Abs(kc.TotalHours) <= 24)
                {
                    TempData["ThongBao"] = "Khách trả phòng sớm, không phụ thu.";
                }
                else
                {
                    TempData["ThongBao"] = "Khách trả phòng sớm trong ngày. Phụ thu 1 đêm tiền phòng.";
                    p.THANHTIEN += p.PHONG.GIAPHONG * (decimal)0.5;
                }
            }
            else if (kc.TotalHours <= 4)
            {
                TempData["ThongBao"] = "Khách trả phòng trễ trước 4 giờ chiều. Phụ thu 1 đêm tiền phòng.";
                p.THANHTIEN += p.PHONG.GIAPHONG * (decimal)0.5;
            }
            else
            {
                TempData["ThongBao"] = "Khách trả phòng trễ sau 4 giờ chiều. Phụ thu 1 đêm tiền phòng.";
                p.THANHTIEN += p.PHONG.GIAPHONG * (decimal)0.5;
            }

            if (p.HOADON.TINHTRANG != "Đã thanh toán")
            {
                TempData["ThanhToanHD"] = p.MAPH;
                return RedirectToAction("ThanhToan", new { mahd = p.MAHD });
            }

            PHONG ph = p.PHONG;
            ph.TINHTRANG = "Còn trống";

            db.SubmitChanges();
            return RedirectToAction("ThanhToan", new { mahd = mahd });
        }


        [HttpPost]
        public ActionResult XacNhanThanhToan(double? tientra, string pt = "PT001", string mahd = null)
        {
            if (tientra == 0) tientra = null;
            if(mahd == null)
            {
                TempData["tt"] = 1;
                return RedirectToAction("LuuHoaDon", new { mapt = pt, tientra = tientra});
            }
            HOADON hd = db.HOADONs.SingleOrDefault(t => t.MAHD == mahd);
            hd.NGAYTHANHTOAN = DateTime.Now.ToLocalTime();
            if(hd.DATRA == null)
            {
                if((decimal)tientra == hd.TONGTIEN)
                {
                    hd.DATRA = (decimal)tientra;
                }
                else { hd.DATRA = (decimal)tientra; hd.TINHTRANG = "Thanh toán một phần"; }
            }
            else
            {
                if((decimal)tientra == (hd.TONGTIEN - (decimal)tientra))
                {
                    hd.DATRA = (decimal)tientra;
                }
                else
                {
                    hd.DATRA += (decimal)tientra;
                    hd.TINHTRANG = "Thanh toán một phần";
                }
            }
            if(hd.DATRA == hd.TONGTIEN)
            {
                hd.TINHTRANG = "Đã thanh toán";
            }
            db.SubmitChanges();
            return RedirectToAction("ThanhToan", new { mahd = mahd });
        }

        public ActionResult DanhSachHD()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            return View(db.HOADONs.OrderBy(t => t.TONGTIEN).ToList());
        }
        //LoaiPhong
        public ActionResult DanhSachLoaiPhong()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            return View(db.LOAIPHONGs.OrderBy(t => t.TENLOAI).ToList());
        }

        public ActionResult ThemLoaiPhong()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemLoaiPhong(LOAIPHONG lp)
        {
            while (true)
            {
                lp.MALOAI = _base.taoMa();
                if (db.LOAIPHONGs.SingleOrDefault(t => t.MALOAI == lp.MALOAI) == null)
                {
                    break;
                }
            }
            db.LOAIPHONGs.InsertOnSubmit(lp);
            try
            {
                db.SubmitChanges();
            }catch{ }
            return RedirectToAction("DanhSachLoaiPhong");
        }

        public ActionResult XoaLoaiPhong(string maloai)
        {
            db.LOAIPHONGs.DeleteOnSubmit(db.LOAIPHONGs.SingleOrDefault(t => t.MALOAI == maloai));
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachLoaiPhong");
        }

        //phong
        public ActionResult DanhSachPhong()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            return View(db.PHONGs.OrderBy(t => t.TENPH).ToList());
        }

        public ActionResult ThemPhong()
        {
            ViewBag.loai = db.LOAIPHONGs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ThemPhong(PHONG lp, string maloai)
        {
            while (true)
            {
                lp.MAPH = _base.taoMa();
                if (db.PHONGs.SingleOrDefault(t => t.MAPH == lp.MAPH) == null)
                {
                    break;
                }
            }
            lp.TINHTRANG = "Còn trống";
            lp.MALOAI = maloai;
            db.PHONGs.InsertOnSubmit(lp);
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachPhong");
        }

        public ActionResult CapNhatPhong(string maph)
        {
            ViewBag.loai = db.LOAIPHONGs.ToList();
            return View(db.PHONGs.SingleOrDefault(t => t.MAPH == maph));
        }
        [HttpPost]
        public ActionResult CapNhatPhong(PHONG lp, string maloai, string tinhtrang)
        {
            PHONG i = db.PHONGs.SingleOrDefault(t => t.MAPH == lp.MAPH);
            if (maloai == "--Chọn loại phòng--") maloai = i.MALOAI;
            i = lp;
            i.MALOAI = maloai;
            i.TINHTRANG = tinhtrang;
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachPhong");
        }

        public ActionResult XoaPhong(string maph)
        {
            db.PHONGs.DeleteOnSubmit(db.PHONGs.SingleOrDefault(t => t.MAPH == maph));
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachPhong");
        }

        //dichvu
        public ActionResult DanhSachDichVu()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            return View(db.DICHVUs.OrderBy(t => t.TENDV).ToList());
        }

        public ActionResult ThemDichVu_ds()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ThemDichVu_ds(DICHVU lp)
        {
            while (true)
            {
                lp.MADV = _base.taoMa();
                if (db.DICHVUs.SingleOrDefault(t => t.MADV == lp.MADV) == null)
                {
                    break;
                }
            }
            db.DICHVUs.InsertOnSubmit(lp);
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachDichVu");
        }

        public ActionResult XoaDichVu(string madv)
        {
            db.DICHVUs.DeleteOnSubmit(db.DICHVUs.SingleOrDefault(t => t.MADV == madv));
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachDichVu");
        }

        //in hoá đơn
        public ActionResult InHoaDon(string mahd)
        {
            ViewBag.hd = db.HOADONs.SingleOrDefault(t => t.MAHD == mahd);
            ViewBag.cthd = db.CTHDs.Where(t => t.MAHD == mahd).ToList();
            ViewBag.ctdv = db.CTDVs.Where(t => t.MAHD == mahd).ToList();
            return View();
        }

        //nhanviên
        public ActionResult DanhSachNhanVien()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            return View(db.NHANVIENs.OrderBy(t => t.MABP).ToList());
        }

        public ActionResult ThemNhanVien()
        {
            ViewBag.bp = db.BOPHANs.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult ThemNhanVien(NHANVIEN lp, string mabp, string tendn = null, string mk = null)
        {
            while (true)
            {
                lp.MANV = _base.taoMa();
                if (db.NHANVIENs.SingleOrDefault(t => t.MANV == lp.MANV) == null)
                {
                    break;
                }
            }
            lp.MABP = mabp;
            db.NHANVIENs.InsertOnSubmit(lp);
            try
            {
                db.SubmitChanges();
            }
            catch { }
            if(tendn != null && mk != null)
            {
                TAIKHOAN tk = new TAIKHOAN();
                tk.TENDN = tendn;
                tk.MK = mk;
                tk.MANV = lp.MANV;
                db.TAIKHOANs.InsertOnSubmit(tk);
                try
                {
                    db.SubmitChanges();
                }
                catch { }
            }
            return RedirectToAction("DanhSachNhanVien");
        }

        public ActionResult CapNhatNhanVien(string manv)
        {
            ViewBag.bp = db.BOPHANs.ToList();
            ViewBag.tk = db.TAIKHOANs.SingleOrDefault(t => t.MANV == manv);
            return View(db.NHANVIENs.SingleOrDefault(t => t.MANV == manv));
        }
        [HttpPost]
        public ActionResult CapNhatNhanVien(NHANVIEN lp, string mabp, string tendn = null, string mk = null)
        {
            NHANVIEN i = db.NHANVIENs.SingleOrDefault(t => t.MANV == lp.MANV);
            if (mabp == "--Chọn bọ phận--") mabp = i.MABP;
            i = lp;
            i.MABP = mabp;
            try
            {
                db.SubmitChanges();
            }
            catch { }
            if (tendn != null && mk != null)
            {
                TAIKHOAN tk = db.TAIKHOANs.SingleOrDefault(t => t.MANV == lp.MANV);
                tk.TENDN = tendn;
                tk.MK = mk;
                try
                {
                    db.SubmitChanges();
                }
                catch { }
            }
            return RedirectToAction("DanhSachNhanVien");
        }

        public ActionResult XoaNhanVien(string manv)
        {
            db.NHANVIENs.DeleteOnSubmit(db.NHANVIENs.SingleOrDefault(t => t.MANV == manv));
            try
            {
                db.SubmitChanges();
            }
            catch { }
            return RedirectToAction("DanhSachNhanVien");
        }
    }
}