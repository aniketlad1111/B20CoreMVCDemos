using DataPassingTechniquesDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DataPassingTechniquesDemo.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("user")]
        public IActionResult Index()
        {
            //ViewBag.CommonData = TempData["commonData"];

            ViewBag.CommonData = TempData.Peek("commonData");

            return View();
        }
    }
}
