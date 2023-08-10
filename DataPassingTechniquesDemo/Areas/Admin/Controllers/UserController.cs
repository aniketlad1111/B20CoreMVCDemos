using Microsoft.AspNetCore.Mvc;

namespace DataPassingTechniquesDemo.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        //[Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
