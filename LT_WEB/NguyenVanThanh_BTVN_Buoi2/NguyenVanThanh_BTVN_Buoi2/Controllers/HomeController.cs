using Microsoft.AspNetCore.Mvc;

namespace NguyenVanThanh_BTVN_Buoi2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult DangNhap()
        {
            return View();
        }

        public IActionResult DangKy()
        {
            return View();
        }
    }
}
