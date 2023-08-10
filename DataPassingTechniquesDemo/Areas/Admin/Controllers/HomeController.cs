using DataPassingTechniquesDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DataPassingTechniquesDemo.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        //[Area("Admin")]
        public IActionResult Index()
        {
            //ViewBag.CommonData = TempData["commonData"];
            //TempData.Keep("commonData");

            ViewBag.CommonData = TempData.Peek("commonData");

            //ViewBag.CookieData = Request.Cookies["DemoUsername"];

            //ViewBag.userDetails = JsonSerializer.Deserialize<LoginModel>
                //(Request.Cookies["userDetails"]);

            ViewBag.SessionUserName = HttpContext.Session.GetString("sessionUsername");

            string user1 = HttpContext.Session.GetString("NewUser");
            ViewBag.NewUser = JsonSerializer.Deserialize<LoginModel>(user1);

            return View();
        }
    }
}
