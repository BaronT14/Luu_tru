using Microsoft.AspNetCore.Mvc;
using todoList.Models;

namespace todoList.Controllers
{
    public class AppController : Controller
    {
        public IActionResult homePage()
        {
            DBConnect cn = new DBConnect();
            List<todoUser> list = cn.getData(1);
            ViewBag.chualam = list.Where(t => t.isComplete == "False").ToList().Count();
            return View(list);
        }

        public IActionResult detail(int todoId)
        {
            DBConnect cn = new DBConnect();
            List<todoUser> list = cn.getData(1);
            foreach (todoUser i in list)
            {
                if (i.todoId == todoId)
                    return View(i);
            }
            return View();
        }
    }
}
