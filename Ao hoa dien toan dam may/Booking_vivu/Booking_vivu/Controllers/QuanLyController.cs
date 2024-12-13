using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking_vivu.Controllers
{
    public class QuanLyController : Controller
    {
		dataDataContext db = new dataDataContext();
		// GET: QuanLy
		public ActionResult DS_HoaDon()
        {
			return View(db.HOADONs.ToList());
        }
    }
}