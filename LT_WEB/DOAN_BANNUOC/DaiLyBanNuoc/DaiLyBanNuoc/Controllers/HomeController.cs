using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DaiLyBanNuoc.Models;
namespace DaiLyBanNuoc.Controllers
{
    public class HomeController : Controller
    {
        dataDataContext db = new dataDataContext();
        public bool ktrDN()
        {
            if (Session["user"] != null) return true;
            return false;
        }

        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(KhachHang kh, string MatKhau2)
        {
            if (db.KhachHangs.SingleOrDefault(t => t.DienThoai == kh.DienThoai) == null) { 
                if ( kh.MatKhau == MatKhau2)
                {
                    db.KhachHangs.InsertOnSubmit(kh);
                    try
                    {
                        db.SubmitChanges();
                        ViewBag.tb = "Đăng ký thành công";
                        return RedirectToAction("ChiTietSP");
                    }
                    catch { ViewBag.tb = "Lỗi đăng ký"; }
                }
                else
                {
                    ViewBag.tb = "Mật khẩu nhập lại không trùng khớp";
                }
            }
            else
            {
                ViewBag.tb = "Số điện thoại này đã đăng ký";
            }

            return View();
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string sdt, string mk)
        {
            KhachHang kh = db.KhachHangs.SingleOrDefault(t => t.DienThoai == sdt && t.MatKhau == mk);
            if (kh != null)
            {
                Session["user"] = kh;
                ViewBag.tb = "Đăng nhập thành công";
                return RedirectToAction("ChiTietSP");
            }
            else
            {
                ViewBag.tb = "Sai mật khẩu hoặc số điện thoại";
            }
            return View();
        }

        public ActionResult DangXuat()
        {
            Session["user"] = null;
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult TimKiem(string tukhoa)
        {
            Session["dssp"] = db.SanPhams.Where(t => t.TenSP.Contains(tukhoa)).ToList();
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult ChiTietSP(int i = 0)
        {
            if(i != 0)
            {
                Session["dssp"] = null;
            }
            if (Session["dssp"] != null) { ViewBag.dssp = Session["dssp"]; return View(); }
            ViewBag.dssp = db.SanPhams.OrderBy(t => t.TenSP).ToList();
            return View();
        }

        public ActionResult DanhMuc_Loai()
        {
            return View(db.LoaiSanPhams.OrderBy(t => t.TenLoaiSP).ToList());
        }

        public ActionResult LocSP_Loai(int maloai)
        {
            TempData["loai"] = maloai;
            Session["dssp"] = db.SanPhams.Where(t => t.MaLoaiSP == maloai).OrderBy(t => t.TenSP).ToList();
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult ThemGioHang(int masp, int sl = 1)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(t => t.MaSP == masp);
            List<GioHang> giohang;
            if(Session["GioHang"] == null)
            {
                giohang = new List<GioHang>();
            }
            else
            {
                giohang = Session["GioHang"] as List<GioHang>;
            }
            if(giohang.SingleOrDefault(t => t.SP.MaSP == masp) == null)
            {
                GioHang sp_new = new GioHang();
                sp_new.SP = sp;
                sp_new.SL = 1;
                giohang.Add(sp_new);
            }
            else
            {
                giohang.SingleOrDefault(t => t.SP.MaSP == masp).SL += sl;
            }
            Session["GioHang"] = giohang;
            return RedirectToAction("ChiTietSP", "Home");
        }

        public ActionResult XoaGioHangAll()
        {
            Session["GioHang"] = null;
            return RedirectToAction("ChiTietSP", "Home");
        }

        public ActionResult ht_GioHang()
        {
            return View();
        }

        public ActionResult ht_GioHang_Full()
        {
            return View();
        }

        public ActionResult CapNhatSL(int masp, int sl_new)
        {
            List<GioHang> giohang = Session["GioHang"] as List<GioHang>;
            giohang.SingleOrDefault(t => t.SP.MaSP == masp).SL = sl_new;
            return RedirectToAction("ht_GioHang_Full");
        }

        public ActionResult XoaSP(int masp)
        {
            List<GioHang> giohang = Session["GioHang"] as List<GioHang>;
            giohang.Remove(giohang.SingleOrDefault(t => t.SP.MaSP == masp));
            return RedirectToAction("ht_GioHang_Full");
        }

        public ActionResult GiaTang()
        {
            List<SanPham> giohang = Session["dssp"] as List<SanPham>;
            if(giohang == null)
            {
                giohang = db.SanPhams.ToList();
            }
            Session["dssp"] = giohang.OrderBy(t => t.GiaBan).ToList();
            Session["sx"] = "Giá thấp đến cao";
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult GiaGiam()
        {
            List<SanPham> giohang = Session["dssp"] as List<SanPham>;
            if (giohang == null)
            {
                giohang = db.SanPhams.ToList();
            }
            Session["dssp"] = giohang.OrderByDescending(t => t.GiaBan).ToList();
            Session["sx"] = "Giá cao đến thấp";
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult ThanhToan()
        {
            if (!ktrDN()) return RedirectToAction("DangNhap");
            int mahd = 0;
            try
            {
                mahd = db.DonHangs.Max(t => t.MaDonHang);
            }
            catch { }
            DonHang dh = new DonHang();
            dh.MaDonHang = mahd;
            dh.MaKH = (Session["user"] as KhachHang).MaKH;
            dh.NgayDat = DateTime.Now;
            dh.TinhTrang = "Đang xử lý";
            db.DonHangs.InsertOnSubmit(dh);
            try
            {
                db.SubmitChanges();
            }
            catch { }
            List<GioHang> gh = Session["GioHang"] as List<GioHang>;
            foreach(var i in gh)
            {
                ChiTietDonHang t = new ChiTietDonHang();
                t.MaDonHang = dh.MaDonHang;
                t.MaSP = i.SP.MaSP;
                t.SoLuong = i.SL;
                t.ThanhTien = i.SP.GiaBan * i.SL;
                SanPham ton = db.SanPhams.SingleOrDefault(tp => tp.MaSP == t.MaSP);
                if (ton.SoLuongTon >= t.SoLuong)
                {
                    ton.SoLuongTon -= t.SoLuong;
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
                else
                {
                    Session["Het"] = ton.TenSP;
                    return RedirectToAction("ChiTietSP");
                }
                db.ChiTietDonHangs.InsertOnSubmit(t);
                try
                {
                    db.SubmitChanges();
                }
                catch { }
                
            }
            Session["tb"] = "Thêm thành công";
            Session["GioHang"] = null;
            return RedirectToAction("ChiTietSP");
        }

        public ActionResult HoaDon()
        {
            KhachHang kh = Session["user"] as KhachHang;
            List<DonHang> dh = db.DonHangs.Where(t => t.MaKH == kh.MaKH).ToList();
            return View(dh);
        }

        public ActionResult ChiTietDH(int madh)
        {
            List<ChiTietDonHang> ctdh = db.ChiTietDonHangs.Where(t => t.MaDonHang == madh).ToList();
            return View(ctdh);
        }

        public ActionResult ChiTietSP_1(int masp)
        {
            return View(db.SanPhams.SingleOrDefault(t => t.MaSP == masp));
        }
    }
}