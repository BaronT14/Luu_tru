using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booking_vivu.Models;

namespace Booking_vivu.Controllers
{
    public class HomeController : Controller
    {
        dataDataContext db = new dataDataContext();
        loginModel model;

        public bool check_Phone(string phone) {
            if (db.KHACHHANGs.Where(t => t.SDT == phone) != null)
            {
                return false;
            }
            return true;
        }


        public bool check_login(loginModel model)
        {
            var result = db.KHACHHANGs.FirstOrDefault(t => t.SDT == model.PhoneNumber && t.PASSWORD == model.Password);
            if (result != null)
            {
                Session["UserSession"] = result;
                return true;
            }
            return false;
        }

        public string createMa()
        {
            Random random = new Random();
            string rs = random.Next(1000000000, int.MaxValue).ToString();

            var result = db.KHACHHANGs.Where(t => t.MAKH == rs);
            if (result != null)
            {
                return rs;
            }
            return "0";
        }
        // GET: Home
        public ActionResult TrangChu()
        {
            var dn = Session["UserSession"];
            if (dn == null)
            {
                ViewBag.s = 0;
            }
            else
                ViewBag.s = 1; // Đã đăng nhập
            return View();
        }

        public ActionResult Login()
        {
            var dn = Session["UserSession"];
            if (dn == null)
                ViewBag.s = 0; // Chưa đăng nhập
            else
                ViewBag.s = 1; // Đã đăng nhập
            return View();
        }

        [HttpPost]
        public ActionResult Login(string PhoneNumber, string Password)
        {
            if (PhoneNumber.Length != 0 && Password.Length != 0)
            {
                model = new loginModel(PhoneNumber, Password);
                if (check_login(model))
                {
                    return RedirectToAction("TrangChu");
                }
                else
                {
                    ViewBag.s = 0;
                    ViewBag.kq = 0;
                    return View();
                }
            }
            ViewBag.tb = "Chưa nhập mật khẩu hoặc số điện thoại";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Remove("UserSession");
            return RedirectToAction("TrangChu");
        }

        //Đăng ký
        public ActionResult Register()
        {
            var dn = Session["UserSession"];
            if (dn == null)
                ViewBag.s = 0; // Chưa đăng nhập
            else
                ViewBag.s = 1; // Đã đăng nhập
            return View();
        }
        [HttpPost]
        public ActionResult Register(KHACHHANG user)
        {
            if (ModelState.IsValid)
            {
                if (db.KiemTraSDTHopLe(user.SDT) == true)
                {
                    var makh = createMa();
                    while(makh == "0")
                    {
                        makh = createMa();
                    }
                    user.MAKH = makh;
                    db.KHACHHANGs.InsertOnSubmit(user);
                    db.SubmitChanges();
                    return RedirectToAction("TrangChu");
                }
            }
            return View(user);
        }

        public ActionResult thongTinCaNhan()
        {
            KHACHHANG user = Session["UserSession"] as KHACHHANG;
            return View(user);
        }

        public ActionResult ds_hoa_don()
        {
            return View(Session["donDat"]);
        }
    }
}