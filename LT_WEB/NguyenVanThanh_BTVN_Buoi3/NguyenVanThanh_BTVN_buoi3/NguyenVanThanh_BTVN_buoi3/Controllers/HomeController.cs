using Microsoft.AspNetCore.Mvc;
using NguyenVanThanh_BTVN_buoi3.Models;

namespace NguyenVanThanh_BTVN_buoi3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PhongBan> ds = new List<PhongBan>();
            PhongBan x = new PhongBan("P1", "Phòng giám đốc");
            ds.Add(x);
            x = new PhongBan("P2", "Phòng kế hoạch");
            ds.Add(x);
            x = new PhongBan("P3", "Phòng kế toán");
            ds.Add(x);
            x = new PhongBan("P4", "Phòng sản xuất");
            ds.Add(x);
            x = new PhongBan("P5", "Phòng kinh doanh");
            ds.Add(x);
            ViewBag.ds = ds;
            return View();
        }
    }
}
