using Microsoft.AspNetCore.Mvc;

namespace FitLife.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
