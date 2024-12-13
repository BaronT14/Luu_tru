using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Booking_vivu.Models;

namespace Booking_vivu.Controllers
{
    public class TourController : Controller
    {
        dataDataContext db = new dataDataContext();

        // GET: Tour
        public void create_HD()
        {
            string rs;
            object r = null;
            do
            {
                Random random = new Random();
                rs = random.Next(1000000000, int.MaxValue).ToString();

                r = db.HOADONs.Where(t => t.IDHD == rs);
            }
            while (r != null);
            HOADON hd = new HOADON();
            hd.IDHD = rs;
        }


        public ActionResult ht_Tour()
        {
            return View(db.TOURs.Take(5).ToList());
        }

        public ActionResult dd_Tour()
        {
            return View(db.TOURs.GroupBy(t => t.DIADIEMTOUR).Select(g => g.FirstOrDefault()).ToList());
        }

        public ActionResult HienThiTour()
        {
            if(Session["UserSession"] == null)
            {
                ViewBag.s = 0;
                return RedirectToAction("Login", "Home");
            }
            return View(db.TOURs.ToList());
        }

        public ActionResult donDat_Tour(string id)
        {
            if (Session["UserSession"] == null)
            {
                ViewBag.s = 0;
                return RedirectToAction("Login", "Home");
            }
            ViewBag.chiTietTour = db.TOURs.FirstOrDefault(t => t.TOURID == id);
            ViewBag.ngaytc = db.fc_ngaytochuc_theothang(id, DateTime.Now.Month);
            ViewBag.ngaytc1 = db.fc_ngaytochuc_theothang(id, 0);
            return View();
        }
        [HttpPost]
        public ActionResult donDat_Tour(string id, string ddd, int sl, DateTime ngaykh)
        {
            List<ddtour> donDat = new List<ddtour>();
            ddtour i = new ddtour();
            CTHD t = new CTHD();
            if(Session["donDat"] != null)
            {
                donDat = Session["donDat"] as List<ddtour>;
            }
            t.IDTOUR = id;
            t.DIADIEMDON = ddd;
            t.SL = sl;
            t.NGAYKH = ngaykh;
            t.NGAYKT = db.LayThoiGianKetThucTour(id, ngaykh);
            //t.NGAYKT = db.LayThoiGianKetThucTour(id, t.NGAYKH);
            i.CTHD = t;
            i.TOUR = db.TOURs.FirstOrDefault(k => k.TOURID == id);
            donDat.Add(i);
            Session["donDat"] = donDat;
            return RedirectToAction("ds_hoa_don", "Home");
        }

        public ActionResult xoa_donDat_Tour(string id)
        {
            List<ddtour> dd = Session["donDat"] as List<ddtour>;
            var tmp = dd.FirstOrDefault(t => t.CTHD.IDTOUR == id);
            dd.Remove(tmp);
            Session["donDat"] = dd;
            return RedirectToAction("ds_hoa_don", "Home");
        }
    }
}